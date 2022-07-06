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
    public partial class anim_matrice : Form
    {
        Graphics g;
        Bitmap[,] bmps = new Bitmap[1000, 1000];
        Bitmap[,] bmps1 = new Bitmap[1000, 1000];
        Random r = new Random();

        Rectangle[,] dr = new Rectangle[600, 600];
        Button[,] b = new Button[10000, 10000];
        int[,] a11 = new int[300, 300];

        int[,] c = new int[100, 100];
        public int x1, y1, x2, y2, a1 = 1, nr = 0, ok, x, k, nr1 = 1, n;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nr1 == nr + 1) timer1.Stop();
            else
            {
                Bitmap bimage = new Bitmap(bmps1[v[nr1].x, v[nr1].y]);
                TextureBrush tb = new TextureBrush(bimage);

                g.FillRectangle(tb, dr[v[nr1].x, v[nr1].y]);

                nr1++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            n = int.Parse(textBox1.Text);
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog1.InitialDirectory + openFileDialog1.FileName;

            }
            int j;
            Image img = Image.FromFile(s.ToString());
            MessageBox.Show(img.Width.ToString() + "   " + img.Height.ToString());
            int widththird = (int)((double)img.Width / n);
            int heightthird = (int)((double)img.Height / n);
            MessageBox.Show(widththird.ToString() + "  " + heightthird.ToString());
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {

                    dr[i, j] = new Rectangle();


                    dr[i, j].Height = heightthird;
                    dr[i, j].Width = widththird;
                    bmps1[i, j] = new Bitmap(widththird, heightthird);
                    g1 = Graphics.FromImage(bmps1[i, j]);
                    g1.DrawImage(img, new Rectangle(0, 0, widththird, heightthird), 
                    new Rectangle(i * widththird, j * heightthird, widththird, heightthird),
                    GraphicsUnit.Pixel);

                    g = this.CreateGraphics();

                    dr[i, j].Location = new Point(i * (widththird), j * (heightthird));

                    Pen p = new Pen(Color.Red, 1);
                    g.DrawRectangle(p, dr[i, j]);


                }


            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                {

                    nr++;
                    v[nr] = new Class2();
                    v[nr].x = i;
                    v[nr].y = j;

                }
        }

            int[] vf = new int[100000];
        int[] v1 = new int[100000];
        int[] v2 = new int[1000];
        int[,] d = new int[10000, 10000];
        Class2[] v = new Class2[100000];
        Graphics g1;
        string s;

        public anim_matrice()
        {
            InitializeComponent();
        }
    }
}
