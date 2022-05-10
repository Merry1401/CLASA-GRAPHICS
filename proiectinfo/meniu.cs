using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace proiectinfo
{
    public partial class meniu : Form
    {
        Random rand = new Random();
        public meniu()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(236, 83, 59);}
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(238, 187, 47); }
            }
        }

        private void desenareLinieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desen_linie f = new desen_linie();
            f.Show();
            this.Hide();
        }

        private void desenareDreptunghiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            desen_dreptunghi f = new desen_dreptunghi();
            f.Show();
            this.Hide();
        }

        private void desenareElipsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            desen_elipsa f = new desen_elipsa();
            f.Show();
            this.Hide();
        }

        private void desenarePoligonToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            desen_poligon f = new desen_poligon();
            f.Show();
            this.Hide();
        }

        private void desenareStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desen_string f = new desen_string();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(rand.Next(0, 255),
                                                             rand.Next(0, 255),
                                                             rand.Next(0, 255)));

            Graphics graphics = this.CreateGraphics();

            int x = rand.Next(213, 399);
            int y = rand.Next(136, 284);

            int width = rand.Next(50, 350);
            int height = rand.Next(80, 250);

            graphics.FillRectangle(brush, new Rectangle(x, y, width, height));

            brush.Dispose();
            graphics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
        }

        private void rotatieCuTranslatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            rotatie_translatie f = new rotatie_translatie();
            f.Show();
            this.Hide();
        }

        private void desenareSoareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desen_soare f = new desen_soare();
            f.Show();
            this.Hide();
        }

        private void rotatieImagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
            rotatie_imagine f = new rotatie_imagine();
            f.Show();
            this.Hide();
        }

        private void miscareaUneiImaginiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miscare_imagine f = new miscare_imagine();
            f.Show();
            this.Hide();
        }


        private void deplaserePrinTasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rotatie_taste f = new rotatie_taste();
            f.Show();
            this.Hide();
        }

        private void testCheckuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            test_check f = new test_check();
            f.Show();
            this.Hide();
        }

        private void itemiDeCompletareToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            itemi f = new itemi();
            f.Show();
            this.Hide();
        }

        private void testRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            radio f = new radio();
            f.Show();
            this.Hide();
        }

        private void animatieStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            desen_string f = new desen_string();
            f.Show();
            this.Hide();
        }

        private void secventaVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            secventa f = new secventa();
            f.Show();
            this.Hide();
        }

        private void desenareFloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desen_floare f = new desen_floare();
            f.Show();
            this.Hide();
        }

        private void parcurgereMatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrice f = new matrice();
            f.Show();
            this.Hide();
        }

        private void slideShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            slideshow f = new slideshow();
            f.Show();
            this.Hide();
        }

        private void marireImagineToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            marire f = new marire();
            f.Show();
            this.Hide();
        }

        private void recursivitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            recursivitate f = new recursivitate();
            f.Show();
            this.Hide();
        }
    }
}
