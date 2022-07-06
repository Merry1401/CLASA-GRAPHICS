using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class string_colorat : Form
    {
        Graphics g;
        Random r = new Random();

        public string_colorat()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            String drawString = "VALENII DE MUNTE, JUD PRAHOVA";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            float x = 20.0F;
            float y = 150.0F;
            g.DrawString(drawString, drawFont, drawBrush, x, y);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            desen_string f = new desen_string();
            f.Show();
        }
    }
}
