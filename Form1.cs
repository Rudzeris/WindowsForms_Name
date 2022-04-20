using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rudzeris_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            double x = Convert.ToDouble(pictureBox1.Width) / 230;
            double y = Convert.ToDouble(pictureBox1.Height) / 330;
            double p = (Convert.ToDouble(pictureBox1.Height + pictureBox1.Width) / 1300) * 5;

            var pen = new Pen(Color.Red, Convert.ToInt32(p));

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var pointV1 = new PointF(Convert.ToInt32(x * 10), Convert.ToInt32(y * 50));
            var pointV2 = new PointF(Convert.ToInt32(x * 10), Convert.ToInt32(y * 300));
            var pointV3 = new PointF(Convert.ToInt32(x * 10), Convert.ToInt32(y * 130));
            var pointV4 = new PointF(Convert.ToInt32(x * 50), Convert.ToInt32(y * 80));
            var pointV5 = new PointF(Convert.ToInt32(x * 50), Convert.ToInt32(y * 300));
            g.DrawLine(pen, pointV1, pointV2);
            g.DrawLine(pen, pointV1, pointV4);
            g.DrawLine(pen, pointV3, pointV4);
            g.DrawLine(pen, pointV3, pointV5);



            pointV1 = new PointF(Convert.ToInt32(x * 70), Convert.ToInt32(y * 130));
            pointV2 = new PointF(Convert.ToInt32(x * 70), Convert.ToInt32(y * 300));
            pointV3 = new PointF(Convert.ToInt32(x * 110), Convert.ToInt32(y * 130));
            pointV4 = new PointF(Convert.ToInt32(x * 110), Convert.ToInt32(y * 300));
            g.DrawLine(pen, pointV1, pointV2);
            g.DrawLine(pen, pointV3, pointV4);
            g.DrawLine(pen, pointV2, pointV4);



            pointV1 = new PointF(Convert.ToInt32(x * 130), Convert.ToInt32(y * 130));
            pointV2 = new PointF(Convert.ToInt32(x * 130), Convert.ToInt32(y * 300));
            pointV3 = new PointF(Convert.ToInt32(x * 170), Convert.ToInt32(y * 130));
            pointV4 = new PointF(Convert.ToInt32(x * 170), Convert.ToInt32(y * 300));
            g.DrawLine(pen, pointV1, pointV3);
            g.DrawLine(pen, pointV3, pointV2);
            g.DrawLine(pen, pointV2, pointV4);



            pointV1 = new PointF(Convert.ToInt32(x * 190), Convert.ToInt32(y * 90));
            pointV2 = new PointF(Convert.ToInt32(x * 190), Convert.ToInt32(y * 110));
            pointV3 = new PointF(Convert.ToInt32(x * 190), Convert.ToInt32(y * 130));
            pointV4 = new PointF(Convert.ToInt32(x * 190), Convert.ToInt32(y * 300));
            g.DrawLine(pen, pointV1, pointV2);
            g.DrawLine(pen, pointV3, pointV4);



            pointV1 = new PointF(Convert.ToInt32(x * 210), Convert.ToInt32(y * 90));
            pointV2 = new PointF(Convert.ToInt32(x * 210), Convert.ToInt32(y * 300));

            g.DrawLine(pen, pointV1, pointV2);

        }
    }
}
