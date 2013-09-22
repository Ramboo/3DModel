﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _3DModel
{
    class Draw
    {
        static Pen pen = new Pen(Color.Black, 1);

        public static void DrawAxis(Bitmap bmp)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawLine(pen, 0, bmp.Height/2, bmp.Width, bmp.Height/2); //x
                g.DrawLine(pen, bmp.Width/2, 0, bmp.Width/2, bmp.Height); //y
                g.DrawLine(pen, 0,bmp.Height,bmp.Width,0); //z
                g.DrawString("X", new Font(FontFamily.Families[10], 15, FontStyle.Regular), Brushes.Black, bmp.Width - 20, bmp.Height / 2);
                g.DrawString("Y", new Font(FontFamily.Families[10], 15, FontStyle.Regular), Brushes.Black, bmp.Width / 2 + 5, 5);
                g.DrawString("Z", new Font(FontFamily.Families[10], 15, FontStyle.Regular), Brushes.Black, bmp.Width - 20, 20);
            }
        }

        public static void DrawObject(Bitmap bmp, BaseModel baseObj)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Face face in baseObj.faces)
                {
                    foreach (Line line in face.Lines)
                    {
                        PointD pFace1 = line.Start;
                        PointD pFace1Next = line.End;
                        g.DrawLine(pen,
                                   new Point(
                                       (int)
                                       (pFace1.X + bmp.Width/2 +
                                        Math.Cos(Form1.zAngleRad)*(baseObj.BasePoint.Z - pFace1.Z) +
                                        Math.Cos(Form1.zAngleRad)*baseObj.BasePoint.Z),
                                       (int)
                                       (pFace1.Y + bmp.Height/2 -
                                        Math.Sin(Form1.zAngleRad)*(baseObj.BasePoint.Z - pFace1.Z) -
                                        Math.Sin(Form1.zAngleRad)*baseObj.BasePoint.Z)),
                                   new Point(
                                       (int)
                                       (pFace1Next.X + bmp.Width/2 +
                                        Math.Cos(Form1.zAngleRad)*(baseObj.BasePoint.Z - pFace1Next.Z) +
                                        Math.Cos(Form1.zAngleRad)*baseObj.BasePoint.Z),
                                       (int)
                                       (pFace1Next.Y + bmp.Height/2 -
                                        Math.Sin(Form1.zAngleRad)*(baseObj.BasePoint.Z - pFace1Next.Z) -
                                        Math.Sin(Form1.zAngleRad)*baseObj.BasePoint.Z)));
                        //if (k!=1)
                        //{
                        //    PointD pFace2 = baseObj.faces[k][i];
                        //    PointD pNextFace2 = baseObj.faces[k + 1][i];
                        //    double cos = Math.Cos(Form1.zAngleRad);
                        //    double sin = Math.Sin(Form1.zAngleRad);
                        //    g.DrawLine(pen,
                        //               new Point(
                        //                   (int)
                        //                   (pFace2.X + bmp.Width/2 + cos*(baseObj.BasePoint.Z - pFace2.Z) +
                        //                    cos * baseObj.BasePoint.Z),
                        //                   (int)
                        //                   (pFace2.Y + bmp.Height/2 - sin*(baseObj.BasePoint.Z - pFace2.Z) -
                        //                    sin * baseObj.BasePoint.Z)),
                        //               new Point(
                        //                   (int)
                        //                   (pNextFace2.X + bmp.Width / 2 + cos * (baseObj.BasePoint.Z - pNextFace2.Z) +
                        //                    cos * baseObj.BasePoint.Z),
                        //                   (int)
                        //                   (pNextFace2.Y + bmp.Height / 2 - sin * (baseObj.BasePoint.Z - pNextFace2.Z) -
                        //                    sin * baseObj.BasePoint.Z)));
                        //}

                        //new Point((int)(p.X+bmp.Width/2), (int)(p.Y+bmp.Height/2)),
                        //new Point((int)(pNext.X+bmp.Width/2), (int)(pNext.Y+bmp.Height/2)));
                    }
                }
            }
        }
    }
}
