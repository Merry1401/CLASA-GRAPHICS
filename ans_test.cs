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
    public partial class ans_test : Form
    {
        public ans_test()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            meniu f = new meniu();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Te rog introdu datele");
            }
            else
            {
                using (StreamWriter fout = File.AppendText("TextFile2.txt"))
                {


                    fout.WriteLine(textBox1.Text);
                    fout.WriteLine(textBox2.Text);
                    textBox1.Clear();
                    textBox2.Clear();
                    fout.Close();

                }
            }
        }
    }
}
