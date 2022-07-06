using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProiectGraphics
{
    public partial class inregistrare_elevi : Form
    {
        SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\ProiectGraphics\Catalog.mdf;Integrated Security=True");

        public inregistrare_elevi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            string insert = @"insert into elevi(nume_prenume,clasa, telefon,email)values(@nume_prenume,@clasa, @telefon,@email)";
            SqlCommand cmd = new SqlCommand(insert, c);
            cmd.Parameters.AddWithValue("nume_prenume", textBox1.Text);
            cmd.Parameters.AddWithValue("clasa", textBox2.Text);
            cmd.Parameters.AddWithValue("telefon", textBox3.Text);
            cmd.Parameters.AddWithValue("email", textBox4.Text);
            SqlDataReader r = cmd.ExecuteReader();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            c.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

       
    }
}
