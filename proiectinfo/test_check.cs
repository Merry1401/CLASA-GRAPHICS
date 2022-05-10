using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proiectinfo
{
    public partial class test_check : Form
    { 
         int i, j, ok, x, n, nr = 0, n1 = 0;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\proiectinfo\catalog1.mdf;Integrated Security=True");
        
        int[] v1 = new int[100];
        CheckBox[] c = new CheckBox[10];

        private void test_check_Load(object sender, EventArgs e)
        {
            for (i = 1; i <= 99; i++)
                v1[i] = 0;

            con.Open();
            string select = "select * from logare";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                comboBox1.Items.Add(r[1].ToString());

            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert = @"insert into catalog1(tip_test, nume,nota,data)values(@tip_test, @nume,@nota,@data)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("tip_test", listBox1.Text);
            cmd.Parameters.AddWithValue("nume", comboBox1.Text);
            cmd.Parameters.AddWithValue("nota", nr.ToString());
            cmd.Parameters.AddWithValue("data", dateTimePicker1.Value.ToString());
            SqlDataReader r = cmd.ExecuteReader();
            con.Close();

        }

        

        int[] v = new int[100];
    intreb[] vect = new intreb[100];
    struct intreb
    {
        public string test, raspuns;

    };

        public test_check()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // n = int.Parse(textBox1.Text);
            StreamReader f = new StreamReader("TextFile2.txt");
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

           MessageBox.Show(nr.ToString());
        }
    }
}
