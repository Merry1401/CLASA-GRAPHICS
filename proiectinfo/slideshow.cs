using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace proiectinfo
{
    public partial class slideshow : Form
    {
        PointF[] v2 = new PointF[100];
        Class3[] v = new Class3[100];
        int k = 0, i = 0, n, m;

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader fin = new StreamReader("C:\\Users\\Wind 10\\source\\repos\\proiectinfo\\bin\\Debug\\netcoreapp3.1\\textslide.txt"))
            {
                while (!fin.EndOfStream)
                {
                    i++;
                    string s = fin.ReadLine();
                    string[] v = s.Split(' ');
                    v2[i] = new PointF(int.Parse(v[0].ToString()), int.Parse(v[1].ToString()));
                }
                fin.Close(); m = i;
            }

            using (StreamReader fin = new StreamReader("C:\\Users\\Wind 10\\source\\repos\\proiectinfo\\bin\\Debug\\netcoreapp3.1\\slide.txt"))
            {
                while (!fin.EndOfStream)
                {

                    string linie = fin.ReadLine();
                    string[] v1 = linie.Split('/');
                    v[k] = new Class3();
                    v[k].denumire = v1[0].ToString();
                    v[k].regiune = v1[1].ToString();
                    v[k].poza = v1[2].ToString(); k++;

                }
                n = k;
                fin.Close();
            }
            k = 1; timer1.Start(); i = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cod_slideshow f = new cod_slideshow();
            f.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkViolet;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkOrchid;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrchid;
        }

        Graphics g;
        public slideshow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            g = this.CreateGraphics(); g.Clear(Color.White);

            String drawString = v[i % n].denumire.ToString();

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            float x = 400.0F;
            float y = 70.0F;

            g.DrawString(drawString, drawFont, drawBrush, x, y);



            String drawString2 = v[i % n].regiune.ToString();

            Font drawFont2 = new Font("Arial", 16);
            SolidBrush drawBrush2 = new SolidBrush(Color.Blue);

            float x2 = 400.0F;
            float y2 = 150.0F;

            g.DrawString(drawString2, drawFont2, drawBrush2, x2, y2);

            Image newImage = Image.FromFile(v[i % n].poza.ToString());
             Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            //SolidBrush s = new SolidBrush(Color.Red);
            //g.FillPolygon(s, v2);
              g.FillPolygon(tb, v2);
        }
    }
}
