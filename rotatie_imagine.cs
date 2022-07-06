using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class rotatie_imagine : Form
    {
        int unghi = 0;
        SolidBrush s;
        public rotatie_imagine()
        {
            InitializeComponent();
        }

        private void rotatie_imagine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            g.TranslateTransform(300, 300);
            Rectangle rect = new Rectangle(-100, -25, 200, 50);
            g.RotateTransform(unghi);
            g.DrawRectangle(blackPen, rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 3);
            g.TranslateTransform(300, 300);
            Rectangle rect = new Rectangle(0, 0, 200, 50);
            for (int i = 1; i <= 12; i++)
            {
                g.DrawRectangle(blackPen, rect);
                g.RotateTransform(30);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            unghi = unghi + 1;
            Invalidate();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            s = new SolidBrush(Color.LightPink);
            SolidBrush s1 = new SolidBrush(Color.Orchid);
            g.TranslateTransform(300, 300);
            Rectangle rect = new Rectangle(-100, -25, 200, 50);
            Rectangle rect1 = new Rectangle(-25, -25, 50, 50);
            Rectangle rect2 = new Rectangle(-25, -100, 50, 200);
            g.RotateTransform(unghi);

            g.FillRectangle(s, rect);

            g.FillRectangle(s, rect2); g.FillEllipse(s1, rect1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.ForestGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.ForestGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LimeGreen;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.ForestGreen;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.LimeGreen;
        }
    }
}
