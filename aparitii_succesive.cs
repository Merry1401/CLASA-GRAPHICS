using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class aparitii_succesive : Form
    {
        int nr = 0;
        Graphics g;
        string s1 = "OLIMPIADA";
        string s2 = "DE INOVARE SI CREATIVITATE ";
        string s3 = "DIGITALA  (INFOEDUCATIA)";
        string s4 = "TEMA proiect  CLASA GRAPHICS";
        int nr2;
        float x;
        Graphics g1;
        public aparitii_succesive()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            nr++;
            if (nr % 4 == 1)
            {
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                float x = 150.0F;
                float y = 50.0F;

                g.DrawString(s1, drawFont, drawBrush, x, y);
            }
            else if (nr % 4 == 2)
            {

                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                float x = 160.0F;
                float y = 80.0F;

                g.DrawString(s2, drawFont, drawBrush, x, y);
            }
            else
            if (nr % 4 == 3)
            {
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                float x = 170.0F;
                float y = 110.0F;

                g.DrawString(s3, drawFont, drawBrush, x, y);
            }

            else
            {
                timer1.Stop();
                nr2 = 0;
                x = 500;
                timer2.Start();
                //g.Clear(Color.White);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            g1 = this.CreateGraphics();
            if (nr2 == 60)
            {
                Thread.Sleep(2000);
                timer1.Stop();
                g1.Clear(Color.White);
            }
            else
            {
                g1.Clear(Color.White);
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                g.DrawString(s1, drawFont, drawBrush, 150, 50);
                g.DrawString(s2, drawFont, drawBrush, 160, 80);
                g.DrawString(s3, drawFont, drawBrush, 170, 110);
                nr2++;


                x = 100.0F - nr2 * 5;
                float y = 150.0F;

                g1.DrawString(s4, drawFont, drawBrush, x, y);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            desen_string f = new desen_string();
            f.Show();
        }
    }
}
