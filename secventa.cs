using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class secventa : Form
    {
        Rectangle[] v = new Rectangle[100];
        Graphics g;
        SolidBrush br = new SolidBrush(Color.Aqua);
        public int[] v1 = new int[17];
        public int i, j, n, p = -1, l = 0, lmax = 0, pmax = 0;

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(10, 152, 148);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Teal;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumTurquoise;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumTurquoise;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == n)
                timer1.Stop();
            else
            {
                if (v1[i] > 0)
                {
                    l++;
                    g.FillRectangle(br, v[i]);
                    String drawString = v1[i].ToString();
                    Font drawFont = new Font("Arial", 12);
                    SolidBrush drawBrush = new SolidBrush(Color.Blue);

                    // Create point for upper-left corner of drawing.
                    float x = 118 + i * 56;
                    float y = 238.0F;


                    g.DrawString(drawString, drawFont, drawBrush, x, y);
                }
                else
                {
                    if (l > lmax)
                    {
                        lmax = l;
                        pmax = p;
                    }
                    l = 0; p = i;
                }
                i++;

            }
        }

        public secventa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            string s = richTextBox1.Lines[0];
            n = int.Parse(s);
            s = richTextBox1.Lines[1];



            string[] numere = s.Split(' ');
            for (i = 0; i <= n - 1; i++)
            {
                v1[i] = int.Parse(numere[i]);

            }

            g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            for (i = 0; i <= n - 1; i++)
            {
                v[i] = new Rectangle();
                v[i].Height = 50;
                v[i].Width = 50;
                v[i].Location = new Point(100 + i * 56, 230);

                String drawString = v1[i].ToString();

                Font drawFont = new Font("Arial", 12);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                float x = 118 + i * 56;
                float y = 238.0F;


                g.DrawString(drawString, drawFont, drawBrush, x, y);


                g.DrawRectangle(p, v[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
