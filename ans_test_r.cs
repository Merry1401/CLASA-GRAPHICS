using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProiectGraphics
{
    public partial class ans_test_r : Form
    {
        public ans_test_r()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Te rog introdu datele");
            }
            else
            {
                using (StreamWriter fout = File.AppendText("TextFile3.txt"))
                {


                    fout.WriteLine(textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|" + textBox5.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    fout.Close();

                }



            }
        }
    }
}
