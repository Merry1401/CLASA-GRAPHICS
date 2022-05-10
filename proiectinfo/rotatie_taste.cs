using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proiectinfo
{
    public partial class rotatie_taste : Form
    {
        bool r, l, sus, jos, r1, l1, sus1, jos1;
        Random x = new Random();
        int i = 100, j = 100, i1 = 200, j1 = 200;
        Pen p;
        Graphics g;
        public rotatie_taste()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            g.Clear(Color.White);
            if (r == true) { i += 5; }
            if (l == true) { i -= 5; }
            if (sus == true) { j += 5; }
            if (jos == true) { j -= 5; }

            if (r1 == true) { i1 += 5; }
            if (l1 == true) { i1 -= 5; }
            if (sus1 == true) { j1 += 5; }
            if (jos1 == true) { j1 -= 5; }
            p = new Pen(Color.Black, 2);
            Rectangle rectangle1 = new Rectangle(i, j, 100, 100);
            Rectangle rectangle2 = new Rectangle(i1, j1, 50, 50);
            g.DrawRectangle(Pens.Black, rectangle1);
            g.DrawRectangle(Pens.Red, rectangle2);
            if (rectangle2.IntersectsWith(rectangle1))
            {
                rectangle1.Intersect(rectangle2);
                if (!rectangle1.IsEmpty)
                {
                    i1 = 70; j1 = 50;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void rotatie_taste_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right) { r = true; }
            if (e.KeyCode == Keys.Left) { l = true; }
            if (e.KeyCode == Keys.Down) { sus = true; }
            if (e.KeyCode == Keys.Up) { jos = true; }


            if (e.KeyCode == Keys.D) { r1 = true; }
            if (e.KeyCode == Keys.A) { l1 = true; }
            if (e.KeyCode == Keys.S) { sus1 = true; }
            if (e.KeyCode == Keys.W) { jos1 = true; }

        }

        private void rotatie_taste_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { r = false; }
            if (e.KeyCode == Keys.Left) { l = false; }
            if (e.KeyCode == Keys.Down) { sus = false; }
            if (e.KeyCode == Keys.Up) { jos = false; }

            if (e.KeyCode == Keys.D) { r1 = false; }
            if (e.KeyCode == Keys.A) { l1 = false; }
            if (e.KeyCode == Keys.S) { sus1 = false; }
            if (e.KeyCode == Keys.W) { jos1 = false; }

        }

        private void rotatie_taste_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
