using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3DModel
{
    public partial class Form1 : Form
    {
        public const int zAngle = 45;
        public const double zAngleRad = zAngle * Math.PI / 180;

        public Form1()
        {
            InitializeComponent();

            cmbBoxAxis.SelectedIndex = 0;

            timer.Interval = 10;
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Draw.DrawAxis(bmp);
            Draw.DrawObject(bmp, model);

            label4.Text = (model.BasePoint.X).ToString();
            label3.Text = (-model.BasePoint.Y).ToString();
            label8.Text = (model.BasePoint.Z).ToString();

            pictureBox1.Image = bmp;
        }

        private Timer timer = new Timer();

        private BaseModel model;
        private Bitmap bmp;

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            InitModel(0, 0, 0);
        }

        private void InitModel(int x, int y,int z)
        {
            model = new BaseModel(x, y, z, 50, 200, 50, 300);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            model.Move((int) numUDdx.Value, (int) - numUDdy.Value, (int) numUDdz.Value);
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            model.Rotate((double) numUDdangle.Value,new PointD(bmp.Width/2,bmp.Height/2,0), cmbBoxAxis.SelectedIndex);
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            model.Zoom((double) numUDzx.Value, (double) numUDzy.Value, (double) numUDzz.Value, new PointD(0, 0,0));
        }
    }
}