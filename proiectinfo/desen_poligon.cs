using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proiectinfo
{
    public partial class desen_poligon : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);
        public desen_poligon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(230, 154, 89);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chocolate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            PointF point1 = new PointF(150.0F, 70.0F);
            PointF point2 = new PointF(190.0F, 75.0F);
            PointF point3 = new PointF(250.0F, 50.0F);
            PointF point4 = new PointF(330.0F, 100.0F);
            PointF point5 = new PointF(370.0F, 150.0F);
            PointF point6 = new PointF(420.0F, 250.0F);
            PointF point7 = new PointF(250.0F, 300.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            g.DrawPolygon(p, curvePoints);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            PointF point1 = new PointF(150.0F, 70.0F);
            PointF point2 = new PointF(190.0F, 75.0F);
            PointF point3 = new PointF(250.0F, 50.0F);
            PointF point4 = new PointF(330.0F, 100.0F);
            PointF point5 = new PointF(370.0F, 150.0F);
            PointF point6 = new PointF(420.0F, 250.0F);
            PointF point7 = new PointF(250.0F, 300.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            Image newImage = Image.FromFile("blue.jpg");
            Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            g.FillPolygon(tb, curvePoints);
        }
    }
}
