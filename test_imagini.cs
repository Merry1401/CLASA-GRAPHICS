using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ProiectGraphics
{
    public partial class test_imagini : Form
    {
        Graphics g;
        string s;
       

        int n1 = 0, i, x, y, nota = 1;
        int[] v = new int[100];
        int[] v1 = new int[100];

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader f = new StreamReader("C:\\Users\\Wind 10\\source\\repos\\ProiectGraphics\\bin\\Debug\\netcoreapp3.1\\TextFile4.txt"))
            {
          
                while (!f.EndOfStream)
                {
                    
                    n1++;
                    vect[n1] = new Class4();
                    string s1 = f.ReadLine();
                    string[] vs = s1.Split('/');

                    vect[n1].nume = vs[0].ToString();
                    vect[n1].imagine = vs[1].ToString();

                }
                f.Close();
            }
            //   Random r = new Random();
            for (i = 1; i <= 3; i++)
            {
                int ok = 0;

                while (ok == 0)
                {
                    x = r1.Next(1, n1);
                    if (v1[x] == 0)
                    {
                        v1[x] = 1;
                        v[i] = x;
                        ok = 1;
                    }
                }
            }



            Image i1 = Image.FromFile(vect[v[1]].imagine.ToString());
            pictureBox1.Image = i1;

            Image i2 = Image.FromFile(vect[v[2]].imagine.ToString());
            pictureBox2.Image = i2;

            Image i3 = Image.FromFile(vect[v[3]].imagine.ToString());
            pictureBox3.Image = i3;

            y = r1.Next(1, 3);

            g = this.CreateGraphics();
            String drawString = "Care este imaginea care reprezinta  " + vect[v[y]].nume.ToString();


            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Black);


            float x1 = 250.0F;
            float y1 = 250.0F;
            float width = 400.0F;
            float height = 50.0F;
            RectangleF drawRect = new RectangleF(x1, y1, width, height);


            Pen blackPen = new Pen(Color.Black);

            g.DrawString(drawString, drawFont, drawBrush, drawRect);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog1.InitialDirectory + openFileDialog1.FileName;

                string result;

                result = Path.GetFileName(s);
                using (StreamWriter fout = File.AppendText("C:\\Users\\Wind 10\\source\\repos\\ProiectGraphics\\bin\\Debug\\netcoreapp3.1\\TextFile4.txt"))
                {
                    fout.WriteLine(result + "/" + s);
                    fout.Close();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            MessageBox.Show(nota.ToString());
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = 1;
            if (v[x] == v[y])
                nota = 10;
            else
                nota = 1;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            x = 2;
            if (v[x] == v[y])
                nota = 10;
            else
                nota = 1;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            x = 3;
            if (v[x] == v[y])
                nota = 10;
            else
                nota = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        Random r1 = new Random();

        Class4[] vect = new Class4[100];

        public test_imagini()
        {
            InitializeComponent();
        }
       

    }
}
