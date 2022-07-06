using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class Form1 : Form
    {
        int[,] a1 = new int[10, 10];
        Rectangle[,] a = new Rectangle[10, 10];
        int[] vf = new int[22];
        int[] v = new int[17];
        int nr = 0;
        Color[] c = new Color[10];
        Random r = new Random();
        int[,] ok = new int[100, 100];
        Graphics g;
        int l;
        public Form1()
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
            int i, j;


            for (i = 0; i < 6; i++)
                for (j = 0; j < 6; j++)
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int i1, j1;
            g = this.CreateGraphics();
            SolidBrush s2 = new SolidBrush(Color.Green);
            SolidBrush s3 = new SolidBrush(Color.Orange);
            i1 = (e.X - 100) / 41;
            j1 = (e.Y - 100) / 41;
            if (i1 >= 0 && i1 < 6 && j1 >= 0 && j1 < 6)
            {
                nr++;
                if (nr % 2 == 0)
                {

                    if (a1[i1, j1] == 0)
                    {
                        a1[i1, j1] = 1;
                        g.FillRectangle(s3, a[i1, j1]);
                        String drawString = "x";

                        Font drawFont = new Font("Arial", 11);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        PointF drawPoint = new PointF(100 + i1 * 41 + 10, 100 + j1 * 41 + 10);

                        g.DrawString(drawString, drawFont, drawBrush, drawPoint);
                    }
                    else
                        nr--;
                }
                else
                {
                    if (a1[i1, j1] == 0)
                    {
                        g.FillRectangle(s2, a[i1, j1]);
                        String drawString = "o";

                        Font drawFont = new Font("Arial", 11);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        PointF drawPoint = new PointF(100 + i1 * 41 + 10, 100 + j1 * 41 + 10);

                        g.DrawString(drawString, drawFont, drawBrush, drawPoint);
                        a1[i1, j1] = 2;
                    }
                    else
                        nr--;
                }
            }

            int i, j;

            for (i = 0; i < 6; i++)
            {
                l = 0;
                //  int nrx = 0, nro = 0;
                for (j = 0; j < 6; j++)

                    if (a1[i, j] == 1) { l++; }
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat X!");
                        l = 0;

                    }
            }

            for (i = 0; i < 6; i++)
            {
                l = 0;
                for (j = 0; j < 6; j++)

                    if (a1[i, j] == 2) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat 0!");
                        l = 0;

                    }

            }
            for (j = 0; j < 6; j++)

            {
                l = 0;
                //  int nrx = 0, nro = 0;
                for (i = 0; i < 6; i++)

                    if (a1[i, j] == 1) { l++; }
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat X!");
                        l = 0;

                    }
            }

            for (j = 0; j < 6; j++)

            {
                l = 0;
                for (i = 0; i < 6; i++)
                {

                    if (a1[i, j] == 2) l++;
                    else
                    {
                        if (l >= 4) MessageBox.Show("A castigat 0!");
                        l = 0;

                    }
                }
            }
            // deasupra princ

            for (i = 0; i < 6; i++)
            {
                l = 0;

                for (j = 0; j <= i; j++)

                    if (a1[j, 6 - i + j] == 1) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat X!");
                        l = 0;

                    }
            }
            for (i = 0; i < 6; i++)
            {
                l = 0;
                for (j = 0; j <= i; j++)

                    if (a1[j, 6 - i + j] == 2) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat 0!");
                        l = 0;

                    }

            }
            //sub prin

            for (i = 0; i < 6; i++)
            {
                l = 0;

                for (j = 0; j <= i; j++)

                    if (a1[6 - i + j, j] == 1) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat X!");
                        l = 0;

                    }
            }

            for (i = 0; i < 6; i++)
            {
                l = 0;
                for (j = 0; j <= i; j++)

                    if (a1[6 - i + j, j] == 2) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat 0!");
                        l = 0;

                    }

            }



            // secundare
            for (i = 0; i < 6; i++)
            {
                l = 0;

                for (j = 0; j <= i; j++)

                    if (a1[i - j, j] == 1) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat X!");
                        l = 0;

                    }

            }

            for (i = 0; i < 6; i++)
            {
                l = 0;
                for (j = 0; j <= i; j++)

                    if (a1[i - j, j] == 2) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat 0!");
                        l = 0;

                    }

            }


            for (i = 0; i < 6; i++)
            {
                l = 0;

                for (j = 0; j <= i; j++)

                    if (a1[6 - j, 6 - i + j] == 1) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat X!");
                        l = 0;

                    }
            }

            for (i = 0; i < 6; i++)
            {
                for (j = 0; j <= i; j++)

                    if (a1[6 - j, 6 - i + j] == 2) l++;
                    else
                    {

                        if (l >= 4) MessageBox.Show("A castigat 0!");
                        l = 0;

                    }

            }
        }
    }
}
