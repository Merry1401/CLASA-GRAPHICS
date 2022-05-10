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
    public partial class itemi : Form
    {
        int i = 0, nr, n, x;
        Class6[] v = new Class6[100];
        Label[] l = new Label[100];
        TextBox[] t = new TextBox[100];
        int[] vf = new int[100];
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wind 10\source\repos\proiectinfo\catalog1.mdf;Integrated Security=True");

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
            string insert = @"insert into catalog1(tip_test, nume,nota,data)values(@tip_test, @nume,@nota,@data)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("tip_test", listBox1.Text);
            cmd.Parameters.AddWithValue("nume", comboBox1.Text);
            cmd.Parameters.AddWithValue("nota", nr.ToString());
            cmd.Parameters.AddWithValue("data", dateTimePicker1.Value.ToString());
            SqlDataReader r = cmd.ExecuteReader();
            con.Close();
        }

        private void itemi_Load(object sender, EventArgs e)
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

        Random r = new Random();
        int[] v1 = new int[100];

        public itemi()
        {
            InitializeComponent();
        }
    }
}
