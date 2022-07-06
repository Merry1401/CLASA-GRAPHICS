using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProiectGraphics
{
    public partial class harta : Form
    {
        int nr = 0, n, no = 0, y, test = 0, nr_itemi;
        double nota = 1;
        Class5[] v1 = new Class5[100];
        Random r = new Random();
        int[] vf = new int[100];
        int[] v2 = new int[100];

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.Compare(comboBox1.Text, v1[v2[y]].capitala) == 0)
            { MessageBox.Show("Raspuns corect!"); nota += (double)9 / nr_itemi; }
            else
                MessageBox.Show("Raspuns gresit!");
            this.Invalidate();
        }

        private void harta_Load(object sender, EventArgs e)
        {
            
            this.BackgroundImage = Image.FromFile("harta.jpeg");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        Graphics g;
        public harta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader fin = new StreamReader("TextFile1.txt"))
            {
                while (!fin.EndOfStream)
                {
                    nr++;

                    string linie = fin.ReadLine();
                    string[] v = linie.Split(' ');

                    v1[nr] = new Class5();
                    v1[nr].x = int.Parse(v[0].ToString());
                    v1[nr].y = int.Parse(v[1].ToString());
                    v1[nr].capitala = v[2].ToString();
                    v1[nr].nr1 = nr;
                }
                fin.Close();
            }
            n = nr;
            nr_itemi = int.Parse(listBox1.Text);
            MessageBox.Show(nr_itemi.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            test++;
            if (test <= nr_itemi)
            {
                no = 1;
                for (int i = 1; i <= 5; i++)
                {
                    int ok = 0;

                    while (ok == 0)
                    {
                        int x = r.Next(1, n);
                        if (vf[x] == 0)
                        {
                            vf[x] = 1;
                            v2[i] = x;
                            ok = 1;
                        }
                    }
                }
                y = r.Next(1, 6);
                label1.Text = " Ce capitala se gaseste la numarul " + y.ToString();
                for (int i = 1; i <= 5; i++)
                {


                    no = 1;
                    if (i <= 5)
                    {
                        g = this.CreateGraphics();
                        String drawString = i.ToString();
                        Font drawFont = new Font("Arial", 12);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        PointF drawPoint = new PointF(int.Parse(v1[v2[i]].x.ToString()) - 5, int.Parse(v1[v2[i]].y.ToString()) + 10);
                        g.DrawString(drawString, drawFont, drawBrush, drawPoint);
                    }

                }
            }
            else MessageBox.Show(nota.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
