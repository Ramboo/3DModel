using System;
using System.Collections.Generic;
using System.Drawing;
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

        public List<List<PointD>> faces = new List<List<PointD>>
            {
                new List<PointD>(),
                new List<PointD>()
            };

        public BaseModel(double x, double y, double z, double a, double b, double c, double d)
        {
            BasePoint = new PointD(x, y, z);
            A = a;
            B = b;
            C = c;
            D = d;

            faces[0] = new List<PointD>
                {
                    new PointD(BasePoint.X, BasePoint.Y, BasePoint.Z),
                    new PointD(BasePoint.X + A, BasePoint.Y, BasePoint.Z),
                    new PointD(BasePoint.X + A, BasePoint.Y + ((D - A)/2), BasePoint.Z),
                    new PointD(BasePoint.X + A + (B - 2*A), BasePoint.Y + ((D - A)/2), BasePoint.Z),
                    new PointD(BasePoint.X + A + (B - 2*A), BasePoint.Y, BasePoint.Z),
                    new PointD(BasePoint.X + A + (B - 2*A) + A, BasePoint.Y, BasePoint.Z),
                    new PointD(BasePoint.X + A + (B - 2*A) + A, BasePoint.Y + D, BasePoint.Z),
                    new PointD(BasePoint.X + A + (B - 2*A) + A - A, BasePoint.Y + D, BasePoint.Z),
                    new PointD(BasePoint.X + A + (B - 2*A), BasePoint.Y + D - ((D - A)/2), BasePoint.Z),
                    new PointD(BasePoint.X + A, BasePoint.Y + D - ((D - A)/2), BasePoint.Z),
                    new PointD(BasePoint.X + A, BasePoint.Y + D, BasePoint.Z),
                    new PointD(BasePoint.X, BasePoint.Y + D, BasePoint.Z),
                    new PointD(BasePoint.X, BasePoint.Y, BasePoint.Z),
                };
            foreach (PointD p in faces[0])
            {
                PointD point = new PointD(p.X,p.Y,p.Z);
                point.Z -= C;
                faces[1].Add(point);
            }
        }

        public void Move(double dx, double dy, double dz)
        {
            double[] _moveArray = new[] { dx, dy, dz };
            foreach (List<PointD> facePoints in faces.Where(x=>x.Count>0))
            {
                for (int i = 0; i < facePoints.Count; i++)
                {
                    facePoints[i] = new PointD(facePoints[i].X + _moveArray[0], facePoints[i].Y + _moveArray[1], facePoints[i].Z + _moveArray[2]);
                }
            }
            BasePoint = faces[0][0];
        }

        public void Rotate(double angle, PointD point, int byAxis)
        {
            double[][] _rotateArray = new double[][] {};
            angle = Math.PI / 180 * angle; //rad's
            switch (byAxis)
            {
                case 0:
                    _rotateArray = new[]
                        {
                            new double[] {1, 0, 0, 0},
                            new[] {0, Math.Cos(angle), -Math.Sin(angle), 0},
                            new[] {0, Math.Sin(angle), Math.Cos(angle), 0},
                            new double[] {0, 0, 0, 1}
                        };
                    break;
                case 1:
                    _rotateArray = new[]
                        {
                            new[] {Math.Cos(angle), 0, Math.Sin(angle), 0},
                            new double[] {0, 1, 0, 0},
                            new[] {-Math.Sin(angle), 0, Math.Cos(angle), 0},
                            new double[] {0, 0, 0, 1}
                        };
                    break;
                case 2:
                    _rotateArray = new[]
                        {
                            new[] {Math.Cos(angle), -Math.Sin(angle), 0, 0},
                            new[] {Math.Sin(angle), Math.Cos(angle), 0, 0},
                            new double[] {0, 0, 1, 0},
                            new double[] {0, 0, 0, 1}
                        };
                    break;
            }
            foreach (List<PointD> facePoints in faces.Where(x => x.Count > 0))
            {
                for (int i = 0; i < facePoints.Count; i++)
                {
                    facePoints[i] =
                    new PointD(facePoints[i].X * _rotateArray[0][0] + facePoints[i].Y * _rotateArray[1][0] + facePoints[i].Z * _rotateArray[2][0] + _rotateArray[3][0],
                               facePoints[i].X * _rotateArray[0][1] + facePoints[i].Y * _rotateArray[1][1] + facePoints[i].Z * _rotateArray[2][1] + _rotateArray[3][1],
                               facePoints[i].X * _rotateArray[0][2] + facePoints[i].Y * _rotateArray[1][2] + facePoints[i].Z * _rotateArray[2][2] + _rotateArray[3][2]);
                }
            }
            BasePoint = faces[0][0];
        }

        public void Zoom(double dx, double dy, double dz, PointD point)
        {
            double[,] _zoomArray = new[,]
                {
                    {dx - 1, 0, 0},
                    {0, dy - 1, 0},
                    {0, 0, dz - 1}
                };

            foreach (List<PointD> facePoints in faces.Where(x => x.Count > 0))
            {
                for (int i = 0; i < facePoints.Count; i++)
                {
                    facePoints[i] = new PointD(
                        -(point.X - facePoints[i].X) * _zoomArray[0, 0] + facePoints[i].X,
                        -(point.Y - facePoints[i].Y) * _zoomArray[1, 1] + facePoints[i].Y,                        
                        -(point.Z - facePoints[i].Z) * _zoomArray[2, 2] + facePoints[i].Z);
                }
            }
            BasePoint = faces[0][0];
        }
    }

    internal class PointD
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
}
