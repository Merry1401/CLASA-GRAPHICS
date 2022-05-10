using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;

namespace proiectinfo
{
    public partial class recursivitate : Form
    {
        int i = 1;
        Graphics g;
        public recursivitate()
        {
            InitializeComponent();
        }
        void afis(int i)
        {
            if (i <= 5)
            {
                desen1(i);
                afis(i + 1);
            }
            desen2(i);
        }
        void desen2(int i)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.White, 1);
            Rectangle r = new Rectangle(i * 150, 100, 100, 100);
            g.DrawRectangle(p, r);
            if (i >= 1)
            {
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                //  Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigArrow;
                g.DrawLine(p, i * 150 - 50, 120, i * 150, 120);
                g.DrawLine(p, i * 150, 180, i * 150 - 50, 180);

            }

            String drawString = "i= " + i.ToString();


            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            float x = i * 150 + 30;
            float y = 120.0F;

            g.DrawString(drawString, drawFont, drawBrush, x, y);
            Thread.Sleep(1000);
        }
        void desen1(int i)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Rectangle r = new Rectangle(i * 150, 100, 100, 100);
            g.DrawRectangle(p, r);
            if (i > 1 && i <= 5)
            {
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                //  Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigArrow;
                g.DrawLine(p, i * 150 - 50, 120, i * 150, 120);
                g.DrawLine(p, i * 150, 180, i * 150 - 50, 180);
            }


            String drawString = "i= " + i.ToString();


            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            float x = i * 150 + 30;
            float y = 120.0F;

            g.DrawString(drawString, drawFont, drawBrush, x, y);
            Thread.Sleep(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afis(1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DodgerBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
    }
}
