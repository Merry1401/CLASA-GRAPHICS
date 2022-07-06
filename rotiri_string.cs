using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ProiectGraphics
{
    public partial class rotiri_string : Form
    {
        public rotiri_string()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush s = new SolidBrush(Color.Yellow);
            Pen p = new Pen(Color.Yellow, 2);
            Graphics g = this.CreateGraphics();
            Rectangle r = new Rectangle(150, 150, 100, 100);
            //    g.DrawEllipse(p, r);
            //    g.FillEllipse(s, r);
            g.TranslateTransform(200.0F, 200.0F);

            for (int i = 1; i <= 18; i++)
            {
                //  g=this.CreateGraphics();

                // Create string to draw.
                String drawString = "**********";

                // Create font and brush.
                Font drawFont = new Font("Arial", 12);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Create point for upper-left corner of drawing.
                float x = 0.0F;
                float y = 0.0F;

                // Draw string to screen.
                g.DrawString(drawString, drawFont, drawBrush, x, y);
                // g.DrawLine(p, new Point(0, 50), new Point(0, 200));
                g.RotateTransform(20.0F);
                //   g.Clear(Color.White);
                Thread.Sleep(100);
            }
        }
    }
}
