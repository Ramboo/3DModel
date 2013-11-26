using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace _3DModel
{
    internal class Draw
    {
        private static Pen pen = new Pen(Color.Black, 1);
        private static SolidBrush frameBrush = new SolidBrush(Color.Black);
        private static SolidBrush insidesBrush = new SolidBrush(Color.Red);

        public static void DrawAxis(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(pen, 0, bmp.Height/2, bmp.Width, bmp.Height/2); //x
                g.DrawLine(pen, bmp.Width/2, 0, bmp.Width/2, bmp.Height); //y
                g.DrawLine(pen, 0, bmp.Height, bmp.Width, 0); //z
                g.DrawString("X", new Font(FontFamily.Families[10], 15, FontStyle.Regular), Brushes.Black,
                             bmp.Width - 20, bmp.Height/2);
                g.DrawString("Y", new Font(FontFamily.Families[10], 15, FontStyle.Regular), Brushes.Black,
                             bmp.Width/2 + 5, 5);
                g.DrawString("Z", new Font(FontFamily.Families[10], 15, FontStyle.Regular), Brushes.Black,
                             bmp.Width - 20, 20);
            }
        }

        public static void DrawObjectFront(Bitmap bmp, BaseModel model)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Face face in model.faces)
                {
                    List<Line> faceLines = new List<Line>();
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point((int) (line.Start.X + bmp.Width/2), (int) (line.Start.Y + bmp.Height/2));
                        Point end = new Point((int) (line.End.X + bmp.Width/2), (int) (line.End.Y + bmp.Height/2));
                        faceLines.Add(new Line(new PointD(start.X, start.Y, 0), new PointD(end.X, end.Y, 0)));
                    }
                    List<PointD>[] facePoints = Face.GetFacePoints(new Face {Lines = faceLines});
                    foreach (PointD p in facePoints[1])
                        g.FillRectangle(insidesBrush, (int) p.X, (int) p.Y, 1, 1);
                    foreach (PointD p in facePoints[0])
                        g.FillRectangle(frameBrush, (int) p.X, (int) p.Y, 1, 1);
                }
            }
        }

        public static void DrawObjectHoriz(Bitmap bmp, BaseModel model)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLines(pen, new[]
                    {
                        new Point(10, bmp.Height - 15),
                        new Point(10, bmp.Height - 5),
                        new Point(7, bmp.Height - 8),
                        new Point(10, bmp.Height - 5),
                        new Point(13, bmp.Height - 8)
                    });
                g.DrawString("Гориз.", new Font(FontFamily.Families[35], 12, FontStyle.Regular), Brushes.Black,
                             new PointF(15, bmp.Height - 25));
                foreach (Face face in model.faces)
                {
                    List<Line> faceLines = new List<Line>();
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int)
                            (line.Start.X + bmp.Width/2),
                            (int)
                            (line.Start.Z + bmp.Height/2));
                        Point end = new Point(
                            (int)
                            (line.End.X + bmp.Width/2),
                            (int)
                            (line.End.Z + bmp.Height / 2));
                        faceLines.Add(new Line(new PointD(start.X, start.Y, 0), new PointD(end.X, end.Y, 0)));
                    }
                    List<PointD>[] facePoints = Face.GetFacePoints(new Face { Lines = faceLines });
                    foreach (PointD p in facePoints[1])
                        g.FillRectangle(insidesBrush, (int)p.X, (int)p.Y, 1, 1);
                    foreach (PointD p in facePoints[0])
                        g.FillRectangle(frameBrush, (int)p.X, (int)p.Y, 1, 1);
                }
            }
        }

        public static void DrawObjectProf(Bitmap bmp, BaseModel model)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLines(pen, new[]
                    {
                        new Point(bmp.Width - 15, 5),
                        new Point(bmp.Width - 5, 5),
                        new Point(bmp.Width - 9, 2),
                        new Point(bmp.Width - 5, 5),
                        new Point(bmp.Width - 9, 8)
                    });
                g.DrawString("Профил.", new Font(FontFamily.Families[35], 12, FontStyle.Regular), Brushes.Black,
                             new PointF(bmp.Width - 70, 10));
                foreach (Face face in model.faces)
                {
                    List<Line> faceLines = new List<Line>();
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int)
                            (line.Start.Z + bmp.Width/2),
                            (int)
                            (line.Start.Y + bmp.Height/2));
                        Point end = new Point(
                            (int)
                            (line.End.Z + bmp.Width/2),
                            (int)
                            (line.End.Y + bmp.Height / 2));
                        faceLines.Add(new Line(new PointD(start.X, start.Y, 0), new PointD(end.X, end.Y, 0)));
                    }
                    List<PointD>[] facePoints = Face.GetFacePoints(new Face { Lines = faceLines });
                    foreach (PointD p in facePoints[1])
                        g.FillRectangle(insidesBrush, (int)p.X, (int)p.Y, 1, 1);
                    foreach (PointD p in facePoints[0])
                        g.FillRectangle(frameBrush, (int)p.X, (int)p.Y, 1, 1);
                }
            }
        }

        public static void DrawObjectAkson(Bitmap bmp, BaseModel model, double ax, double ay)
        {
            ax = (Math.PI/180)*ax; //rad's
            ay = (Math.PI/180)*ay; //rad's
            double[][] _rotateArray = new[]
                {
                    new[] {Math.Cos(ay), Math.Sin(ax)*Math.Sin(ay), 0, 0},
                    new[] {0, Math.Cos(ax), 0, 0},
                    new[] {Math.Sin(ay), -Math.Sin(ax)*Math.Cos(ax), 0, 0},
                    new[] {0, 0, 0, 1.0}
                };
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawString("Аксоном.", new Font(FontFamily.Families[35], 12, FontStyle.Regular), Brushes.Black,
                             new PointF(bmp.Width - 80, 10));
                foreach (Face face in model.faces)
                {
                    List<Line> faceLines = new List<Line>();
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int)
                            (line.Start.X*_rotateArray[0][0] + line.Start.Y*_rotateArray[1][0] +
                             line.Start.Z*_rotateArray[2][0] + _rotateArray[3][0] + bmp.Width/2),
                            (int)
                            (line.Start.X*_rotateArray[0][1] + line.Start.Y*_rotateArray[1][1] +
                             line.Start.Z*_rotateArray[2][1] + _rotateArray[3][1] + bmp.Height/2));
                        Point end = new Point(
                            (int)
                            (line.End.X*_rotateArray[0][0] + line.End.Y*_rotateArray[1][0] +
                             line.End.Z*_rotateArray[2][0] + _rotateArray[3][0] + bmp.Width/2),
                            (int)
                            (line.End.X*_rotateArray[0][1] + line.End.Y*_rotateArray[1][1] +
                             line.End.Z * _rotateArray[2][1] + _rotateArray[3][1] + bmp.Height / 2));
                        faceLines.Add(new Line(new PointD(start.X, start.Y, 0), new PointD(end.X, end.Y, 0)));
                    }
                    List<PointD>[] facePoints = Face.GetFacePoints(new Face { Lines = faceLines });
                    foreach (PointD p in facePoints[1])
                        g.FillRectangle(insidesBrush, (int)p.X, (int)p.Y, 1, 1);
                    foreach (PointD p in facePoints[0])
                        g.FillRectangle(frameBrush, (int)p.X, (int)p.Y, 1, 1);
                }
            }
        }

        public static void DrawObjectKosoug(Bitmap bmp, BaseModel model, double l, double alpha)
        {
            alpha = (Math.PI/180)*alpha; //rad's
            double[][] _rotateArray = new[]
                {
                    new[] {1, 0, 0, 0.0},
                    new[] {0, 1, 0, 0.0},
                    new[] {l*Math.Cos(alpha), l*Math.Sin(alpha), 0, 0},
                    new[] {0, 0, 0, 1.0}
                };
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawString("Косоуг.", new Font(FontFamily.Families[35], 12, FontStyle.Regular), Brushes.Black,
                             new PointF(bmp.Width - 80, 10));
                foreach (Face face in model.faces)
                {
                    List<Line> faceLines = new List<Line>();
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int)
                            (line.Start.X*_rotateArray[0][0] + line.Start.Y*_rotateArray[1][0] +
                             line.Start.Z*_rotateArray[2][0] + _rotateArray[3][0] + bmp.Width/2),
                            (int)
                            (line.Start.X*_rotateArray[0][1] + line.Start.Y*_rotateArray[1][1] +
                             line.Start.Z*_rotateArray[2][1] + _rotateArray[3][1] + bmp.Height/2));
                        Point end = new Point(
                            (int)
                            (line.End.X*_rotateArray[0][0] + line.End.Y*_rotateArray[1][0] +
                             line.End.Z*_rotateArray[2][0] + _rotateArray[3][0] + bmp.Width/2),
                            (int)
                            (line.End.X*_rotateArray[0][1] + line.End.Y*_rotateArray[1][1] +
                             line.End.Z * _rotateArray[2][1] + _rotateArray[3][1] + bmp.Height / 2));
                        faceLines.Add(new Line(new PointD(start.X, start.Y, 0), new PointD(end.X, end.Y, 0)));
                    }
                    List<PointD>[] facePoints = Face.GetFacePoints(new Face { Lines = faceLines });
                    foreach (PointD p in facePoints[1])
                        g.FillRectangle(insidesBrush, (int)p.X, (int)p.Y, 1, 1);
                    foreach (PointD p in facePoints[0])
                        g.FillRectangle(frameBrush, (int)p.X, (int)p.Y, 1, 1);
                }
            }
        }

        public static void DrawObjectPerspekt(Bitmap bmp, BaseModel model, double d, double sigma, double fi)
        {
            if (d.Equals(0)) d = 0.0001;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawString("Перспект.", new Font(FontFamily.Families[35], 12, FontStyle.Regular), Brushes.Black,
                             new PointF(bmp.Width - 80, 10));
                foreach (Face face in model.faces)
                {
                    List<Line> faceLines = new List<Line>();
                    foreach (Line line in face.Lines)
                    {
                        //double[][] _rotateArray = new[]
                        //    {
                        //        new[] {-Math.Sin(sigma), -Math.Cos(fi)*Math.Cos(sigma), -Math.Sin(fi)*Math.Cos(sigma), 0.0},
                        //        new[] {Math.Cos(sigma), -Math.Cos(fi)*Math.Sin(fi), -Math.Sin(fi)*Math.Sin(sigma), 0.0},
                        //        new[] {0, Math.Sin(fi), -Math.Cos(fi), 0},
                        //        new[] {0, 0, 0, 1.0}
                        //    };
                        //double xS = line.Start.X*_rotateArray[0][0] + line.Start.Y*_rotateArray[1][0] +
                        //            line.Start.Z*_rotateArray[2][0]/d + _rotateArray[3][0],
                        //       yS = line.Start.X*_rotateArray[0][1] + line.Start.Y*_rotateArray[1][1] +
                        //            line.Start.Z*_rotateArray[2][1]/d + _rotateArray[3][1],
                        //       zS = (line.Start.X*_rotateArray[0][2] + line.Start.Y*_rotateArray[1][2] +
                        //             line.Start.Z*_rotateArray[2][2]/d + _rotateArray[3][2]);
                        //double xE = line.End.X*_rotateArray[0][0] + line.End.Y*_rotateArray[1][0] +
                        //            line.End.Z*_rotateArray[2][0]/d + _rotateArray[3][0],
                        //       yE = line.End.X*_rotateArray[0][1] + line.End.Y*_rotateArray[1][1] +
                        //            line.End.Z*_rotateArray[2][1]/d + _rotateArray[3][1],
                        //       zE = (line.End.X*_rotateArray[0][2] + line.End.Y*_rotateArray[1][2] +
                        //             line.End.Z*_rotateArray[2][2]/d + _rotateArray[3][2]);
                        double xS = line.Start.X, yS = line.Start.Y, zS = line.Start.Z/d;
                        if (zS.Equals(0)) zS += 0.001;
                        if (zS != 1)
                        {
                            xS = xS/zS;
                            yS = yS/zS;
                        }
                        Point start = new Point((int) (xS + bmp.Width/2), (int) (yS + bmp.Height/2));
                        double xE = line.End.X, yE = line.End.Y, zE = line.End.Z/d;
                        if (zE.Equals(0)) zE += 0.001;
                        if (zE != 1)
                        {
                            xE = xE/zE;
                            yE = yE/zE;
                        }
                        Point end = new Point(
                            (int) (xE + bmp.Width/2),
                            (int) (yE + bmp.Height/2));
                        faceLines.Add(new Line(new PointD(start.X, start.Y, 0), new PointD(end.X, end.Y, 0)));
                    }
                    List<PointD>[] facePoints = Face.GetFacePoints(new Face {Lines = faceLines});
                    foreach (PointD p in facePoints[1])
                        g.FillRectangle(insidesBrush, (int) p.X, (int) p.Y, 1, 1);
                    foreach (PointD p in facePoints[0])
                        g.FillRectangle(frameBrush, (int) p.X, (int) p.Y, 1, 1);
                }
            }
        }
    }
}