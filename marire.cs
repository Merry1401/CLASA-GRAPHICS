using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class marire : Form
    {
        Graphics g, g1;
        int x = 0;
        SolidBrush s;
        Random r = new Random();
        Image newImage = Image.FromFile("blue.jpg");
        public marire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Invalidate();
            x = (x + 1) % 100;
        }

        private void marire_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            if (x % 50 == 0)
                s = new SolidBrush(System.Drawing.Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            g.TranslateTransform(300.0F, 300.0F);
            Pen penita = new Pen(Color.Red, 1);
            Rectangle dreptunghi = new Rectangle(-x, -x, x + 75, x);
            Rectangle dreptunghi1 = new Rectangle(-x - 100, -x - 100, x + 75, x);
            g.FillRectangle(tb, dreptunghi1);
            g.FillRectangle(s, dreptunghi);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Goldenrod;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(246, 208, 55);
        }



    }
}
