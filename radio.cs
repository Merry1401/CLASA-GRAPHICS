using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class radio : Form
    {
        Class1[] v = new Class1[100];
        string s1;
        int[] s = new int[100];
        int k, nr = 0, i;
        int[] v1 = new int[100];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\ProiectGraphics\Catalog.mdf;Integrated Security=True");
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
            string insert = @"insert into catalog(tip_test,nota,data,id_clasa)values(@tip_test,@nota,@data,@id_clasa)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("tip_test", "radio");
            cmd.Parameters.AddWithValue("id_clasa", textBox1.Text);
            cmd.Parameters.AddWithValue("nota", nr.ToString());
            cmd.Parameters.AddWithValue("data", DateTime.Now.ToString());
            SqlDataReader r = cmd.ExecuteReader();
            con.Close();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                s1 = openFileDialog1.InitialDirectory + openFileDialog1.FileName;


            }

            using (StreamWriter f = File.AppendText(s1))
            {
                f.WriteLine(textBox1.Text.Trim() + "|" + listBox1.Text.Trim() + "|" + textBox2.Text.Trim() + "|check|" + nr.ToString() + "|" + DateTime.Now.ToString());
                f.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string select = "select id, nume_prenume,clasa from elevi";
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

        private void radio_Load(object sender, EventArgs e)
        {
            for (i = 1; i <= 99; i++)
                v1[i] = 0;

            con.Open();
            string select = "select id, nume_prenume, clasa from elevi";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                listBox1.Items.Add(r[1].ToString());

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
