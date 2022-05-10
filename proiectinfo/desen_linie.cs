using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace proiectinfo
{
    public partial class desen_linie : Form
    {
        Graphics g;
        public desen_linie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            var pen = new Pen(Color.Red, 3);
            pen.DashStyle = DashStyle.DashDotDot;
            int x1 = 100;
            int y1 = 100;
            int x2 = 400;
            int y2 = 100;
            g.DrawLine(pen, x1, y1, x2, y2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            var pen = new Pen(Color.Red, 3);
            pen.DashStyle = DashStyle.Dash;
            int x1 = 100;
            int y1 = 100;
            int x2 = 400;
            int y2 = 100;
            g.DrawLine(pen, x1, y1, x2, y2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            var pen = new Pen(Color.Red, 3);
            pen.DashStyle = DashStyle.Dot;
            int x1 = 100;
            int y1 = 100;
            int x2 = 400;
            int y2 = 100;

            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen redPen = new Pen(Brushes.Red, 6.0F);
            redPen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            redPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(redPen, 80.0F, 40.0F, 300.0F, 185.0F);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(11, 11);
            Pen p = new Pen(Color.Blue, 1);
            p.CustomEndCap = bigArrow;
            g.DrawLine(p, 60, 30, 320, 200);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen penita = new Pen(Color.Black, 3);
            PointF punct1 = new PointF(200.0F, 100.0F);
            PointF punct2 = new PointF(450.0F, 100.0F);
            g.DrawLine(penita, punct1, punct2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(225, 25, 61);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(244, 108, 118);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(225, 25, 61);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(244, 108, 118);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(225, 25, 61);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(244, 108, 118);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(225, 25, 61);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(244, 108, 118);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(225, 25, 61);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(244, 108, 118);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(225, 25, 61);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(244, 108, 118);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
    }
}
