using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3DModel
{
    public partial class Form1 : Form
    {
        public const int zAngle = 45;
        public const double zAngleRad = zAngle*Math.PI/180;

        public Form1()
        {
            InitializeComponent();

            timer.Interval = 10;
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            bmpFront = new Bitmap(picFront.Width, picFront.Height);
            bmpHoriz = new Bitmap(picHoriz.Width, picHoriz.Height);
            bmpProf = new Bitmap(picProf.Width, picProf.Height);
            bmpOther = new Bitmap(picOther.Width, picOther.Height);

            Draw.DrawObjectFront(bmpFront, model);
            Draw.DrawObjectHoriz(bmpHoriz, model);
            Draw.DrawObjectProf(bmpProf, model);
            if (rBtnAkson.Checked)
            {
                Draw.DrawObjectAkson(bmpOther, model, (double) numUDAksondx.Value, (double) numUDAksondy.Value);
            }
            if (rBtnKos.Checked && numUDKosougA.Value%90 != 0 && numUDKosougA.Value != 0)
            {
                Draw.DrawObjectKosoug(bmpOther, model, (double) numUDKosougL.Value, (double) numUDKosougA.Value);
            }
            if (rBtnPerspekt.Checked)
            {
                Draw.DrawObjectPerspekt(bmpOther, model,
                                        (double) numUDPerspektD.Value,
                                        (double) numUDPerspSigma.Value,
                                        (double) numUDPerspFi.Value);
            }
            picFront.Image = bmpFront;
            picHoriz.Image = bmpHoriz;
            picProf.Image = bmpProf;
            picOther.Image = bmpOther;
        }

        private Timer timer = new Timer();

        private BaseModel model;
        private BaseModel startModel;

        private Bitmap bmpFront, bmpHoriz, bmpProf, bmpOther;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmpFront = new Bitmap(picFront.Width, picFront.Height);
            InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text), int.Parse(txtBoxD.Text));
        }

        private void InitModel(int a, int b, int c, int d)
        {
            startModel = new BaseModel(0 - b/2, 0 - d/2, 0 + c/2, a, b, c, d);
            model = new BaseModel(0 - b/2, 0 - d/2, 0 + c/2, a, b, c, d);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            model.Move((int) numUDdx.Value, (int) -numUDdy.Value, (int) -numUDdz.Value);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            model.Rotate((double) numUDdanglea.Value, (double) numUDdangleb.Value, (double) numUDdangleg.Value,
                         new PointD(bmpFront.Width/2, bmpFront.Height/2, 0));
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            model.Zoom((double) numUDzx.Value, (double) numUDzy.Value, (double) numUDzz.Value, new PointD(0, 0, 0));
        }

        private void scrollA_Scroll(object sender, ScrollEventArgs e)
        {
            txtBoxA.Text = scrollA.Value.ToString();
        }

        private void scrollB_Scroll(object sender, ScrollEventArgs e)
        {
            txtBoxB.Text = scrollB.Value.ToString();
        }

        private void scrollC_Scroll(object sender, ScrollEventArgs e)
        {
            txtBoxC.Text = scrollC.Value.ToString();
        }

        private void scrollD_Scroll(object sender, ScrollEventArgs e)
        {
            txtBoxD.Text = scrollD.Value.ToString();
        }

        private void txtBoxA_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxA.Text))
            {
                try
                {
                    scrollA.Value = int.Parse(txtBoxA.Text);
                    InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text),
                              int.Parse(txtBoxD.Text));
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение");
                }
            }
        }

        private void txtBoxB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxB.Text))
            {
                try
                {
                    scrollB.Value = int.Parse(txtBoxA.Text);
                    InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text),
                              int.Parse(txtBoxD.Text));
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение");
                }
            }
        }

        private void txtBoxC_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxC.Text))
            {
                try
                {
                    scrollC.Value = int.Parse(txtBoxA.Text);
                    InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text),
                              int.Parse(txtBoxD.Text));
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение");
                }
            }
        }

        private void txtBoxD_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxD.Text))
            {
                try
                {
                    scrollD.Value = int.Parse(txtBoxA.Text);
                    InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text),
                              int.Parse(txtBoxD.Text));
                }
                catch
                {
                    MessageBox.Show("Недопустимое значение");
                }
            }
        }

        private void numUDKosougA_ValueChanged(object sender, EventArgs e)
        {
            if (numUDKosougA.Value >= 360)
            {
                numUDKosougA.Value = -359;
            }
            if (numUDKosougA.Value <= -360)
            {
                numUDKosougA.Value = 359;
            }
        }
    }
}