using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _3DModel
{
    internal class Draw
    {
        private static Pen pen = new Pen(Color.Black, 1);

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
                    //if (!face.IsFrontCurrent) continue;
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int)
                            (line.Start.X + bmp.Width/2),
                            (int)
                            (line.Start.Y + bmp.Height/2));
                        Point end = new Point(
                            (int)
                            (line.End.X + bmp.Width/2),
                            (int)
                            (line.End.Y + bmp.Height/2));
                        g.DrawLine(pen, start, end);
                    }
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
                g.DrawString("Горизонт.", new Font(FontFamily.Families[18], 10, FontStyle.Regular), Brushes.Black,
                             new PointF(15, bmp.Height - 15));
                foreach (Face face in model.faces)
                {
                    //if (!face.IsFrontCurrent) continue;
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
                            (line.End.Z + bmp.Height/2));
                        g.DrawLine(pen, start, end);
                    }
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
                g.DrawString("Профил.", new Font(FontFamily.Families[18], 10, FontStyle.Regular), Brushes.Black,
                             new PointF(bmp.Width - 70, 10));
                foreach (Face face in model.faces)
                {
                    //if (!face.IsFrontCurrent) continue;
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
                            (line.End.Y + bmp.Height/2));
                        g.DrawLine(pen, start, end);
                    }
                }
            }
        }

        public static void DrawObjectAkson(Bitmap bmp, BaseModel model)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Face face in model.faces)
                {
                    //if (!face.IsFrontCurrent) continue;
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int)
                            (line.Start.X + bmp.Width/2),
                            (int)
                            (line.Start.Y + bmp.Height/2));
                        Point end = new Point(
                            (int)
                            (line.End.X + bmp.Width/2),
                            (int)
                            (line.End.Y + bmp.Height/2));
                        g.DrawLine(pen, start, end);
                    }
                }
            }
        }
    }
}