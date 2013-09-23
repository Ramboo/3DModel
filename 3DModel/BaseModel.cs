using System;
using System.Collections.Generic;
using System.Linq;

namespace _3DModel
{
    class BaseModel
    {
        public double A { get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public double D { get; set; }

        public PointD BasePoint { get; set; }

        public List<Face> faces = new List<Face>(); 

        //public List<List<PointD>> faces = new List<List<PointD>>
        //    {
        //        new List<PointD>(),
        //        new List<PointD>()
        //    };

        public BaseModel(double x, double y, double z, double a, double b, double c, double d)
        {
            BasePoint = new PointD(x, y, z);
            A = a;
            B = b;
            C = c;
            D = d;

            faces = new List<Face>
                {
                    new Face //H front
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y, z), new PointD(x + A, y, z)),
                                    new Line(new PointD(x + A, y, z), new PointD(x + A, y + ((D - A)/2), z)),
                                    new Line(new PointD(x + A, y + ((D - A)/2), z),
                                             new PointD(x + A + (B - 2*A), y + ((D - A)/2), z)),
                                    new Line(new PointD(x + A + (B - 2*A), y + ((D - A)/2), z),
                                             new PointD(x + A + (B - 2*A), y, z)),
                                    new Line(new PointD(x + A + (B - 2*A), y, z),
                                             new PointD(x + A + (B - 2*A) + A, y, z)),
                                    new Line(new PointD(x + A + (B - 2*A) + A, y, z),
                                             new PointD(x + A + (B - 2*A) + A, y + D, z)),
                                    new Line(new PointD(x + A + (B - 2*A) + A, y + D, z),
                                             new PointD(x + A + (B - 2*A), y + D, z)),
                                    new Line(new PointD(x + A + (B - 2*A), y + D, z),
                                             new PointD(x + A + (B - 2*A), y + D - ((D - A)/2), z)),
                                    new Line(new PointD(x + A + (B - 2*A), y + D - ((D - A)/2), z),
                                             new PointD(x + A, y + D - ((D - A)/2), z)),
                                    new Line(new PointD(x + A, y + D - ((D - A)/2), z), new PointD(x + A, y + D, z)),
                                    new Line(new PointD(x + A, y + D, z), new PointD(x, y + D, z)),
                                    new Line(new PointD(x, y + D, z), new PointD(x, y, z))
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        },
                    new Face
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y, z), new PointD(x, y, z - C)),
                                    new Line(new PointD(x, y, z - C), new PointD(x + A, y, z - C)),
                                    new Line(new PointD(x + A, y, z - C), new PointD(x + A, y, z)),
                                    new Line(new PointD(x + A, y, z), new PointD(x, y, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 90,
                            zAngleCurrent = 0
                        },
                    new Face
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A, y, z), new PointD(x + A, y, z - C)),
                                    new Line(new PointD(x + A, y, z - C), new PointD(x + A, y + (D - A)/2, z - C)),
                                    new Line(new PointD(x + A, y + (D - A)/2, z - C), new PointD(x + A, y + (D - A)/2, z)),
                                    new Line(new PointD(x + A, y + (D - A)/2, z), new PointD(x + A, y, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 0,
                            zAngleCurrent = 90
                        },
                    new Face
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A, y + (D - A)/2, z), new PointD(x + A, y + (D - A)/2, z-C)),
                                    new Line(new PointD(x + A, y + (D - A)/2, z-C), new PointD(x + A+(B-2*A), y + (D - A)/2, z-C)),
                                    new Line(new PointD(x + A+(B-2*A), y + (D - A)/2, z-C), new PointD(x + A+(B-2*A), y + (D - A)/2, z)),
                                    new Line(new PointD(x + A+(B-2*A), y + (D - A)/2, z), new PointD(x + A, y + (D - A)/2, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 90,
                            zAngleCurrent = 0
                        },
                    new Face
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A + (B-2*A), y, z), new PointD(x + A + (B-2*A), y, z - C)),
                                    new Line(new PointD(x + A + (B-2*A), y, z - C), new PointD(x + A + (B-2*A), y + (D - A)/2, z - C)),
                                    new Line(new PointD(x + A + (B-2*A), y + (D - A)/2, z - C), new PointD(x + A + (B-2*A), y + (D - A)/2, z)),
                                    new Line(new PointD(x + A + (B-2*A), y + (D - A)/2, z), new PointD(x + A + (B-2*A), y, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 0,
                            zAngleCurrent = 90
                        },
                    new Face
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + (B-A), y, z), new PointD(x + (B-A), y, z - C)),
                                    new Line(new PointD(x + (B-A), y, z - C), new PointD(x + A + (B-A), y, z - C)),
                                    new Line(new PointD(x + A + (B-A), y, z - C), new PointD(x + A + (B-A), y, z)),
                                    new Line(new PointD(x + A + (B-A), y, z), new PointD(x + (B-A), y, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 90,
                            zAngleCurrent = 0
                        },
                    new Face
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + B, y, z), new PointD(x + B, y, z - C)),
                                    new Line(new PointD(x + B, y, z - C), new PointD(x + B, y + D, z - C)),
                                    new Line(new PointD(x + B, y + D, z - C), new PointD(x + B, y + D, z)),
                                    new Line(new PointD(x + B, y + D, z), new PointD(x + B, y, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 0,
                            zAngleCurrent = 90
                        },
                    new Face
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + B - A, y + D, z), new PointD(x + B - A, y + D, z - C)),
                                    new Line(new PointD(x + B - A, y + D, z - C), new PointD(x + B, y + D, z - C)),
                                    new Line(new PointD(x + B, y + D, z - C), new PointD(x + B, y + D, z)),
                                    new Line(new PointD(x + B, y + D, z), new PointD(x + B - A, y + D, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 90,
                            zAngleCurrent = 0
                        },
                    new Face
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A + (B-2*A), y + (D+A)/2, z), new PointD(x + A + (B-2*A), y + (D+A)/2, z - C)),
                                    new Line(new PointD(x + A + (B-2*A), y + (D+A)/2, z - C), new PointD(x + A + (B-2*A), y + (D - A)/2 + (D+A)/2, z - C)),
                                    new Line(new PointD(x + A + (B-2*A), y + (D - A)/2 + (D+A)/2, z - C), new PointD(x + A + (B-2*A), y + (D - A)/2 + (D+A)/2, z)),
                                    new Line(new PointD(x + A + (B-2*A), y + (D - A)/2 + (D+A)/2, z), new PointD(x + A + (B-2*A), y + (D+A)/2, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 0,
                            zAngleCurrent = 90
                        },
                    new Face
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A, y + (D - A)/2 + A, z), new PointD(x + A, y + (D - A)/2 + A, z-C)),
                                    new Line(new PointD(x + A, y + (D - A)/2 + A, z-C), new PointD(x + A+(B-2*A), y + (D - A)/2 + A, z-C)),
                                    new Line(new PointD(x + A+(B-2*A), y + (D - A)/2 + A, z-C), new PointD(x + A+(B-2*A), y + (D - A)/2 + A, z)),
                                    new Line(new PointD(x + A+(B-2*A), y + (D - A)/2 + A, z), new PointD(x + A, y + (D - A)/2 + A, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 90,
                            zAngleCurrent = 0
                        },
                    new Face
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A, y + (D+A)/2, z), new PointD(x + A, y + (D+A)/2, z - C)),
                                    new Line(new PointD(x + A, y + (D+A)/2, z - C), new PointD(x + A, y + (D - A)/2 + (D+A)/2, z - C)),
                                    new Line(new PointD(x + A, y + (D - A)/2 + (D+A)/2, z - C), new PointD(x + A, y + (D - A)/2 + (D+A)/2, z)),
                                    new Line(new PointD(x + A, y + (D - A)/2 + (D+A)/2, z), new PointD(x + A, y + (D+A)/2, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 0,
                            zAngleCurrent = 90
                        },
                    new Face
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y + D, z), new PointD(x, y + D, z - C)),
                                    new Line(new PointD(x, y + D, z - C), new PointD(x + A, y + D, z - C)),
                                    new Line(new PointD(x + A, y + D, z - C), new PointD(x + A, y + D, z)),
                                    new Line(new PointD(x + A, y + D, z), new PointD(x, y + D, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 90,
                            zAngleCurrent = 0
                        },
                    new Face
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y, z), new PointD(x, y, z - C)),
                                    new Line(new PointD(x, y, z - C), new PointD(x, y + D, z - C)),
                                    new Line(new PointD(x, y + D, z - C), new PointD(x, y + D, z)),
                                    new Line(new PointD(x, y + D, z), new PointD(x, y, z)),
                                },
                            xAngleCurrent = 90,
                            yAngleCurrent = 0,
                            zAngleCurrent = 90
                        },
                    new Face //H back
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y, z - C), new PointD(x + A, y, z - C)),
                                    new Line(new PointD(x + A, y, z - C), new PointD(x + A, y + ((D - A)/2), z - C)),
                                    new Line(new PointD(x + A, y + ((D - A)/2), z - C),
                                             new PointD(x + A + (B - 2*A), y + ((D - A)/2), z - C)),
                                    new Line(new PointD(x + A + (B - 2*A), y + ((D - A)/2), z - C),
                                             new PointD(x + A + (B - 2*A), y, z - C)),
                                    new Line(new PointD(x + A + (B - 2*A), y, z - C),
                                             new PointD(x + A + (B - 2*A) + A, y, z - C)),
                                    new Line(new PointD(x + A + (B - 2*A) + A, y, z - C),
                                             new PointD(x + A + (B - 2*A) + A, y + D, z - C)),
                                    new Line(new PointD(x + A + (B - 2*A) + A, y + D, z - C),
                                             new PointD(x + A + (B - 2*A), y + D, z - C)),
                                    new Line(new PointD(x + A + (B - 2*A), y + D, z - C),
                                             new PointD(x + A + (B - 2*A), y + D - ((D - A)/2), z - C)),
                                    new Line(new PointD(x + A + (B - 2*A), y + D - ((D - A)/2), z - C),
                                             new PointD(x + A, y + D - ((D - A)/2), z - C)),
                                    new Line(new PointD(x + A, y + D - ((D - A)/2), z - C), new PointD(x + A, y + D, z - C)),
                                    new Line(new PointD(x + A, y + D, z - C), new PointD(x, y + D, z - C)),
                                    new Line(new PointD(x, y + D, z - C), new PointD(x, y, z - C))
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        }
                };
            foreach (Face face in faces)
            {
                face.xAngleStart = face.xAngleCurrent;
                face.yAngleStart = face.yAngleCurrent;
                face.zAngleStart = face.zAngleCurrent;
                face.IsFrontCurrent = face.IsFrontStart;
            }
        }

        public void Move(double dx, double dy, double dz)
        {
            double[] _moveArray = new[] { dx, dy, dz };
            foreach (List<Line> lines in faces.Select(x=>x.Lines))
            {
                foreach (Line line in lines)
                {
                    line.Start = new PointD(line.Start.X + _moveArray[0], line.Start.Y + _moveArray[1], line.Start.Z + _moveArray[2]);
                    line.End = new PointD(line.End.X + _moveArray[0], line.End.Y + _moveArray[1], line.End.Z + _moveArray[2]);
                }
            }
            BasePoint = faces[0].Lines[0].Start;
        }

        public void Rotate(double angle, PointD point, int byAxis)
        {
            double[][] _rotateArray = new double[][] {};
            double angleRad = Math.PI / 180 * angle; //rad's
            switch (byAxis)
            {
                case 0:
                    _rotateArray = new[]
                        {
                            new double[] {1, 0, 0, 0},
                            new[] {0, Math.Cos(angleRad), -Math.Sin(angleRad), 0},
                            new[] {0, Math.Sin(angleRad), Math.Cos(angleRad), 0},
                            new double[] {0, 0, 0, 1}
                        };
                    break;
                case 1:
                    _rotateArray = new[]
                        {
                            new[] {Math.Cos(angleRad), 0, -Math.Sin(angleRad), 0},
                            new double[] {0, 1, 0, 0},
                            new[] {Math.Sin(angleRad), 0, Math.Cos(angleRad), 0},
                            new double[] {0, 0, 0, 1}
                        };
                    break;
                case 2:
                    _rotateArray = new[]
                        {
                            new[] {Math.Cos(angleRad), -Math.Sin(angleRad), 0, 0},
                            new[] {Math.Sin(angleRad), Math.Cos(angleRad), 0, 0},
                            new double[] {0, 0, 1, 0},
                            new double[] {0, 0, 0, 1}
                        };
                    break;
            }
            foreach (Face face in faces)
            {
                List<Line> lines = face.Lines;
                foreach (Line line in lines)
                {
                    line.Start =
                        new PointD(
                            line.Start.X*_rotateArray[0][0] + line.Start.Y*_rotateArray[1][0] +
                            line.Start.Z*_rotateArray[2][0] + _rotateArray[3][0],
                            line.Start.X*_rotateArray[0][1] + line.Start.Y*_rotateArray[1][1] +
                            line.Start.Z*_rotateArray[2][1] + _rotateArray[3][1],
                            line.Start.X*_rotateArray[0][2] + line.Start.Y*_rotateArray[1][2] +
                            line.Start.Z*_rotateArray[2][2] + _rotateArray[3][2]);
                    line.End =
                        new PointD(
                            line.End.X*_rotateArray[0][0] + line.End.Y*_rotateArray[1][0] +
                            line.End.Z*_rotateArray[2][0] + _rotateArray[3][0],
                            line.End.X*_rotateArray[0][1] + line.End.Y*_rotateArray[1][1] +
                            line.End.Z*_rotateArray[2][1] + _rotateArray[3][1],
                            line.End.X*_rotateArray[0][2] + line.End.Y*_rotateArray[1][2] +
                            line.End.Z*_rotateArray[2][2] + _rotateArray[3][2]);
                }
                switch (byAxis)
                {
                    case 0:
                        face.xAngleCurrent += angle;
                        face.xAngleCurrent = AngleFix(face.xAngleCurrent);
                        if (face.yAngleStart != 0)
                        {
                            face.IsFrontCurrent = AngleFix(-face.xAngleStart + face.xAngleCurrent) >= -125 + face.xAngleStart &&
                                                  AngleFix(-face.xAngleStart + face.xAngleCurrent) <= 55 + face.xAngleStart
                                                      ? face.IsFrontStart
                                                      : !face.IsFrontStart;
                        }
                        break;
                    case 1:
                        face.yAngleCurrent += angle;
                        face.yAngleCurrent = AngleFix(face.yAngleCurrent);
                        if (face.zAngleStart != 0)
                        {
                            face.IsFrontCurrent = AngleFix(-face.yAngleStart + face.yAngleCurrent) >= -145 + face.yAngleStart &&
                                                  AngleFix(-face.yAngleStart + face.yAngleCurrent) <= 35 + face.yAngleStart
                                                      ? face.IsFrontStart
                                                      : !face.IsFrontStart;
                        }
                        break;
                    case 2:
                        face.zAngleCurrent += angle;
                        face.zAngleCurrent = AngleFix(face.zAngleCurrent);
                        if (face.xAngleStart != 0)
                        {
                            face.IsFrontCurrent = AngleFix(-face.zAngleStart + face.zAngleCurrent) >= -135 + face.zAngleStart &&
                                                  AngleFix(-face.zAngleStart + face.zAngleCurrent) <= 45 + face.zAngleStart
                                                      ? face.IsFrontStart
                                                      : !face.IsFrontStart;
                        }
                        break;
                }
            }
            //faces[0].IsFrontCurrent = (faces[0].xAngleStart + faces[0].xAngleCurrent) >= -125 &&
            //                          (faces[0].xAngleStart + faces[0].xAngleCurrent) <= 55
            //                              ? faces[0].IsFrontStart
            //                              : !faces[0].IsFrontStart;
            //faces[1].IsFrontCurrent = (AngleFix(-faces[1].xAngleStart + faces[1].xAngleCurrent)) >= -125 + faces[1].xAngleStart &&
            //                          (AngleFix(-faces[1].xAngleStart + faces[1].xAngleCurrent)) <= 55 + faces[1].xAngleStart
            //                              ? faces[1].IsFrontStart
            //                              : !faces[1].IsFrontStart;
            BasePoint = faces[0].Lines[0].Start;
        }

        private double AngleFix(double angle)
        {
            if (angle != 0 && angle % 360 == 0) angle = 0;
            while (angle > 180)
            {
                angle -= 360;
            }
            while (angle < -180)
            {
                angle += 360;
            }
            return angle;
        }

        public void Zoom(double dx, double dy, double dz, PointD point)
        {
            double[,] _zoomArray = new[,]
                {
                    {dx - 1, 0, 0},
                    {0, dy - 1, 0},
                    {0, 0, dz - 1}
                };
            foreach (List<Line> lines in faces.Select(x => x.Lines))
            {
                foreach (Line line in lines)
                {
                    line.Start = new PointD(
                        -(point.X - line.Start.X)*_zoomArray[0, 0] + line.Start.X,
                        -(point.Y - line.Start.Y)*_zoomArray[1, 1] + line.Start.Y,
                        -(point.Z - line.Start.Z) * _zoomArray[2, 2] + line.Start.Z);
                    line.End = new PointD(
                        -(point.X - line.End.X) * _zoomArray[0, 0] + line.End.X,
                        -(point.Y - line.End.Y) * _zoomArray[1, 1] + line.End.Y,
                        -(point.Z - line.End.Z) * _zoomArray[2, 2] + line.End.Z);
                }
            }
            BasePoint = faces[0].Lines[0].Start;
        }
    }

    public class PointD
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public PointD(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public class Line
    {
        public PointD Start { get; set; }
        public PointD End { get; set; }

        public Line(PointD start, PointD end)
        {
            Start = start;
            End = end;
        }
    }

    public class Face
    {
        public List<Line> Lines;

        public bool IsFrontCurrent { get; set; }
        public bool IsFrontStart { get; set; }

        public double xAngleCurrent { get; set; }
        public double yAngleCurrent { get; set; }
        public double zAngleCurrent { get; set; }

        public double xAngleStart { get; set; }
        public double yAngleStart { get; set; }
        public double zAngleStart { get; set; }
    }
}
