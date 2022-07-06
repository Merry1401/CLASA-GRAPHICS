using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class desen_soare : Form
    {
        public desen_soare()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Goldenrod;
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
            Rectangle r = new Rectangle(250, 200, 100, 100);
            g.DrawEllipse(p, r);
            g.FillEllipse(s, r);
            g.TranslateTransform(300.0F, 250.0F);

            for (int i = 1; i <= 36; i++)
            {

                g.DrawLine(p, new Point(0, 50), new Point(0, 200));
                g.RotateTransform(10.0F);
            }
        }
    }
}
