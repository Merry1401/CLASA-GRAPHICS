using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace proiectinfo
{
    public partial class desen_elipsa : Form
    {
        Graphics g;
        Pen p = new Pen(Color.Black);
        SolidBrush br = new SolidBrush(Color.BlueViolet);
        public desen_elipsa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            g.DrawEllipse(p, 170, 70, 160, 160);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            g.FillEllipse(br, 170, 70, 160, 160);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(170, 70, 160, 160);

            PathGradientBrush pthGrBrush = new PathGradientBrush(path);

            
            pthGrBrush.CenterColor = Color.BlueViolet;

            
            Color[] colors = { Color.Cyan };
            pthGrBrush.SurroundColors = colors;
            g.DrawEllipse(p, 170, 70, 160, 160);
            g.FillEllipse(pthGrBrush, 170, 70, 160, 160);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
    }
}
