using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProiectGraphics
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
                get { return Color.FromArgb(236, 83, 59); }
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

       

        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(rand.Next(0, 255),rand.Next(0, 255),rand.Next(0, 255)));

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

       
        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liste f = new liste();
            f.Show();
            this.Hide();
        }


        private void desenareCuMouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            desenmouse f = new desenmouse();
            f.Show();
            this.Hide();
        }

        private void animatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            anim_matrice f = new anim_matrice();
            f.Show();
        }

        private void inregistrareEleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            inregistrare_elevi f = new inregistrare_elevi();
            f.Show();
        }

        private void listaCircularaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            lista_circulara f = new lista_circulara();
            f.Show();
        }

        private void rotiriStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            rotiri_string f = new rotiri_string();
            f.Show();
        }

        private void graficeMatematiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            grafice_mate f = new grafice_mate();
            f.Show();
        }

        private void testRecunoastereImaginiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            test_imagini f = new test_imagini();
            f.Show();
        }

        private void xSi0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void hartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            harta f = new harta();
            f.Show();
        }

        private void imperechereaUnorCuloriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            imperechere_culori f = new imperechere_culori();
            f.Show();
        }

        private void testRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            radio f = new radio();
            f.Show();
        }

        private void testCuCheckuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            testcheck f = new testcheck();
            f.Show();
        }

        private void itemiDeCompletareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            itemi f = new itemi();
            f.Show();
        }

        private void tabelDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            test1 f = new test1();
            f.Show();
        }

        private void adaugaIntrebariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ans_test_r f = new ans_test_r();
            f.Show();
        }

        private void adaugaIntrebariToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ans_test f = new ans_test();
            f.Show();
        }

        private void adaugaIntrebariToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ans_test f = new ans_test();
            f.Show();
        }

        private void testGrilaCuFloriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            test_grila f = new test_grila();
            f.Show();
        }

        private void algoritmFillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            algoritm_fill f = new algoritm_fill();
            f.Show();
        }

        private void tabelDateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tabel f = new tabel();
            f.Show();
        }
    }
}
