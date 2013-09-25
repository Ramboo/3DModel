﻿using System;
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

        public BaseModel(double x, double y, double z, double a, double b, double c, double d)
        {
            BasePoint = new PointD(x, y, z);
            A = a;
            B = b;
            C = c;
            D = d;

            faces = new List<Face>
                {
                    new Face // H left part
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y, z), new PointD(x + A, y, z)),
                                    new Line(new PointD(x + A, y, z), new PointD(x + A, y + D, z)),
                                    new Line(new PointD(x + A, y + D, z), new PointD(x, y + D, z)),
                                    new Line(new PointD(x, y + D, z), new PointD(x, y, z)),
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        },
                    new Face // H center part
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A, y + ((D - A)/2), z), new PointD(x + A + (B - 2*A), y + ((D - A)/2), z)),
                                    new Line(new PointD(x + A + (B - 2*A), y + ((D - A)/2), z), new PointD(x + A + (B - 2*A), y + ((D - A)/2) + A, z)),
                                    new Line(new PointD(x + A + (B - 2*A), y + ((D - A)/2) + A, z), new PointD(x + A, y + ((D - A)/2) + A, z)),
                                    new Line(new PointD(x + A, y + ((D - A)/2) + A, z), new PointD(x + A, y + ((D - A)/2), z)),
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        },
                    new Face // H right part
                        {
                            IsFrontStart = true,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + B - A, y, z), new PointD(x + B, y, z)),
                                    new Line(new PointD(x + B, y, z), new PointD(x + B, y + D, z)),
                                    new Line(new PointD(x + B, y + D, z), new PointD(x + B - A, y + D, z)),
                                    new Line(new PointD(x + B - A, y + D, z), new PointD(x + B - A, y, z)),
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
                    new Face // H left part
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x, y, z - C), new PointD(x + A, y, z - C)),
                                    new Line(new PointD(x + A, y, z - C), new PointD(x + A, y + D, z - C)),
                                    new Line(new PointD(x + A, y + D, z - C), new PointD(x, y + D, z - C)),
                                    new Line(new PointD(x, y + D, z - C), new PointD(x, y, z - C)),
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        },
                    new Face // H center part
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + A, y + ((D - A)/2), z - C), new PointD(x + A + (B - 2*A), y + ((D - A)/2), z - C)),
                                    new Line(new PointD(x + A + (B - 2*A), y + ((D - A)/2), z - C), new PointD(x + A + (B - 2*A), y + ((D - A)/2) + A, z - C)),
                                    new Line(new PointD(x + A + (B - 2*A), y + ((D - A)/2) + A, z - C), new PointD(x + A, y + ((D - A)/2) + A, z - C)),
                                    new Line(new PointD(x + A, y + ((D - A)/2) + A, z - C), new PointD(x + A, y + ((D - A)/2), z - C)),
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        },
                    new Face // H right part
                        {
                            IsFrontStart = false,
                            Lines = new List<Line>
                                {
                                    new Line(new PointD(x + B - A, y, z - C), new PointD(x + B, y, z - C)),
                                    new Line(new PointD(x + B, y, z - C), new PointD(x + B, y + D, z - C)),
                                    new Line(new PointD(x + B, y + D, z - C), new PointD(x + B - A, y + D, z - C)),
                                    new Line(new PointD(x + B - A, y + D, z - C), new PointD(x + B - A, y, z - C)),
                                },
                            xAngleCurrent = 0,
                            yAngleCurrent = 90,
                            zAngleCurrent = 90
                        },
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

        public void Rotate(double alpha, double beta, double gamma, PointD point)
        {
            double alphaRad = Math.PI/180*alpha; //rad's
            double betaRad = Math.PI/180*beta; //rad's
            double gammaRad = Math.PI/180*gamma; //rad's
            double[][] _rotateArrayAlpha = new[]
                {
                    new double[] {1, 0, 0, 0},
                    new[] {0, Math.Cos(alphaRad), -Math.Sin(alphaRad), 0},
                    new[] {0, Math.Sin(alphaRad), Math.Cos(alphaRad), 0},
                    new double[] {0, 0, 0, 1}
                };
            double[][] _rotateArrayBeta = new[]
                {
                    new[] {Math.Cos(betaRad), 0, -Math.Sin(betaRad), 0},
                    new double[] {0, 1, 0, 0},
                    new[] {Math.Sin(betaRad), 0, Math.Cos(betaRad), 0},
                    new double[] {0, 0, 0, 1}
                };
            double[][] _rotateArrayGamma = new[]
                {
                    new[] {Math.Cos(gammaRad), -Math.Sin(gammaRad), 0, 0},
                    new[] {Math.Sin(gammaRad), Math.Cos(gammaRad), 0, 0},
                    new double[] {0, 0, 1, 0},
                    new double[] {0, 0, 0, 1}
                };
            foreach (Face face in faces)
            {
                List<Line> lines = face.Lines;
                foreach (Line line in lines)
                {
                    line.Start =
                        new PointD(
                            line.Start.X * _rotateArrayAlpha[0][0] + line.Start.Y * _rotateArrayAlpha[1][0] +
                            line.Start.Z * _rotateArrayAlpha[2][0] + _rotateArrayAlpha[3][0],
                            line.Start.X * _rotateArrayAlpha[0][1] + line.Start.Y * _rotateArrayAlpha[1][1] +
                            line.Start.Z * _rotateArrayAlpha[2][1] + _rotateArrayAlpha[3][1],
                            line.Start.X * _rotateArrayAlpha[0][2] + line.Start.Y * _rotateArrayAlpha[1][2] +
                            line.Start.Z * _rotateArrayAlpha[2][2] + _rotateArrayAlpha[3][2]);
                    line.End =
                        new PointD(
                            line.End.X * _rotateArrayAlpha[0][0] + line.End.Y * _rotateArrayAlpha[1][0] +
                            line.End.Z * _rotateArrayAlpha[2][0] + _rotateArrayAlpha[3][0],
                            line.End.X * _rotateArrayAlpha[0][1] + line.End.Y * _rotateArrayAlpha[1][1] +
                            line.End.Z * _rotateArrayAlpha[2][1] + _rotateArrayAlpha[3][1],
                            line.End.X * _rotateArrayAlpha[0][2] + line.End.Y * _rotateArrayAlpha[1][2] +
                            line.End.Z * _rotateArrayAlpha[2][2] + _rotateArrayAlpha[3][2]);
                    line.Start =
                        new PointD(
                            line.Start.X * _rotateArrayBeta[0][0] + line.Start.Y * _rotateArrayBeta[1][0] +
                            line.Start.Z * _rotateArrayBeta[2][0] + _rotateArrayBeta[3][0],
                            line.Start.X * _rotateArrayBeta[0][1] + line.Start.Y * _rotateArrayBeta[1][1] +
                            line.Start.Z * _rotateArrayBeta[2][1] + _rotateArrayBeta[3][1],
                            line.Start.X * _rotateArrayBeta[0][2] + line.Start.Y * _rotateArrayBeta[1][2] +
                            line.Start.Z * _rotateArrayBeta[2][2] + _rotateArrayBeta[3][2]);
                    line.End =
                        new PointD(
                            line.End.X * _rotateArrayBeta[0][0] + line.End.Y * _rotateArrayBeta[1][0] +
                            line.End.Z * _rotateArrayBeta[2][0] + _rotateArrayBeta[3][0],
                            line.End.X * _rotateArrayBeta[0][1] + line.End.Y * _rotateArrayBeta[1][1] +
                            line.End.Z * _rotateArrayBeta[2][1] + _rotateArrayBeta[3][1],
                            line.End.X * _rotateArrayBeta[0][2] + line.End.Y * _rotateArrayBeta[1][2] +
                            line.End.Z * _rotateArrayBeta[2][2] + _rotateArrayBeta[3][2]);
                    line.Start =
                        new PointD(
                            line.Start.X * _rotateArrayGamma[0][0] + line.Start.Y * _rotateArrayGamma[1][0] +
                            line.Start.Z * _rotateArrayGamma[2][0] + _rotateArrayGamma[3][0],
                            line.Start.X * _rotateArrayGamma[0][1] + line.Start.Y * _rotateArrayGamma[1][1] +
                            line.Start.Z * _rotateArrayGamma[2][1] + _rotateArrayGamma[3][1],
                            line.Start.X * _rotateArrayGamma[0][2] + line.Start.Y * _rotateArrayGamma[1][2] +
                            line.Start.Z * _rotateArrayGamma[2][2] + _rotateArrayGamma[3][2]);
                    line.End =
                        new PointD(
                            line.End.X * _rotateArrayGamma[0][0] + line.End.Y * _rotateArrayGamma[1][0] +
                            line.End.Z * _rotateArrayGamma[2][0] + _rotateArrayGamma[3][0],
                            line.End.X * _rotateArrayGamma[0][1] + line.End.Y * _rotateArrayGamma[1][1] +
                            line.End.Z * _rotateArrayGamma[2][1] + _rotateArrayGamma[3][1],
                            line.End.X * _rotateArrayGamma[0][2] + line.End.Y * _rotateArrayGamma[1][2] +
                            line.End.Z * _rotateArrayGamma[2][2] + _rotateArrayGamma[3][2]);
                }
                //switch (byAxis)
                //{
                //    case 0:
                //        face.xAngleCurrent += angle;
                //        face.xAngleCurrent = AngleFix(face.xAngleCurrent);
                //        if (face.yAngleStart != 0)
                //        {
                //            face.IsFrontCurrent = AngleFix(-face.xAngleStart + face.xAngleCurrent) >= -125 + face.xAngleStart &&
                //                                  AngleFix(-face.xAngleStart + face.xAngleCurrent) <= 55 + face.xAngleStart
                //                                      ? face.IsFrontStart
                //                                      : !face.IsFrontStart;
                //        }
                //        break;
                //    case 1:
                //        face.yAngleCurrent += angle;
                //        face.yAngleCurrent = AngleFix(face.yAngleCurrent);
                //        if (face.zAngleStart != 0)
                //        {
                //            face.IsFrontCurrent = AngleFix(-face.yAngleStart + face.yAngleCurrent) >= -145 + face.yAngleStart &&
                //                                  AngleFix(-face.yAngleStart + face.yAngleCurrent) <= 35 + face.yAngleStart
                //                                      ? face.IsFrontStart
                //                                      : !face.IsFrontStart;
                //        }
                //        break;
                //    case 2:
                //        face.zAngleCurrent += angle;
                //        face.zAngleCurrent = AngleFix(face.zAngleCurrent);
                //        if (face.xAngleStart != 0)
                //        {
                //            face.IsFrontCurrent = AngleFix(-face.zAngleStart + face.zAngleCurrent) >= -135 + face.zAngleStart &&
                //                                  AngleFix(-face.zAngleStart + face.zAngleCurrent) <= 45 + face.zAngleStart
                //                                      ? face.IsFrontStart
                //                                      : !face.IsFrontStart;
                //        }
                //        break;
                //}
            }
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
