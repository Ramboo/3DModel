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
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //Draw.DrawAxis(bmp);
            Draw.DrawObject(bmp, model);

            pictureBox1.Image = bmp;
        }

        private Timer timer = new Timer();

        private BaseModel model;
        private Bitmap bmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text), int.Parse(txtBoxD.Text));
        }

        private void InitModel(int a, int b, int c, int d)
        {
            model = new BaseModel(0 - b/2, 0 - d/2, 0 + c/2, a, b, c, d);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            model.Move((int) numUDdx.Value, (int) -numUDdy.Value, (int) -numUDdz.Value);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            model.Rotate((double) numUDdanglea.Value, (double)numUDdangleb.Value, (double)numUDdangleg.Value, new PointD(bmp.Width/2, bmp.Height/2, 0));
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            model.Zoom((double) numUDzx.Value, (double) numUDzy.Value, (double) numUDzz.Value, new PointD(0, 0, 0));
        }

        private void btnInitModel_Click(object sender, EventArgs e)
        {
            InitModel(int.Parse(txtBoxA.Text), int.Parse(txtBoxB.Text), int.Parse(txtBoxC.Text), int.Parse(txtBoxD.Text));
        }
    }
}