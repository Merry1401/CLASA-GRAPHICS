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
    public partial class grafice_mate : Form
    {

        public grafice_mate()
        {
            InitializeComponent();
        }
        //functie polinomiala frad 3
        /*  private float pol(float x)
          {//X^3-2X^2-X+2
              return x * x * x - 2 * x * x - x + 2;
          }


          private float pol(float x)
          {
             // return float.Parse(Math.Log(
          }*/
        private float d1(float x)
        {//derivata 1
            return float.Parse(textBox3.Text) * x * x + float.Parse(textBox4.Text) * 4 * x + float.Parse(textBox5.Text);
        }

        private float d2(float x)
        {//derivata 2
         //  return int.Parse(textBox1.Text.Trim()) * x +int.Parse(textBox2.Text.Trim());
            return float.Parse(textBox1.Text) * x + float.Parse(textBox2.Text);


            // return 3 * x - 6;
        }

        private float radical(float x)
        {//derivata 2
            //return  (float) Math.Pow(x,(float)0.5);
            return (float)Math.Sqrt((float)x);
        }

        private float exponentiala(float x)
        {//derivata 2
            //return  (float) Math.Pow(x,(float)0.5);
            return (float)Math.Exp((float)x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(Color.White);
            int x = pictureBox1.Width / 2;
            int y = pictureBox1.Height / 2;
            //grid
            Pen pg = new Pen(Color.LightGray);
            for (int i = -50; i <= 50; i++)
                G.DrawLine(pg, x - 30 * i, 0, x - 30 * i, pictureBox1.Height);
            for (int j = -50; j <= 50; j++)
                G.DrawLine(pg, 0, y - 30 * j, pictureBox1.Width, y - 30 * j);
            //axele
            Pen pn = new Pen(Color.Black);
            G.DrawLine(pn, 0, y, pictureBox1.Width, y);
            G.DrawLine(pn, x, 0, x, pictureBox1.Height);
            //graficul polinomului
            Pen pr = new Pen(Color.Red);
            /*  for (float i = -3; i <= 3; i = i + (float)0.001)
              {
                  G.DrawEllipse(pr, x + i * 30, y - 30 * pol(i), 1, 1);
              }
             */
            //graficul functiei de grad 2
            Pen pv = new Pen(Color.Green);
            for (float i = -3; i <= 3; i = i + (float)0.001)
            {
                G.DrawEllipse(pv, x + i * 30, y - 30 * d2(i), 1, 1);
            }
            // grafic functie liniara
            Pen pa = new Pen(Color.Blue);
            for (float i = -4; i <= 3; i = i + (float)0.001)
            {
                G.DrawEllipse(pa, x + i * 30, y - 30 * d2(i), 1, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics G = pictureBox2.CreateGraphics();
            G.Clear(Color.White);
            int x = pictureBox2.Width / 2;
            int y = pictureBox2.Height / 2;
            //grid
            Pen pg = new Pen(Color.LightGray);
            for (int i = -50; i <= 50; i++)
                G.DrawLine(pg, x - 30 * i, 0, x - 30 * i, pictureBox2.Height);
            for (int j = -50; j <= 50; j++)
                G.DrawLine(pg, 0, y - 30 * j, pictureBox2.Width, y - 30 * j);
            //axele
            Pen pn = new Pen(Color.Black);
            G.DrawLine(pn, 0, y, pictureBox2.Width, y);
            G.DrawLine(pn, x, 0, x, pictureBox2.Height);
            //graficul polinomului
            Pen pr = new Pen(Color.Red);
            for (float i = 0; i <= 5; i = i + (float)0.001)
            {
                G.DrawEllipse(pr, x + i * 30, y - 30 * radical(i), 1, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics G = pictureBox3.CreateGraphics();
            G.Clear(Color.White);
            int x = pictureBox3.Width / 2;
            int y = pictureBox3.Height / 2;
            //grid
            Pen pg = new Pen(Color.LightGray);
            for (int i = -50; i <= 50; i++)
                G.DrawLine(pg, x - 30 * i, 0, x - 30 * i, pictureBox3.Height);
            for (int j = -50; j <= 50; j++)
                G.DrawLine(pg, 0, y - 30 * j, pictureBox3.Width, y - 30 * j);
            //axele
            Pen pn = new Pen(Color.Black);
            G.DrawLine(pn, 0, y, pictureBox3.Width, y);
            G.DrawLine(pn, x, 0, x, pictureBox3.Height);
            //graficul polinomului
            Pen pr = new Pen(Color.Red);
            for (float i = -3; i <= 5; i = i + (float)0.001)
            {
                G.DrawEllipse(pr, x + i * 30, y - 30 * exponentiala(i), 1, 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics G = pictureBox4.CreateGraphics();
            G.Clear(Color.White);
            int x = pictureBox4.Width / 2;
            int y = pictureBox4.Height / 2;
            //grid
            Pen pg = new Pen(Color.LightGray);
            for (int i = -50; i <= 50; i++)
                G.DrawLine(pg, x - 30 * i, 0, x - 30 * i, pictureBox2.Height);
            for (int j = -50; j <= 50; j++)
                G.DrawLine(pg, 0, y - 30 * j, pictureBox4.Width, y - 30 * j);
            //axele
            Pen pn = new Pen(Color.Black);
            G.DrawLine(pn, 0, y, pictureBox2.Width, y);
            G.DrawLine(pn, x, 0, x, pictureBox4.Height);
            //graficul polinomului
            Pen pr = new Pen(Color.Red);
            for (float i = -5; i <= 5; i = i + (float)0.001)
            {
                G.DrawEllipse(pr, x + i * 30, y - 30 * d1(i), 1, 1);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
    }
}
