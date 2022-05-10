using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proiectinfo
{
    public partial class desenstring : Form
    {
        int nr = 0;
        string s = "informatica  si matematica";
        Graphics g;
        public desenstring()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            desen_string f = new desen_string();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr++;
            int l = s.Length;
            label3.Text = s.Substring(0, nr % l);
        }
    }
}
