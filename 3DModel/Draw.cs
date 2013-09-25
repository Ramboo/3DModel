using System;
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
                    //if (!face.IsFrontCurrent) continue;
                    foreach (Line line in face.Lines)
                    {
                        Point start = new Point(
                            (int) (line.Start.X + bmp.Width/2),
                            (int) (line.Start.Y + bmp.Height/2));
                        Point end = new Point(
                            (int) (line.End.X + bmp.Width/2),
                            (int) (line.End.Y + bmp.Height/2));
                        g.DrawLine(pen, start, end);
                    }
                }
            }
        }
    }
}
