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

namespace proiectinfo
{
    public partial class radio : Form
    {
        Class1[] v = new Class1[100];
        int[] s = new int[100];
        int k, nr = 0,i;
        int[] v1 = new int[100];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\proiectinfo\catalog1.mdf;Integrated Security=True");
        public radio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nr < k)
            {

                nr++; //MessageBox.Show(nr.ToString());
                groupBox1.Text = v[nr].intrebare;
                radioButton1.Text = v[nr].r1;
                radioButton2.Text = v[nr].r2;
                radioButton3.Text = v[nr].r3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nr > 1)
            {

                nr--;// MessageBox.Show(nr.ToString());
                groupBox1.Text = v[nr].intrebare;
                radioButton1.Text = v[nr].r1;
                radioButton2.Text = v[nr].r2;
                radioButton3.Text = v[nr].r3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, rezultat = 0;
            for (i = 1; i <= k; i++)
                rezultat = rezultat + s[i];
            MessageBox.Show(rezultat.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (string.Compare(v[nr].r1.Trim(), v[nr].rc.Trim()) == 0)
                s[nr] = 2;
            else
                s[nr] = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (string.Compare(v[nr].r2.Trim().ToString(), v[nr].rc.Trim().ToString()) == 0)
                s[nr] = 2;
            else
                s[nr] = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (string.Compare(v[nr].r3.Trim(), v[nr].rc.Trim()) == 0)
                s[nr] = 2;
            else
                s[nr] = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void radio_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            k = 0;
            using (StreamReader fin = new StreamReader("TextFile3.txt"))
            {
                while (!fin.EndOfStream)
                {
                    string linie = fin.ReadLine();
                    string[] v1 = linie.Split('|');
                    k++;
                    v[k] = new Class1();
                    v[k].intrebare = v1[0].ToString();
                    v[k].r1 = v1[1].ToString();
                    v[k].r2 = v1[2].ToString();
                    v[k].r3 = v1[3].ToString();
                    v[k].rc = v1[4].ToString();
                }
                fin.Close(); //MessageBox.Show(k.ToString());
            }
        }
    }
}
