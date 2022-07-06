using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class desen_string : Form
    {
        public desen_string()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            desenstring f = new desenstring();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(31, 168, 161);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumAquamarine;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(31, 168, 161);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.MediumAquamarine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            aparitii_succesive f = new aparitii_succesive();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            string_colorat f = new string_colorat();
            f.Show();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(31, 168, 161);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumAquamarine;
        }

        private void desen_string_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.CENTER);
        }
    }
}
