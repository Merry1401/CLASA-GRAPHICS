using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class imperechere_culori : Form
    {
        int[,] a1 = new int[10, 10];
        Rectangle[,] a = new Rectangle[10, 10];
        int[] vf = new int[22];
        int[] v = new int[17];
        int nr1 = 0, np = 0, x1, x2, y1, y2, timp = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, x, k = 0;

            for (i = 0; i <= 16; i++) vf[i] = 0;
            int nr = 8;
            while (nr != 0)
            {
                x = r.Next(1, 9);
                if (vf[x] < 2)
                {
                    k++;
                    v[k] = x;
                    vf[x]++;
                    if (vf[x] == 2)
                        nr--;
                }
            }
            k = 0;
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {
                    k++;
                    a1[i, j] = v[k];
                }

            for (i = 1; i <= 8; i++)
                c[i] = Color.FromArgb(r.Next(2, 255), r.Next(12, 255), r.Next(2, 255));
            for (i = 0; i < 4; i++)
                for (j = 0; j < 4; j++)
                {

                    a[i, j] = new Rectangle();
                    a[i, j].Height = 40;
                    a[i, j].Width = 40;
                    a[i, j].Location = new Point(100 + i * 41, 100 + j * 41);
                    SolidBrush s = new SolidBrush(Color.Blue);
                    g = this.CreateGraphics();
                    g.FillRectangle(s, a[i, j]);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timp == 60)
            {
                timer1.Stop(); for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                    {
                        SolidBrush s5 = new SolidBrush(Color.Blue);
                        g = this.CreateGraphics();
                        g.FillRectangle(s5, a[i, j]);
                    }
                // a[i, j].BackColor = Color.Blue;
                timp = 0;
            }
            timp++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    SolidBrush s4 = new SolidBrush(c[a1[i, j]]);
                    g = this.CreateGraphics();
                    g.FillRectangle(s4, a[i, j]);

                }
            //  a[i, j].BackColor = c[a1[i, j]];
            timer1.Start();
        }

        private void imperechere_culori_MouseClick(object sender, MouseEventArgs e)
        {
            int i1, j1;

            i1 = (e.X - 100) / 41;
            j1 = (e.Y - 100) / 41;
            // if (i1 >= 0 && i1 < 4 && j1 >= 0 && j1 < 4)
            //  {
            np++;

            if (np % 2 == 0)
            {
                x1 = i1;
                y1 = j1;
                if (a1[x1, y1] == a1[x2, y2])
                {
                    SolidBrush s3 = new SolidBrush(Color.Aqua);
                    g.FillRectangle(s3, a[x1, y1]);
                    g.FillRectangle(s3, a[x2, y2]);

                    ok[x1, y1] = 1; ok[x2, y2] = 1;
                    if (bun() == 1) MessageBox.Show("Ai castigat!");

                }
            }
            else
            {
                x2 = i1;
                y2 = j1;
                if (a1[x1, y1] == a1[x2, y2] && x1 != 0)
                {

                    //  a[x1, y1].Text = b1[x1, y1].ToString();
                    //  a[x2, y2].Text = b1[x2, y2].ToString();
                    ok[x1, y1] = 1; ok[x2, y2] = 1;
                    if (bun() == 1) MessageBox.Show("Ai castigat!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        Color[] c = new Color[10];
        Random r = new Random();
        int[,] ok = new int[100, 100];
        Graphics g;
        public imperechere_culori()
        {
            InitializeComponent();
        }
        int bun()
        {
            int i1, j1, ok1 = 1;
            for (i1 = 0; i1 < 4; i1++)
                for (j1 = 0; j1 < 4; j1++)
                    if (ok[i1, j1] == 0)
                        ok1 = 0;
            return ok1;
        }
    }
}
