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


namespace proiectinfo
{
    public partial class pagina_start : Form
    {

        public pagina_start()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox2.Text == "" && textBox1.Text == "")
                {
                    MessageBox.Show("Te rog introdu datele");
                }
                else
                {
                    using (StreamWriter fout = File.AppendText("TextFile1.txt"))
                    {


                        fout.WriteLine(textBox2.Text + "/" + textBox1.Text);
                        textBox2.Text = "";
                        textBox1.PasswordChar = '*';
                        textBox1.Clear();
                        fout.Close();

                    }



                }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = false;
            {
                if (textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Te rog introdu datele");
                }
                else
                {
                    using (StreamReader fin = new StreamReader("TextFile1.txt"))

                    {
                        while (!fin.EndOfStream)
                        {
                            string l = fin.ReadLine();
                            string[] v = l.Split('/');
                            if (String.Compare(textBox3.Text.Trim(), v[0].ToString().Trim()) == 0 && String.Compare(textBox4.Text.Trim(), v[1].ToString().Trim()) == 0)

                                ok = true;
                        }

                        if (ok == true)
                        {
                            meniu f = new meniu();
                            f.Show();
                        }
                        else
                            MessageBox.Show("creaza un cont");

                        fin.Close();

                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.PasswordChar = (char)0;

            }
            else
            {
                textBox1.PasswordChar = '*';


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = (char)0;
            }
            else
            {
                textBox4.PasswordChar = '*';

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(236, 83, 59);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(236, 83, 59);
        }

        private void pagina_start_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.CENTER);
        }
    }
}
