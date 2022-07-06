using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class desen_dreptunghi : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);
        SolidBrush br = new SolidBrush(Color.Purple);
        LinearGradientBrush lg = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), Color.Yellow, Color.Violet);
        Image newImage = Image.FromFile("blue.jpg");
        public desen_dreptunghi()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Rectangle dreptunghi = new Rectangle(200, 90, 200, 120);
            Image newImage = Image.FromFile("blue.jpg");
            Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            g.FillRectangle(tb, dreptunghi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Rectangle dreptunghi = new Rectangle(200, 90, 200, 120);
            g.FillRectangle(lg, dreptunghi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            Rectangle dreptunghi = new Rectangle(200, 90, 200, 120);
            g.FillRectangle(br, dreptunghi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Rectangle dreptunghi = new Rectangle(200, 90, 200, 120);
            g.DrawRectangle(p, dreptunghi);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void desen_dreptunghi_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.BLEND);
        }
    }
}
