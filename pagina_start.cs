using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ProiectGraphics
{
    public partial class pagina_start : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\ProiectGraphics\Catalog.mdf;Integrated Security=True");

        public pagina_start()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            string insert =@"insert into logare(username,password)values(@username,@password)";
            SqlCommand cmd = new SqlCommand(insert, c);
            cmd.Parameters.AddWithValue("username", textBox2.Text);
            cmd.Parameters.AddWithValue("password", textBox1.Text);
            SqlDataReader r = cmd.ExecuteReader();
            textBox2.Clear();
            textBox1.Clear();
            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();
            string select = "select * from logare where username='" + textBox3.Text + "' and password= '" + textBox4.Text + "'";
            SqlCommand cmd = new SqlCommand(select, c);
            SqlDataReader r = cmd.ExecuteReader();
            if(r.Read() == true)
            {
                textBox3.Clear();
                textBox4.Clear();
                meniu f = new meniu();
                f.Show();
            }
            c.Close();
            
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
