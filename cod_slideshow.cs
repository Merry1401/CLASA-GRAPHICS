using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
{
    public partial class cod_slideshow : Form
    {
        public cod_slideshow()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            slideshow f = new slideshow();
            f.Show();
        }
    }
}
