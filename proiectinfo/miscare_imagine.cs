using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proiectinfo
{
    public partial class miscare_imagine : Form
    {
        Image newImage = Image.FromFile("blue.jpg");
        Rectangle destRect1 = new Rectangle(60, 70, 40, 40);
        Image newImage1 = Image.FromFile("blue.jpg");
        Rectangle destRect2 = new Rectangle(240, 190, 220, 220);
        public miscare_imagine()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            destRect1.X += 3;
            destRect1.Y += 3;
            if (destRect1.IntersectsWith(destRect2)) timer1.Stop();
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void miscare_imagine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(newImage, destRect1);
            g.DrawImage(newImage1, destRect2);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.BlueViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateBlue;
        }
    }
}
