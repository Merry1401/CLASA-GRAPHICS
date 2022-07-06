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
    public partial class itemi : Form
    {
        int i = 0, nr, n, x;
        string s1;
        Class6[] v = new Class6[100];
        Label[] l = new Label[100];
        TextBox[] t = new TextBox[100];
        int[] vf = new int[100];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\ProiectGraphics\Catalog.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int i1;
            i = 0;

            using (StreamReader f = new StreamReader("TextFile2.txt"))
            {
                while (!f.EndOfStream)
                {

                    v[i] = new Class6();
                    v[i].intrebare = f.ReadLine();
                    v[i].raspuns = f.ReadLine();
                    i++;
                }

                f.Close();
            }


            n = int.Parse(textBox1.Text.ToString());
            for (i1 = 0; i1 < n; i1++)
            {
                int ok = 1;
                while (ok == 1)
                {
                    x = r.Next(0, i);
                    if (vf[x] == 0)
                    {
                        ok = 0;
                        v1[i1] = x;
                        vf[x]++;
                    }
                }

            }

            for (int j = 0; j < n; j++)
            {

                l[j] = new Label();
                l[j].Text = v[v1[j]].intrebare;
                this.l[j].AutoSize = true;
                l[j].Location = new Point(400, 200 + j * 40);
                this.Controls.Add(l[j]);
                t[j] = new TextBox();
                t[j].Location = new Point(300, 200 + j * 40);
                this.Controls.Add(t[j]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nr = 0;

            for (int j = 0; j < n; j++)
            {

                if (string.Compare(t[j].Text.Trim(), v[v1[j]].raspuns.Trim()) == 0)
                    nr++;
            }
            MessageBox.Show(nr.ToString());
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
            string insert = @"insert into catalog(tip_test,nota,data,id_clasa)values(@tip_test,@nota,@data,@id_clasa)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("id_clasa", textBox1.Text);
            cmd.Parameters.AddWithValue("tip_test", "itemi");
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

        private void itemi_Load(object sender, EventArgs e)
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
                    textBox2.Text = r[0].ToString();
                    textBox3.Text = r[2].ToString();
                }
            }

            con.Close();
        }

        Random r = new Random();
        int[] v1 = new int[100];

        public itemi()
        {
            InitializeComponent();
        }
    }
}
