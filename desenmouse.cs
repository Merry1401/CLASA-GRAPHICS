using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class desenmouse : Form
    {
        bool ok1, ok2, ok3, ok4, ok5, ok6;
        int nr = 0, a, b, i = -1, start = 0, start2 = 0;
        Pen p = new Pen(Color.Black, 2);
        Graphics g;
        ColorDialog MyDialog;
        SolidBrush s;
        public bool ok, okey;

        private void desenmouse_MouseClick(object sender, MouseEventArgs e)
        {
            start = 1;

            int x = int.Parse(numericUpDown1.Value.ToString());
            int y = int.Parse(numericUpDown2.Value.ToString());
            g = this.CreateGraphics();
            nr++;
            if (s != null)
                s = new SolidBrush(MyDialog.Color);
            else
                s = new SolidBrush(Color.Black);
            if (ok1)
            {
                if (nr % 2 == 1)
                { a = e.X; b = e.Y; }
                else
                {
                    g.DrawLine(p, a, b, e.X, e.Y);

                }
            }

            if (ok2)
            {

                { a = e.X; b = e.Y; }

                Rectangle r = new Rectangle(a, b, x, y);
                g.DrawRectangle(p, r);
                g.FillRectangle(s, r);

            }
            if (ok3)
            {

                { a = e.X; b = e.Y; }

                Rectangle r = new Rectangle(a, b, 100, 100);
                g.DrawEllipse(p, r);
                g.FillEllipse(s, r);

            }
        }

        private void desenmouse_MouseMove(object sender, MouseEventArgs e)
        {

            if (ok6)
            {
                if (start2 == 1)
                {
                    g = this.CreateGraphics();
                    Rectangle r = new Rectangle(e.X, e.Y, 7, 7);
                    SolidBrush s2 = new SolidBrush(Color.White);
                    g.FillRectangle(s2, r);
                }

            }
            if (ok5)
            {
                if (start == 1)
                {
                    a = e.X;
                    b = e.Y;
                    if (ok == false)
                    {
                        i++; ;

                        g = this.CreateGraphics();
                        Rectangle r = new Rectangle(e.X, e.Y, 3, 3);
                        s = new SolidBrush(MyDialog.Color);
                        g.FillEllipse(s, r);
                        v[i] = new Point(int.Parse(e.X.ToString()), int.Parse(e.Y.ToString()));

                    }
                    else
                    {
                        i++;
                        v[i] = new Point(a, b);
                        for (int j = i + 1; j < v.Count(); j++)
                            v[j] = new Point(a, b);
                        g = this.CreateGraphics();
                        s = new SolidBrush(MyDialog.Color);
                        g.FillPolygon(s, v);

                        i = -1;
                    }
                }

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                ok5 = true;
            else
                ok5 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void desenmouse_MouseDown(object sender, MouseEventArgs e)
        {
            int x = int.Parse(numericUpDown1.Value.ToString());
            int y = int.Parse(numericUpDown2.Value.ToString());
            if (ok4)
            {
                switch (MouseButtons)
                {
                    case MouseButtons.Left:
                        {

                            i++;
                            v[i] = new Point(int.Parse(e.X.ToString()), int.Parse(e.Y.ToString()));
                            g = this.CreateGraphics();

                            s = new SolidBrush(MyDialog.Color);

                            Rectangle r = new Rectangle(e.X, e.Y, x, y);
                            g.FillEllipse(s, r); i++;
                            if (i == 0)
                            {
                                a = int.Parse(e.X.ToString());
                                b = int.Parse(e.Y.ToString());
                            }



                            break;
                        }
                    case MouseButtons.Right:
                        {

                            g = this.CreateGraphics();
                            s = new SolidBrush(MyDialog.Color);
                            for (int j = i + 1; j < v.Count(); j++)
                                v[j] = new Point(a, b);
                            g.FillPolygon(s, v);


                            i = -1;

                            break;
                        }


                }
            }
            if (ok5)

                switch (MouseButtons)
                {
                    case MouseButtons.Left: { ok = false; ; break; }
                    case MouseButtons.Right: { ok = true; break; }

                }
        }

        Point[] v = new Point[400];
        public desenmouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDialog = new ColorDialog();

            MyDialog.AllowFullOpen = false;

            MyDialog.ShowHelp = true;

            if (MyDialog.ShowDialog() == DialogResult.OK) { s = new SolidBrush(MyDialog.Color); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (start2 == 0)
                start2 = 1;
            else
                start2 = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                ok1 = true;
            else
                ok1 = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                ok2 = true;
            else
                ok2 = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                ok3 = true;
            else
                ok3 = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                ok4 = true;
            else
                ok4 = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
                ok6 = true;
            else
                ok6 = false;
        }

        private void desenmouse_Load(object sender, EventArgs e)
        {
           
        }
    }
}
