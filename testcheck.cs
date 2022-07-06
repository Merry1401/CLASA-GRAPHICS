using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace ProiectGraphics
{
    public partial class testcheck : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\ProiectGraphics\Catalog.mdf;Integrated Security=True");
        int i, j, ok, x, n, nr = 0, n1 = 0;
        int[] v1 = new int[100];
        CheckBox[] c = new CheckBox[10];
        int[] v = new int[100];
        string s;
        intreb[] vect = new intreb[100];
        int nota = 0;

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert = @"insert into catalog(tip_test,nota,data,id_clasa)values(@tip_test,@nota,@data,@id_clasa)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("id_clasa", textBox1.Text);
            cmd.Parameters.AddWithValue("tip_test", "check");
            cmd.Parameters.AddWithValue("nota", nota.ToString());
            cmd.Parameters.AddWithValue("data", DateTime.Now.ToString());
            SqlDataReader r = cmd.ExecuteReader();
            textBox1.Clear();
            con.Close();


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog1.InitialDirectory + openFileDialog1.FileName;


            }

            using (StreamWriter f = File.AppendText(s))
            {
                f.WriteLine(textBox1.Text.Trim() + "|" + listBox1.Text.Trim() + "|" + textBox2.Text.Trim() + "|check|" + nota.ToString() + "|" + DateTime.Now.ToString());
                f.Close();
            }
        }

        private void testcheck_Load(object sender, EventArgs e)
        {
            con.Open();
            string select = "select id, nume_prenume,clasa from elevi";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                listBox1.Items.Add(r[1].ToString());

            }

            con.Close();

        }

        struct intreb
        {
            public string test, raspuns;

        };


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string select = "select id, nume_prenume ,clasa from elevi";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {

                if (string.Compare(listBox1.Text.Trim(), r[1].ToString().Trim()) == 0)
                {
                    textBox1.Text = r[0].ToString();
                    textBox2.Text = r[2].ToString();
                }
            }

            con.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s = openFileDialog1.InitialDirectory + openFileDialog1.FileName;


            }
            StreamReader f = new StreamReader(s);
            while (!f.EndOfStream)
            {
                n1++;

                vect[n1].test = f.ReadLine();
                vect[n1].raspuns = f.ReadLine();
                //MessageBox.Show(vect[n1].test);
            }
            Random r = new Random();
            for (i = 1; i <= 4; i++)
            {
                int ok = 0;

                while (ok == 0)
                {
                    x = r.Next(1, n1);
                    if (v1[x] == 0)
                    {
                        v1[x] = 1;
                        v[i] = x;
                        ok = 1;
                    }
                }
            }
            checkBox1.Text = vect[v[1]].test;
            checkBox2.Text = vect[v[2]].test;
            checkBox3.Text = vect[v[3]].test;
            checkBox4.Text = vect[v[4]].test;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && vect[v[1]].raspuns == "Da")
                nr++;
            if (checkBox2.Checked && vect[v[2]].raspuns == "Da")
                nr++;
            if (checkBox3.Checked && vect[v[3]].raspuns == "Da")
                nr++;
            if (checkBox4.Checked && vect[v[4]].raspuns == "Da")
                nr++;
            nota = nr * 2 + 2;
            MessageBox.Show(nota.ToString());
        }



        public testcheck()
        {
            InitializeComponent();
        }

    }
}
