using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class desen_floare : Form
    {
        public desen_floare()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 1);
            Point start = new Point(0, 0);
            Point control1 = new Point(100, 50);
            Point control2 = new Point(200, 0);
            Point end = new Point(0, 0);
            g.TranslateTransform(280.0F, 220.0F);
            for (int i = 1; i <= 12; i++)
            {
                g.DrawBezier(blackPen, start, control1, control2, end);
                g.RotateTransform(30.0F);
            }
        }
    }
}
