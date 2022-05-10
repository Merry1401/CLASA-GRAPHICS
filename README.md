# GRAPHICS
Am ales ca temă pentru Soft educational capitolul Graphics pentru că este folosit pentru:

- elevii si profesorii de la clasa când se predă Programarea Orientată pe Obiecte
 capitolul Graphics
- elemente din capitol sunt folosite la jocuri.
- elemente din capitol sunt folosite la proiecte.
- elemente din capitol sunt folosite la prezentări complexe care au nevoie de baze de date si
de anumite animații care nu se găsesc printre cele predefinite.
- poate înlocui anumite obiecte care consumă memorie.

Am structurat acest proiect pe mai multe capitole:

I. Prezentare de desene ale unor figuri elementare
1. Desenarea unei linii

g = this.CreateGraphics();
            g.Clear(Color.White);
            var pen = new Pen(Color.Red, 3);
            pen.DashStyle = DashStyle.DashDotDot;
            int x1 = 100;
            int y1 = 100;
            int x2 = 400;
            int y2 = 100;
            g.DrawLine(pen, x1, y1, x2, y2); - Cu ajutorul acestui cod am desenat o linie punctată. Mai întâi am ales culoarea, apoi stilul si coordonatele liniei.

            g = this.CreateGraphics();
            g.Clear(Color.White);
            var pen = new Pen(Color.Red, 3);
            pen.DashStyle = DashStyle.Dash;
            int x1 = 100;
            int y1 = 100;
            int x2 = 400;
            int y2 = 100;
            g.DrawLine(pen, x1, y1, x2, y2); - Acest cod a desenat tot o linie punctata, dar într-un stil diferit (Dash diferit de DashDotDot, care era o linie și două puncte), am ales culoarea și coordonatele.

 g = this.CreateGraphics();
            g.Clear(Color.White);
            var pen = new Pen(Color.Red, 3);
            pen.DashStyle = DashStyle.Dot;
            int x1 = 100;
            int y1 = 100;
            int x2 = 400;
            int y2 = 100;
            g.DrawLine(pen, x1, y1, x2, y2); - Acest cod a desenat o linie punctată.

  g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen redPen = new Pen(Brushes.Red, 6.0F);
            redPen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            redPen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(redPen, 80.0F, 40.0F, 300.0F, 185.0F); - Acest cod a desenat o săgeată, folosind System.Drawing.Drawing2D.LineCap.RoundAnchor la început și System.Drawing.Drawing2D.LineCap.ArrowAnchor la final.

g = this.CreateGraphics();
            g.Clear(Color.White);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(11, 11);
            Pen p = new Pen(Color.Blue, 1);
            p.CustomEndCap = bigArrow;
            g.DrawLine(p, 60, 30, 320, 200); - Acest cod a desenat tot o săgeată.


            g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen penita = new Pen(Color.Black, 3);
            PointF punct1 = new PointF(200.0F, 100.0F);
            PointF punct2 = new PointF(450.0F, 100.0F);
            g.DrawLine(penita, punct1, punct2); - Acest cod a desenat o linie normală.

Am folosit și eventul MouseHover și MouseLeave la butoane ca să schimb culoarea butonului când mouse-ul este pe el.

2. Desenarea unui Dreptunghi (desen, umplere, gradient, imagine)

3. Desenarea unei Elipse (desen, umplere, gradient)

4. Desenarea unui Poligon

 Graphics g;
        Pen p = new Pen(Color.Black);
 g = this.CreateGraphics();
            g.Clear(Color.White);
            PointF point1 = new PointF(150.0F, 70.0F);
            PointF point2 = new PointF(190.0F, 75.0F);
            PointF point3 = new PointF(250.0F, 50.0F);
            PointF point4 = new PointF(330.0F, 100.0F);
            PointF point5 = new PointF(370.0F, 150.0F);
            PointF point6 = new PointF(420.0F, 250.0F);
            PointF point7 = new PointF(250.0F, 300.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            g.DrawPolygon(p, curvePoints); - Am ales punctele poligonului si brush-ul, apoi am folosit comanda g.DrawPolygon pentru a desena poligonul.

g = this.CreateGraphics();
            g.Clear(Color.White);
            PointF point1 = new PointF(150.0F, 70.0F);
            PointF point2 = new PointF(190.0F, 75.0F);
            PointF point3 = new PointF(250.0F, 50.0F);
            PointF point4 = new PointF(330.0F, 100.0F);
            PointF point5 = new PointF(370.0F, 150.0F);
            PointF point6 = new PointF(420.0F, 250.0F);
            PointF point7 = new PointF(250.0F, 300.0F);
            PointF[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            Image newImage = Image.FromFile("blue.jpg");
            Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            g.FillPolygon(tb, curvePoints); - Am pus o imagine folosind Image newImage, Bitmap bimage si TextureBrush tb.

II. Prezentare de rotatii si translatii
1. Rotatie cu Translatie
Am adus pe forma un buton si un timer. Butonul porneste timer-ul, care schimba pozitia si unghiul unui patrat generat de paint.
  public partial class rotatie_translatie : Form
    {
        int unghi = 0, xa = 220, ya = 50, xb, yb;
        public rotatie_translatie()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xa++;
            ya++;

            unghi = unghi + 1;
            Invalidate();
        }

        private void rotatie_translatie_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            g.TranslateTransform(xa, ya);
            Rectangle rect = new Rectangle(-xa / 2, -ya / 2, 100, 100);
            g.RotateTransform(unghi);
            g.DrawRectangle(blackPen, rect);
        }
       private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


2. Desenare Soare
Am adus pe forma un buton care deseneaza un cerc, apoi deseneaza mai multe linii in jurul acelui cerc, folosing g.TranslateTransform si g.RotateTransform.
private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush s = new SolidBrush(Color.Yellow);
            Pen p = new Pen(Color.Yellow, 2);
            Graphics g = this.CreateGraphics();
            Rectangle r = new Rectangle(250, 200, 100, 100);
            g.DrawEllipse(p, r);
            g.FillEllipse(s, r);
            g.TranslateTransform(300.0F, 250.0F);

            for (int i = 1; i <= 36; i++)
            {

                g.DrawLine(p, new Point(0, 50), new Point(0, 200));
                g.RotateTransform(10.0F);
            }


3. Rotatie Dreptunghi
Am adus pe forma trei butoane si un timer. Primul buton deseneaza mai multe dreptunghiuri in jurul unui punct, al doilea porneste timer-ul care schimba unghiul unui dreptunghi generat de event-ul paint. Al treilea buton genereaza patru dreptunghiuri in jurul unui cerc.
int unghi = 0;
        SolidBrush s;
        public rotatie_imagine()
        {
            InitializeComponent();
        }

        private void rotatie_imagine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            g.TranslateTransform(300, 300);
            Rectangle rect = new Rectangle(-100, -25, 200, 50);
            g.RotateTransform(unghi);
            g.DrawRectangle(blackPen, rect);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen blackPen = new Pen(Color.Black, 3);   
            g.TranslateTransform(300, 300);
            Rectangle rect = new Rectangle(0, 0, 200, 50);
            for (int i = 1; i <= 12; i++)
            {
                g.DrawRectangle(blackPen, rect);
                g.RotateTransform(30);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            unghi = unghi + 1;
            Invalidate();
        }
 private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            s = new SolidBrush(Color.LightPink);
            SolidBrush s1 = new SolidBrush(Color.Orchid);
            g.TranslateTransform(300, 300);
            Rectangle rect = new Rectangle(-100, -25, 200, 50);
            Rectangle rect1 = new Rectangle(-25, -25, 50, 50);
            Rectangle rect2 = new Rectangle(-25, -100, 50, 200);
            g.RotateTransform(unghi);

            g.FillRectangle(s, rect);

            g.FillRectangle(s, rect2); g.FillEllipse(s1, rect1);
        }



4. Miscarea unei Imagini
Am adus pe forma un buton si un timer. Butonul porneste timer-ul, care misca o imagine mai mica spre una mai mare pana ce acestea se intersecteaza, dupa care se opreste.
Am folosit event-ul paint ca sa desenez cele doua imagini si Image newImage = Image.FromFile() ca sa aduc imaginile din fisier.
public partial class miscare_imagine : Form
    {
        Image newImage = Image.FromFile("blue.jpg");
        Rectangle destRect1 = new Rectangle(60, 70, 40, 40);
        Image newImage1 = Image.FromFile("blue.jpg");
        Rectangle destRect2 = new Rectangle(240, 190, 220, 220);
        public miscare_imagine()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            destRect1.X += 3;
            destRect1.Y += 3;
            if (destRect1.IntersectsWith(destRect2)) timer1.Stop();
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void miscare_imagine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(newImage, destRect1);
            g.DrawImage(newImage1, destRect2);
        }
 

5. Desenare Floare
Am adus pe forma un buton care deseneaza o floare folosindu-se de g.DrawBezier, desenand mai multe curbe bezier in jurul unui punct.
private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 1);
            Point start = new Point(0, 0);
            Point control1 = new Point(100, 50);
            Point control2 = new Point(200, 0);
            Point end = new Point(0, 0);
            g.TranslateTransform(280.0F, 220.0F);
            for (int i = 1; i <= 12; i++)
            {
                g.DrawBezier(blackPen, start, control1, control2, end);
                g.RotateTransform(30.0F);
            }


III. Evenimente cu taste
1. Deplasarea cu Taste
Am adus pe forma un timer, si m-am folosit de event-urile keyUp, keyDown si load ca sa fac aceste dreptunghiuri care se pot misca cu ajutorul tastelor.
Am folosit timer-ul ca sa generez dreptunghiurile, unul mai mare, si unul mai mic, rosu. Daca acestea se intersecteaza, cel rosu se va misca in spate.
public partial class rotatie_taste : Form
    {
        bool r, l, sus, jos, r1, l1, sus1, jos1;
        Random x = new Random();
        int i = 100, j = 100, i1 = 200, j1 = 200;
        Pen p;
        Graphics g;
        public rotatie_taste()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();

            g.Clear(Color.White);
            if (r == true) { i += 5; }
            if (l == true) { i -= 5; }
            if (sus == true) { j += 5; }
            if (jos == true) { j -= 5; }

            if (r1 == true) { i1 += 5; }
            if (l1 == true) { i1 -= 5; }
            if (sus1 == true) { j1 += 5; }
            if (jos1 == true) { j1 -= 5; }
            p = new Pen(Color.Black, 2);
            Rectangle rectangle1 = new Rectangle(i, j, 100, 100);
            Rectangle rectangle2 = new Rectangle(i1, j1, 50, 50);
            g.DrawRectangle(Pens.Black, rectangle1);
            g.DrawRectangle(Pens.Red, rectangle2);
            if (rectangle2.IntersectsWith(rectangle1))
            {
                rectangle1.Intersect(rectangle2);
                if (!rectangle1.IsEmpty)
                {
                    i1 = 70; j1 = 50;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void rotatie_taste_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right) { r = true; }
            if (e.KeyCode == Keys.Left) { l = true; }
            if (e.KeyCode == Keys.Down) { sus = true; }
            if (e.KeyCode == Keys.Up) { jos = true; }


            if (e.KeyCode == Keys.D) { r1 = true; }
            if (e.KeyCode == Keys.A) { l1 = true; }
            if (e.KeyCode == Keys.S) { sus1 = true; }
            if (e.KeyCode == Keys.W) { jos1 = true; }

        }

        private void rotatie_taste_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { r = false; }
            if (e.KeyCode == Keys.Left) { l = false; }
            if (e.KeyCode == Keys.Down) { sus = false; }
            if (e.KeyCode == Keys.Up) { jos = false; }

            if (e.KeyCode == Keys.D) { r1 = false; }
            if (e.KeyCode == Keys.A) { l1 = false; }
            if (e.KeyCode == Keys.S) { sus1 = false; }
            if (e.KeyCode == Keys.W) { jos1 = false; }

        }

        private void rotatie_taste_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


IV. Animatii
1. Animatie String
Am adus pe forma trei butoane, fiecare duce la o forma unde este desenat un tip diferit de string.
Primul buton duce la o forma unde este desenat un string normal.
        int nr = 0;
        string s = "informatica  si matematica";
        Graphics g;

 private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nr++;
            int l = s.Length;
            label3.Text = s.Substring(0, nr % l);
        }

Al doilea buton duce la o forma unde sunt aparitii succesive de string-uri.
int nr = 0;
        Graphics g;
        string s1 = "OLIMPIADA";
        string s2 = "DE INOVARE SI CREATIVITATE ";
        string s3 = "DIGITALA  (INFOEDUCATIA)";
        string s4 = "TEMA proiect  CLASA GRAPHICS";
        int nr2;
        float x;
        Graphics g1;

private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            nr++;
            if (nr % 4 == 1)
            {
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                float x = 150.0F;
                float y = 50.0F;

                g.DrawString(s1, drawFont, drawBrush, x, y);
            }
            else if (nr % 4 == 2)
            {

                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                float x = 160.0F;
                float y = 80.0F;

                g.DrawString(s2, drawFont, drawBrush, x, y);
            }
            else
            if (nr % 4 == 3)
            {
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                float x = 170.0F;
                float y = 110.0F;

                g.DrawString(s3, drawFont, drawBrush, x, y);
            }

            else
            {
                timer1.Stop();
                nr2 = 0;
                x = 500;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            g1 = this.CreateGraphics();
            if (nr2 == 60)
            {
                Thread.Sleep(2000);
                timer1.Stop();
                g1.Clear(Color.White);
            }
            else
            {
                g1.Clear(Color.White);
                Font drawFont = new Font("Arial", 16);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                g.DrawString(s1, drawFont, drawBrush, 150, 50);
                g.DrawString(s2, drawFont, drawBrush, 160, 80);
                g.DrawString(s3, drawFont, drawBrush, 170, 110);
                nr2++;


                x = 100.0F - nr2 * 5;
                float y = 150.0F;

                g1.DrawString(s4, drawFont, drawBrush, x, y);

            }
        }

Al treilea buton duce la un string care schimba culorile.
private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(Color.White);
            String drawString = "VALENII DE MUNTE, JUD PRAHOVA";
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            float x = 20.0F;
            float y = 150.0F;
            g.DrawString(drawString, drawFont, drawBrush, x, y);
        }


2. Slideshow
Am adus doua butoane si un timer, un buton va afisa slideshow-ul, iar altul va deschide un form cu codul folosit. Timer-ul scrie textul si genereaza imaginile. M-am folosit de Streamreader ca sa citesc din textfile numele imaginilor si punctele poligonului folosit.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace proiectinfo
{
    public partial class slideshow : Form
    {
        PointF[] v2 = new PointF[100];
        Class3[] v = new Class3[100];
        int k = 0, i = 0, n, m;

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader fin = new StreamReader("C:\\Users\\Wind 10\\source\\repos\\proiectinfo\\bin\\Debug\\netcoreapp3.1\\textslide.txt"))
            {
                while (!fin.EndOfStream)
                {
                    i++;
                    string s = fin.ReadLine();
                    string[] v = s.Split(' ');
                    v2[i] = new PointF(int.Parse(v[0].ToString()), int.Parse(v[1].ToString()));
                }
                fin.Close(); m = i;
            }

            using (StreamReader fin = new StreamReader("C:\\Users\\Wind 10\\source\\repos\\proiectinfo\\bin\\Debug\\netcoreapp3.1\\slide.txt"))
            {
                while (!fin.EndOfStream)
                {

                    string linie = fin.ReadLine();
                    string[] v1 = linie.Split('/');
                    v[k] = new Class3();
                    v[k].denumire = v1[0].ToString();
                    v[k].regiune = v1[1].ToString();
                    v[k].poza = v1[2].ToString(); k++;

                }
                n = k;
                fin.Close();
            }
            k = 1; timer1.Start(); i = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cod_slideshow f = new cod_slideshow();
            f.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkViolet;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkOrchid;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrchid;
        }

        Graphics g;
        public slideshow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            g = this.CreateGraphics(); g.Clear(Color.White);

            String drawString = v[i % n].denumire.ToString();

            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            float x = 400.0F;
            float y = 70.0F;

            g.DrawString(drawString, drawFont, drawBrush, x, y);



            String drawString2 = v[i % n].regiune.ToString();

            Font drawFont2 = new Font("Arial", 16);
            SolidBrush drawBrush2 = new SolidBrush(Color.Blue);

            float x2 = 400.0F;
            float y2 = 150.0F;

            g.DrawString(drawString2, drawFont2, drawBrush2, x2, y2);

            Image newImage = Image.FromFile(v[i % n].poza.ToString());
             Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            //SolidBrush s = new SolidBrush(Color.Red);
            //g.FillPolygon(s, v2);
              g.FillPolygon(tb, v2);
        }
    }
}



3. Marire Imagine
Am adus un buton care genereaza doua dreptunghiuri, unul cu culoare randomizata, altul cu o imagine. Acestea vor creste pana se intersecteaza, dupa care programul se va restarta, si culoarea dreptunghiului se va schimba.
Am un timer care mareste dreptunghiurile in fiecare secunda.
 private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Invalidate();
            x = (x + 1) % 100;
        }

        private void marire_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            if (x % 50 == 0)
            s = new SolidBrush(System.Drawing.Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            Bitmap bimage = new Bitmap(newImage);
            TextureBrush tb = new TextureBrush(bimage);
            g.TranslateTransform(300.0F, 300.0F);
            Pen penita = new Pen(Color.Red, 1);
            Rectangle dreptunghi = new Rectangle(-x, -x, x+75, x);
            Rectangle dreptunghi1 = new Rectangle(-x-100, -x-100, x+75, x);
            g.FillRectangle(tb, dreptunghi1);
            g.FillRectangle(s, dreptunghi);
        }

4. Secventa Vector

Am adus pe forma un obiect richtextBox, trei butoane.
In richteext vom introduce datele vectorului (pe prima linie un nr matural n iar pe a doua linie n numere intregi).
La apasarea pe un buton se genereaza vectorul.
la apasarea pe celalalt se simuleaza crearea de secvente.

if (i == n)
                timer1.Stop();
            else
            {
                if (v1[i] > 0)
                {
                    l++;
                    g.FillRectangle(br, v[i]);
                    String drawString = v1[i].ToString();
                    Font drawFont = new Font("Arial", 12);
                    SolidBrush drawBrush = new SolidBrush(Color.Blue);
                    float x = 118 + i * 56;
                    float y = 238.0F;


                    g.DrawString(drawString, drawFont, drawBrush, x, y);
                }
                else
                {
                    if (l > lmax)
                    {
                        lmax = l;
                        pmax = p;
                    }
                    l = 0; p = i;
                }
                i++;

            } - Acest cod coloreaza numerele pozitive.

{
int i;
            string s = richTextBox1.Lines[0];
            n = int.Parse(s);
            s = richTextBox1.Lines[1];



            string[] numere = s.Split(' ');
            for (i = 0; i <= n - 1; i++)
            {
                v1[i] = int.Parse(numere[i]);

            }

            g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            for (i = 0; i <= n - 1; i++)
            {
                v[i] = new Rectangle();
                v[i].Height = 50;
                v[i].Width = 50;
                v[i].Location = new Point(100 + i * 56, 230);

                String drawString = v1[i].ToString();

                Font drawFont = new Font("Arial", 12);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                float x = 118 + i * 56;
                float y = 238.0F;


                g.DrawString(drawString, drawFont, drawBrush, x, y);


                g.DrawRectangle(p, v[i]);}
            } - Acest cod deseneaza secventa.


5. Parcurgere Matrice
Am adus pe forma doua butoane, unul care deseneaza matricea, altul care umple casutele de sub diagonala principala.
 g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 1);
            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)

                {
                    a[i, j] = new Rectangle();
                    a[i, j].Height = 50;
                    a[i, j].Width = 50;
                    a[i, j].Location = new Point(100 + i * 56, 100 + j * 56);
                    g.DrawRectangle(p, a[i, j]);
                }

            for (int i = 1; i <= 6; i++)
                for (int j = 1; j <= 6; j++)
                {
                    if (i > j)
                    {
                        nr++;
                        v[nr] = new Class2();
                        v[nr].x = i;
                        v[nr].y = j;
                    }
                } - Acest cod deseneaza matricea.

if (nr1 == nr)
            {
                timer1.Stop();

            }
            g.FillRectangle(s, a[v[nr1].y, v[nr1].x]);
            nr1++; } - Acest cod umple casutele de sub diagonala principala.

6. Recursivitate
Am adus pe forma un buton, care va simula recursivitatea.
Am desenat dreptunghiurile, liniile, respectiv string-urile.
Am folosit threading si am procedat la fel pentru linie si pentru string.

void desen1(int i)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.Blue, 1);
            Rectangle r = new Rectangle(i * 150, 100, 100, 100);
            g.DrawRectangle(p, r);
            if (i > 1 && i <= 5)
            {
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                p.CustomEndCap = bigArrow;
                g.DrawLine(p, i * 150 - 50, 120, i * 150, 120);
                g.DrawLine(p, i * 150, 180, i * 150 - 50, 180);
            }


            String drawString = "i= " + i.ToString();


            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            float x = i * 150 + 30;
            float y = 120.0F;

            g.DrawString(drawString, drawFont, drawBrush, x, y);
            Thread.Sleep(1000);
        }

void desen2(int i)
        {
            g = this.CreateGraphics();
            Pen p = new Pen(Color.White, 1);
            Rectangle r = new Rectangle(i * 150, 100, 100, 100);
            g.DrawRectangle(p, r);
            if (i >= 1)
            {
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
                //  Pen p = new Pen(Color.Blue, 1);
                p.CustomEndCap = bigArrow;
                g.DrawLine(p, i * 150 - 50, 120, i * 150, 120);
                g.DrawLine(p, i * 150, 180, i * 150 - 50, 180);

            }

            String drawString = "i= " + i.ToString();


            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            float x = i * 150 + 30;
            float y = 120.0F;

            g.DrawString(drawString, drawFont, drawBrush, x, y);
            Thread.Sleep(1000);
        } - Acest cod a desenat inca odata recursivitatea, dar cu alb.

void afis(int i)
        {
            if (i <= 5)
            {
                desen1(i);
                afis(i + 1);
            }
            desen2(i);
        }

V. Teste pentru verificare de cunostinte
1. Test Radio
Am adus 5 butoane, un date time picker, un listbox, patru radioButtons, un comboBox si un groupBox.
Alegi tipul de test din listbox si apesi butonul de sub listbox. Alegi user-ul din combo box.
Apesi butonul care genereaza vectorul, apoi cu ajutorul butoanelor < si > alegi intrebarea. Dupa ce apesi raspunsul corect, iti verifici raspunsurile, rezultatul fiind salvat in database.
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

                nr--;
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
                fin.Close();
            }
        }

2. Test cu Check-uri
Am adus trei butoane, un date time picker, un listbox, patru checkbox-uri si un combobox.
Alegi tipul de test din listbox si apesi butonul de sub listbox. Alegi user-ul din combo box.
Primul buton afiseaza intrebarile, dupa care apesi checkbox-ul intrebarii care e adevarata. Apoi, iti verifici raspunsurile folosind al doilea buton, si rezultatul este salvat in database.

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

            if (checkBox1.Checked && vect[v[1]].raspuns == "da")
                nr++;
            if (checkBox2.Checked && vect[v[2]].raspuns == "da")
                nr++;
            if (checkBox3.Checked && vect[v[3]].raspuns == "da")
                nr++;
            if (checkBox4.Checked && vect[v[4]].raspuns == "da")
                nr++;

           MessageBox.Show(nr.ToString());
        }
    }

3. Itemi de Completare
Am adus trei butoane, un textbox, un date time picker, un listbox, patru checkbox-uri si un combobox.
Alegi tipul de test din listbox si apesi butonul de sub listbox. Alegi user-ul din combo box.
Scrii numarul de intrebari in textBox, dupa care vor aparea numarul de intrebari si textbox-uri langa ele unde poti scrie raspunsul. Dupa ce ai scris raspunsurile apasa butonul de verificare raspunsuri, iar rezultatul va fii salvat in database.
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

In fiecare form am folosit button1_MouseHover si button1_MouseLeave ca sa schimb culoarea butonului si label1_Click ca sa inchid forma si sa o deschid pe cea dinainte.
 private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            meniu f = new meniu();
            f.Show();
        }
private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.ForestGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LimeGreen;
        }

Pagina de start
Pe forma am adus 4 textbox-uri, doua butoane si doua checkbox-uri.
In textbox-uri sunt introduse username si password, care sunt apoi scrise intr-un fisier folosind butonul de inregistrare, Se poate folosi checkbox-ul ca sa se afiseze parola. Apoi, username-ul si parola sunt introduse in celelalte textbox-uri, iar user-ul se logheaza.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace proiectinfo
{
    public partial class pagina_start : Form
    {

        public pagina_start()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
                if (textBox2.Text == "" && textBox1.Text == "")
                {
                    MessageBox.Show("Te rog introdu datele");
                }
                else
                {
                    using (StreamWriter fout = File.AppendText("TextFile1.txt"))
                    {


                        fout.WriteLine(textBox2.Text + "/" + textBox1.Text);
                        textBox2.Text = "";
                        textBox1.PasswordChar = '*';
                        textBox1.Clear();
                        fout.Close();

                    }



                }


            }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ok = false;
            {
                if (textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Te rog introdu datele");
                }
                else
                {
                    using (StreamReader fin = new StreamReader("TextFile1.txt"))

                    {
                        while (!fin.EndOfStream)
                        {
                            string l = fin.ReadLine();
                            string[] v = l.Split('/');
                            if (String.Compare(textBox3.Text.Trim(), v[0].ToString().Trim()) == 0 && String.Compare(textBox4.Text.Trim(), v[1].ToString().Trim()) == 0)

                                ok = true;
                        }

                        if (ok == true)
                        {
                            meniu f = new meniu();
                            f.Show();
                        }
                        else
                            MessageBox.Show("creaza un cont");

                        fin.Close();

                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.PasswordChar = (char)0;

            }
            else
            {
                textBox1.PasswordChar = '*';


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = (char)0;
            }
            else
            {
                textBox4.PasswordChar = '*';

            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(236, 83, 59);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gold;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(236, 83, 59);
        }

        private void pagina_start_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.CENTER);
        }
    }
}
Am folosit o clasa ca sa adaug o animatie cand se deschide forma.
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace proiectinfo
{
    class WinAPI
    {
        public const int HOR_Positive = 0X1;
        public const int HOR_Negative = 0X2;
        public const int VER_Positive = 0X4;
        public const int VER_Negative = 0X8;
        public const int CENTER = 0X10;
        public const int BLEND = 0X80000;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hwand,int dwTime,int dwFlag);
    }
}
Sursa: https://www.youtube.com/watch?v=cJfRfagu7cw

