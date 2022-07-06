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
using System.IO;

namespace ProiectGraphics
{
    public partial class liste : Form
    {
        Graphics g;
        int n;
        int[] v = new int[100];
        public liste()
        {
            InitializeComponent();
        }
        public class Node
        {
            public int val;
            public Node leg;
            public Node st, dr;
        }

        public Node c = new Node();
        public Node p = new Node();
        public Node u = new Node();
        public void add()
        {
            c = new Node();
            c.val = 1;
            c.leg = null;
            p = c; u = c;
            desen(1);
            for (int i = 2; i <= 7; i++)
            {
                c = new Node();
                c.val = i;
                desen(i);
                c.leg = null;
                u.leg = c; u = c;
            }
        }
        public void add2()
        {
            c = new Node();
            c.val = 1;
            c.dr = null;
            c.st = null;
            p = c; u = c;
            desen2(1);
            for (int i = 2; i <= 7; i++)
            {
                c = new Node();
                c.val = i;
                desen2(i);
                u.dr = c;
                c.st = u;
                u = c;

            }

        }
        public void parcurgere_dr()
        {
            c = p; int i = 1;
            while(c!=null)
            {
                desen3(i);
                i++;
                c = c.dr;
            }
        }
        public void parcurgere_st()
        {
            c = u; int i = 7;
            while (c != null)
            {
                desen4(i);
                i--;
                c = c.st;
            }
        }
        public void parcurgere()
        {
            c = p; int i = 1;
            while (c != null)
            {
                desen1(i);
                i++;
                c = c.leg;
            }
        }


        void desen(int x)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            Pen p1 = new Pen(Color.Red, 1);
            Rectangle r = new Rectangle(100 + x * 130, 100, 50, 50);
            Rectangle r1 = new Rectangle(100 + x * 130 + 50, 100, 50, 50);
            g.DrawRectangle(p, r1);
            g.DrawRectangle(p, r);
            p1.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            p1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            string drawString = "c";
            string s1 = "NULL";
            Font drawFont = new Font("Arial", 16);
            Font drawFont2 = new Font("Arial", 10);

            SolidBrush drawBrush = new SolidBrush(Color.Red);
            if (x < 7)
            {
                g.DrawLine(p1, 100 + x * 130 + 70, 125, 100 + (x + 1) * 130, 125);
                g.DrawString(drawString, drawFont, drawBrush, 60 + x * 130 + 50, 110);
            }
            if (x == 7)
            {
                g.DrawString(s1, drawFont2, drawBrush, 98 + x * 130 + 50, 115);
            }
            Thread.Sleep(500);

        }


        void desen1(int x)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Pen p1 = new Pen(Color.Blue, 1);
            Rectangle r = new Rectangle(100 + x * 130, 100, 50, 50);
            Rectangle r1 = new Rectangle(100 + x * 130 + 50, 100, 50, 50);
            g.DrawRectangle(p, r1);
            g.DrawRectangle(p, r);
            p1.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            p1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            string drawString = "c";
            string s1 = "NULL";
            Font drawFont = new Font("Arial", 16);
            Font drawFont2 = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            if (x < 7)
            {
                g.DrawLine(p1, 100 + x * 130 + 70, 125, 100 + (x + 1) * 130, 125);
                g.DrawString(drawString, drawFont, drawBrush, 60 + x * 130 + 50, 110);
            }
            if (x == 7)
            {
                g.DrawString(s1, drawFont2, drawBrush, 98 + x * 130 + 50, 115);
            }
            Thread.Sleep(500);

        }

        void desen2(int x)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            Pen p1 = new Pen(Color.Red, 2);
            Pen p2 = new Pen(Color.Red, 2);
            Rectangle r = new Rectangle(100 + x * 130, 300, 120, 50);
            g.DrawRectangle(p, r);
            g.DrawLine(p, 140 + x * 130, 300, 140 + x * 130, 350);
            g.DrawLine(p, 180 + x * 130, 300, 180 + x * 130, 350);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(3, 3);
            p1.CustomEndCap = bigArrow;
            p2.CustomStartCap = bigArrow;

            string drawString = "c";
            string s1 = "NULL";
            Font drawFont = new Font("Arial", 16);
            Font drawFont2 = new Font("Arial", 10);

            SolidBrush drawBrush = new SolidBrush(Color.Red);
            if (x < 7)
            {
                g.DrawLine(p1, 130 + x * 130 + 70, 315, 130 + (x + 1) * 130, 315);
                g.DrawLine(p2, 130 + x * 130 + 70, 335, 130 + (x + 1) * 130, 335);
                g.DrawString(drawString, drawFont, drawBrush, 103 + x * 130 + 50, 310);
            }
            if(x == 1)
            {
                g.DrawString(s1, drawFont2, drawBrush, 47 + x * 130 + 50, 315);
            }
            if (x == 7)
            {
                g.DrawString(s1, drawFont2, drawBrush, 128 + x * 130 + 50, 315);
                g.DrawString(drawString, drawFont, drawBrush, 105 + x * 130 + 50, 310);
            }
            Thread.Sleep(500);

        }
        void desen3(int x)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Pen p1 = new Pen(Color.Blue, 2);
            Pen p2 = new Pen(Color.Blue, 2);
            Rectangle r = new Rectangle(100 + x * 130, 300, 120, 50);
            g.DrawRectangle(p, r);
            g.DrawLine(p, 140 + x * 130, 300, 140 + x * 130, 350);
            g.DrawLine(p, 180 + x * 130, 300, 180 + x * 130, 350);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(3, 3);
            p1.CustomEndCap = bigArrow;
            p2.CustomStartCap = bigArrow;

            string drawString = "c";
            string s1 = "NULL";
            Font drawFont = new Font("Arial", 16);
            Font drawFont2 = new Font("Arial", 10);

            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            if (x < 7)
            {
                g.DrawLine(p1, 130 + x * 130 + 70, 315, 130 + (x + 1) * 130, 315);
                g.DrawLine(p2, 130 + x * 130 + 70, 335, 130 + (x + 1) * 130, 335);
                g.DrawString(drawString, drawFont, drawBrush, 103 + x * 130 + 50, 310);
            }
            if (x == 1)
            {
                g.DrawString(s1, drawFont2, drawBrush, 47 + x * 130 + 50, 315);
            }
            if (x == 7)
            {
                g.DrawString(s1, drawFont2, drawBrush, 128 + x * 130 + 50, 315);
                g.DrawString(drawString, drawFont, drawBrush, 105 + x * 130 + 50, 310);
            }
            Thread.Sleep(500);

        }
        void desen4(int x)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Green, 1);
            Pen p1 = new Pen(Color.Green, 2);
            Pen p2 = new Pen(Color.Green, 2);
            Rectangle r = new Rectangle(100 + x * 130, 300, 120, 50);
            g.DrawRectangle(p, r);
            g.DrawLine(p, 140 + x * 130, 300, 140 + x * 130, 350);
            g.DrawLine(p, 180 + x * 130, 300, 180 + x * 130, 350);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(3, 3);
            p1.CustomEndCap = bigArrow;
            p2.CustomStartCap = bigArrow;

            string drawString = "c";
            string s1 = "NULL";
            Font drawFont = new Font("Arial", 16);
            Font drawFont2 = new Font("Arial", 10);

            SolidBrush drawBrush = new SolidBrush(Color.Green);
            if (x < 7)
            {
                g.DrawLine(p1, 130 + x * 130 + 70, 315, 130 + (x + 1) * 130, 315);
                g.DrawLine(p2, 130 + x * 130 + 70, 335, 130 + (x + 1) * 130, 335);
                g.DrawString(drawString, drawFont, drawBrush, 103 + x * 130 + 50, 310);
            }
            if (x == 1)
            {
                g.DrawString(s1, drawFont2, drawBrush, 47 + x * 130 + 50, 315);
            }
            if (x == 7)
            {
                g.DrawString(s1, drawFont2, drawBrush, 128 + x * 130 + 50, 315);
                g.DrawString(drawString, drawFont, drawBrush, 105 + x * 130 + 50, 310);
            }
            Thread.Sleep(500);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parcurgere();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            meniu f = new meniu();
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            add2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parcurgere_dr();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            parcurgere_st();
        }

    }
}
