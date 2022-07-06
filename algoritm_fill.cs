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
    public partial class algoritm_fill : Form
    {
        int n = 8;
        Random r = new Random();
        int[,] a1 = new int[100, 100];
        Rectangle[,] a = new Rectangle[100, 100];
        Graphics g;
        int i, j;
        public algoritm_fill()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            int i, j;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                    a1[i, j] = r.Next(2);
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                {

                    a[i, j] = new Rectangle();
                    a[i, j].Height = 50;
                    a[i, j].Width = 50;
                    a[i, j].Location = new Point(100 + i * 56, 100 + j * 56);
                    g.DrawRectangle(p, a[i, j]);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j <= n)
            {
                if (a1[i, j] == 1) fill(i, j);
                else if (a1[i, j] != 2)
                {
                    SolidBrush s = new SolidBrush(Color.Red);
                    g.FillRectangle(s, a[i, j]);
                }

                j++;
            }
            else { i++; j = 1; }

            if (i == n && j == n + 1) { timer1.Stop(); button1.Enabled = true; }

        }

        void fill(int i, int j)
        {
            SolidBrush s = new SolidBrush(Color.Green);
            g.FillRectangle(s, a[i, j]);
            a1[i, j] = 2;
            if (a1[i - 1, j] == 1) fill(i - 1, j);
            if (a1[i, j + 1] == 1) fill(i, j + 1);
            if (a1[i + 1, j] == 1) fill(i + 1, j);
            if (a1[i, j - 1] == 1) fill(i, j - 1);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
            j = 1;
            timer1.Start();
        }
    }
}
