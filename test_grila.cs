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
    public partial class test_grila : Form
    {
        SolidBrush s;
        Graphics g;
        bool ok;
        string rezultat;
        public test_grila()
        {
            InitializeComponent();
        }
        void floare(int a, int b, Color c, string nume)
        {
            g = this.CreateGraphics();

            String drawString = nume;


            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Black);


            PointF drawPoint = new PointF(a + 40, b - 15);
            Pen blackPen = new Pen(Color.Orange, 3);
            g.DrawString(drawString, drawFont, drawBrush, drawPoint);
            SolidBrush s = new SolidBrush(c);

            Point start = new Point(5, 0);
            Point control1 = new Point(25, -4);
            Point control2 = new Point(35, 0);
            Point control3 = new Point(25, 4);
            Point end = new Point(5, 0);
            PointF[] curvePoints =
             {
                start,
                control1,
                control2,
                control3,
                end

             };


            g.TranslateTransform(a, b);

            for (int i = 1; i <= 12; i++)
            {


                g.RotateTransform(30.0F);
                g.FillClosedCurve(s, curvePoints);

            }
            SolidBrush s1 = new SolidBrush(Color.Red);
            Rectangle r1 = new Rectangle(-7, -7, 15, 15);
            g.FillEllipse(s1, r1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            String drawString = "Care  floare nu face parte din familia Asteraceae";

            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Black);


            PointF drawPoint = new PointF(50.0F, 40.0F);


            g.DrawString(drawString, drawFont, drawBrush, drawPoint);
            floare(100, 100, Color.Yellow, "Trandafirul");
            floare(100, 200, Color.Yellow, "Floarea Soarelui");
            floare(100, 300, Color.Yellow, "Papadia");
        }

        private void test_grila_MouseClick(object sender, MouseEventArgs e)
        {
            if (Math.Sqrt((e.X - 100) * (e.X - 100) + (e.Y - 100) * (e.Y - 100)) < 35)
            {

                floare(100, 100, Color.Blue, "Trandafirul");
                floare(100, 200, Color.Yellow, "Floarea Soarelui");
                floare(100, 300, Color.Yellow, "Papadia");
                ok = true;
            }

            else if (Math.Sqrt((e.X - 100) * (e.X - 100) + (e.Y - 200) * (e.Y - 200)) < 35)
            {
                floare(100, 100, Color.Yellow, "Trandafirul");
                floare(100, 200, Color.Blue, "Floarea Soarelui");
                floare(100, 300, Color.Yellow, "Papadia");
                ok = false;
            }


            else if (Math.Sqrt((e.X - 100) * (e.X - 100) + (e.Y - 300) * (e.Y - 300)) < 35)
            {
                floare(100, 100, Color.Yellow, "Trandafirul");
                floare(100, 200, Color.Yellow, "Floarea Soarelui");
                floare(100, 300, Color.Blue, "Papadia");
                ok = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ok == true)
                rezultat = "Raspuns corect!";
            else
                rezultat = "Raspuns gresit";

            Font drawFont = new Font("Arial", 14);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            PointF drawPoint = new PointF(100, 400);
            Pen blackPen = new Pen(Color.Blue, 3);
            g = this.CreateGraphics();
            g.DrawString(rezultat, drawFont, drawBrush, drawPoint);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
    }
}
