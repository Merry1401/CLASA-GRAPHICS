using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class rotatie_translatie : Form
    {
        int unghi = 0, xa = 220, ya = 50, xb, yb;
        public rotatie_translatie()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xa++;
            ya++;

            unghi = unghi + 1;
            Invalidate();
        }

        private void rotatie_translatie_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            g.TranslateTransform(xa, ya);
            Rectangle rect = new Rectangle(-xa / 2, -ya / 2, 100, 100);
            g.RotateTransform(unghi);
            g.DrawRectangle(blackPen, rect);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(113, 244, 108);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

    }
}
