using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace ProiectGraphics
{
    public partial class lista_circulara : Form
    {
        Graphics g;
        int n;
        int[] v = new int[100];
        string s;
        public lista_circulara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog1.InitialDirectory + openFileDialog1.FileName;


            }

            using (StreamReader fin = new StreamReader(s))
            {
                string s1 = fin.ReadLine();
                n = int.Parse(s1);
                string s2 = fin.ReadLine();
                string[] vs = s2.Split(' ');
                for (int i = 0; i < vs.Count(); i++)
                    v[i] = int.Parse(vs[i].ToString());
                fin.Close();
            }

            for (int i = 1; i <= n; i++) MessageBox.Show(v[i].ToString());

            g = this.CreateGraphics();
            g.TranslateTransform(300, 300);
            int raza = 150;
            for (int i = 1; i <= 12; i++)
            {

                //desen(100);
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4);

                Pen p = new Pen(Color.Red, 2);


                Rectangle r1 = new Rectangle(-30, raza + 30, 30, 30);
                Rectangle r2 = new Rectangle(0, raza + 30, 30, 30);
                g.DrawRectangle(p, r1);
                g.DrawRectangle(p, r2);
                g.RotateTransform(30.0F);

                Pen penarc = new Pen(Color.Red, 2);
                penarc.CustomEndCap = bigArrow;
                float x = -195.0F;
                float y = -195.0F;
                float width = 390.0F;
                float height = 390.0F;

                float startAngle = 5.0F;
                float sweepAngle = 16.0F;

                g.DrawArc(penarc, x, y, width, height, startAngle, sweepAngle);

                String drawString = v[i].ToString();

                Font drawFont = new Font("Arial", 12);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                PointF drawPoint = new PointF(3, raza + 35);

                g.DrawString(drawString, drawFont, drawBrush, drawPoint);
            }
        }

            private void lista_circulara_MouseClick(object sender, MouseEventArgs e)
            {
                MessageBox.Show(e.X.ToString() + "   " + e.Y.ToString());
            }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
    }
    }

