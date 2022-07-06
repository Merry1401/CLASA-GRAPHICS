using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class matrice : Form
    {
        Rectangle[,] a = new Rectangle[100, 100];
        Graphics g;
        Class2[] v = new Class2[100];
        int nr = 0, k = 0;
        SolidBrush s = new SolidBrush(Color.Red);
        int nr1 = 1;
        public matrice()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nr1 == nr)
            {
                timer1.Stop();

            }
            g.FillRectangle(s, a[v[nr1].y, v[nr1].x]);
            nr1++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)

                {
                    a[i, j] = new Rectangle();
                    a[i, j].Height = 50;
                    a[i, j].Width = 50;
                    a[i, j].Location = new Point(100 + i * 56, 100 + j * 56);
                    g.DrawRectangle(p, a[i, j]);
                }

            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                {
                    if (i > j)
                    {
                        nr++;
                        v[nr] = new Class2();
                        v[nr].x = i;
                        v[nr].y = j;
                    }
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(234, 119, 76);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(234, 119, 76);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
