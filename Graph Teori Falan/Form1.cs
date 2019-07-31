using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft;
using Microsoft.VisualBasic.PowerPacks;
using System.IO;

namespace Graph_Teori_Falan
{

    public partial class Form1 : Form
    {
        List<string> Düğümler = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private int DüğümSay = 0;
        private string DüğümAd = "D";

        ShapeContainer Tablo = new ShapeContainer();
        List<Button> Düğüm_Butonlar = new List<Button>();

        private void button1_Click(object sender, EventArgs e)
        {
          


            Button Düğüm = new Button();

            Düğüm.Text = DüğümAd.ToString() + DüğümSay.ToString();
            Size YazıGenişliği = TextRenderer.MeasureText(Düğüm.Text.ToString(), Düğüm.Font);
            Düğüm.Tag = DüğümAd.ToString() + DüğümSay.ToString();
            Düğüm.Font = ÖrnekDüğüm.Font;
            Düğüm.Size = new Size(YazıGenişliği.Width * 2, ÖrnekDüğüm.Height);
            Düğüm.Location = new Point(200, 60);
            Düğüm.FlatStyle = ÖrnekDüğüm.FlatStyle;
            Düğüm.BackColor = Color.White;
            Düğüm.MouseMove += move;
            Düğüm.MouseDown += down;
            Düğüm.KeyDown += key_sec;
            Düğüm.MouseLeave += up;
            Düğüm.Click += DüğümTık;
            Düğüm.ContextMenuStrip = SağTıkMenü;
            Controls.Add(Düğüm);
            Düğüm_Butonlar.Add(Düğüm);
            


            DüğümOluştur(Düğüm.Tag.ToString());
            DüğümSay += 1;

        }
        private void DüğümTık(object sender, EventArgs e)
        {
            if (Bağlanma_Modu)
            {

                Control Düğüm = sender as Control;
                Seçilen_Kontrol = Düğüm;
                Seçilen_Kontrol_Renk = Seçilen_Kontrol.BackColor;

                if (DüğümBağlıMı(Seçen_Kontrol.Tag.ToString(), Seçilen_Kontrol.Tag.ToString()))
                {

                    Işıkları_Söndür.Enabled = true;
                    Bağlanma_Modu = false;
                }
                else
                {


                    if (Seçilen_Kontrol != null && Seçen_Kontrol != null)
                    {


                        if (Seçilen_Kontrol.Tag.ToString() == Seçen_Kontrol.Tag.ToString())
                        {
                            MessageBox.Show("Kendi kendisini seçmek biraz garip olmaz mıydı?");

                        }
                        else
                        {

                            DüğümeEkle(Seçen_Kontrol.Tag.ToString(), Seçilen_Kontrol.Tag.ToString());
                            DüğümeEkle(Seçilen_Kontrol.Tag.ToString(), Seçen_Kontrol.Tag.ToString());
                            Seçilen_Kontrol.BackColor = Color.Aqua;

                            int Seçen_x = Seçen_Kontrol.Location.X;
                            int Seçen_y = Seçen_Kontrol.Location.Y;

                            int Seçilen_x = Seçilen_Kontrol.Location.X;
                            int Seçilen_y = Seçilen_Kontrol.Location.Y;

                            int Seçen_Width = Seçen_Kontrol.Width;
                            int Seçilen_Width = Seçilen_Kontrol.Width;

                            int Ortalama;
                            if (Seçen_Width < Seçilen_Width)
                            {
                                Ortalama = Convert.ToInt32(Seçen_Width / 2);
                            }
                            else
                            {
                                Ortalama = Convert.ToInt32(Seçilen_Width / 2);
                            }

                            int azaltılacak_yükseklik;
                            azaltılacak_yükseklik = Seçen_Kontrol.Height;
                            LineShape kenar = new LineShape();
                            kenar.BorderWidth = 2;
                            Random rastgele = new Random();
                            kenar.BorderColor = Color.FromArgb(rastgele.Next(0, 255), rastgele.Next(0, 255), rastgele.Next(0, 255));
                            kenar.Tag = Seçen_Kontrol.Tag.ToString() + Seçilen_Kontrol.Tag.ToString();

                            this.Controls.Add(Tablo);
                            kenar.Parent = Tablo;
                            kenar.ContextMenuStrip = KenarSağTık;
                            kenar.X1 = Seçen_x + Seçen_Kontrol.Width / 2;//Seçen_x+Ortalama;
                            kenar.X2 = Seçilen_x + Seçilen_Kontrol.Width / 2;// Seçilen_x+ Ortalama;
                            kenar.Y1 = Seçen_y + Seçen_Kontrol.Height / 2;//Seçen_y+azaltılacak_yükseklik;
                            kenar.Y2 = Seçilen_y + Seçilen_Kontrol.Height / 2;




                        }


                        Işıkları_Söndür.Enabled = true;
                        Bağlanma_Modu = false;
                    }

                }

            }
        }
        private Point Mouse_Down_Lokasyon;

        private void up(object sender,EventArgs e)
        {
            Bilgi2.Visible = false;
            Bilgi1.Visible = false;
        }

        private void move(object sender, MouseEventArgs e)
        {
            Button butoncuk = sender as Button;
            if (e.Button == MouseButtons.Left)
            {
                butoncuk.Left = e.X + butoncuk.Left - Mouse_Down_Lokasyon.X;
                butoncuk.Top = e.Y + butoncuk.Top - Mouse_Down_Lokasyon.Y;

                string DüğümAdı = butoncuk.Tag.ToString();
                ShapeContainer İlgiliKenarlar = new ShapeContainer();
                ShapeContainer YeniHepsi = new ShapeContainer();
                foreach (LineShape Kenar in Tablo.Shapes)
                {
                    if (Kenar.Tag.ToString().Contains(DüğümAdı))
                    {

                        string node1 = "D" + Kenar.Tag.ToString().Split('D')[1].ToString();
                        string node2 = "D" + Kenar.Tag.ToString().Split('D')[2].ToString();

                        if (DüğümAdı == node1)
                        {
                            try
                            {
                                // Sen seçensin
                                LineShape KenarcikMK = new LineShape(butoncuk.Location.X + Convert.ToInt32(butoncuk.Width / 2), butoncuk.Location.Y + Convert.ToInt32(butoncuk.Height / 2), Kenar.X2, Kenar.Y2);
                                
                                KenarcikMK.Tag = Kenar.Tag;
                                KenarcikMK.BorderColor = Kenar.BorderColor;
                                KenarcikMK.BorderWidth = Kenar.BorderWidth;
                               İlgiliKenarlar.Shapes.Add(KenarcikMK);
                            }
                            catch
                            {

                            }
                        }
                        else
                        {
                            try
                            {


                                LineShape KenarcikMK = new LineShape(Kenar.X1, Kenar.Y1, butoncuk.Location.X + Convert.ToInt32(butoncuk.Width / 2), butoncuk.Location.Y + Convert.ToInt32(butoncuk.Height / 2));
                                KenarcikMK.Tag = Kenar.Tag;

                                KenarcikMK.BorderColor = Kenar.BorderColor;
                                KenarcikMK.BorderWidth = Kenar.BorderWidth;

                               İlgiliKenarlar.Shapes.Add(KenarcikMK);
                                // Sen seçilensin
                            }
                            catch
                            {

                            }
                        }


                    }
                    else
                    {
                        // Eğer diğer kenarlar ise orjinal al
                        // Hiç kenarı olmayan düğüm
                        try
                        {
                            LineShape Orjinakenar = new LineShape(Kenar.X1, Kenar.Y1, Kenar.X2, Kenar.Y2);
                            Orjinakenar.Tag = Kenar.Tag;
                            Orjinakenar.BorderColor = Kenar.BorderColor;
                            Orjinakenar.BorderWidth = Kenar.BorderWidth;
                          
                            YeniHepsi.Shapes.Add(Orjinakenar);
                        }
                        catch
                        {

                        }
                    }
                }

                Tablo.Shapes.Clear();
                foreach (LineShape Kenar in YeniHepsi.Shapes)
                {
                    LineShape Orjinakenar = new LineShape(Kenar.X1, Kenar.Y1, Kenar.X2, Kenar.Y2);
                    Orjinakenar.Tag = Kenar.Tag;
                    Orjinakenar.BorderColor = Kenar.BorderColor;
                    Orjinakenar.BorderWidth = Kenar.BorderWidth;
                    Orjinakenar.ContextMenuStrip = KenarSağTık;
                  
                    Tablo.Shapes.Add(Orjinakenar);


                }
                foreach (LineShape Kenar in İlgiliKenarlar.Shapes)
                {
                    LineShape Orjinakenar = new LineShape(Kenar.X1, Kenar.Y1, Kenar.X2, Kenar.Y2);
                    Orjinakenar.Tag = Kenar.Tag;
                    Orjinakenar.BorderColor = Kenar.BorderColor;
                    Orjinakenar.BorderWidth = Kenar.BorderWidth;
                    Orjinakenar.ContextMenuStrip = KenarSağTık;
          
                    Tablo.Shapes.Add(Orjinakenar);
                }





            }
        }


        private void key_sec (object sender,KeyEventArgs e)
        {
             Seçen_Kontrol = sender as Button;
            
            if (e.KeyCode == Keys.R)
            {
                Random Rastgele = new Random();
                Color Renk = new Color();

                Renk = Color.FromArgb(Rastgele.Next(0, 255), Rastgele.Next(0, 255), Rastgele.Next(0, 255));
                Seçen_Kontrol.BackColor = Renk;
            }
            // yan bar 160 width
            // ust bar 30 height
            // alt bar 25 height

            Random rast = new Random();
            if (e.KeyCode == Keys.Space)
            {
                foreach (string d in Düğümler)
                {
                    string Dadı = d.Split(':')[0].ToString();
                    Button CurrentDüğüm = TagdenButonBul(Dadı);
                    


                    CurrentDüğüm.Location = new Point(rast.Next(180 + CurrentDüğüm.Width, this.Size.Width - 50- CurrentDüğüm.Width), rast.Next(60 + CurrentDüğüm.Height, this.Size.Height-60 - CurrentDüğüm.Height));


                }
                foreach (Shape bağ in Tablo.Shapes)
                {
                    LineShape kenar = bağ as LineShape;

                    string tag1 = "D" + bağ.Tag.ToString().Split('D')[1].ToString();
                    string tag2 = "D" + bağ.Tag.ToString().Split('D')[2].ToString();
                 
                    Button SEÇENK = TagdenButonBul(tag1);
                    Button SEÇİLENK = TagdenButonBul(tag2);


                    int Seçen_x = SEÇENK.Location.X;
                    int Seçen_y = SEÇENK.Location.Y;

                    int Seçilen_x = SEÇİLENK.Location.X;
                    int Seçilen_y = SEÇİLENK.Location.Y;

                    int Seçen_Width = SEÇENK.Width;
                    int Seçilen_Width = SEÇİLENK.Width;

                    int Ortalama;
                    if (Seçen_Width < Seçilen_Width)
                    {
                        Ortalama = Convert.ToInt32(Seçen_Width / 2);
                    }
                    else
                    {
                        Ortalama = Convert.ToInt32(Seçilen_Width / 2);
                    }


                    kenar.X1 = Seçen_x + SEÇENK.Width / 2;//Seçen_x+Ortalama;
                    kenar.X2 = Seçilen_x + SEÇİLENK.Width / 2;// Seçilen_x+ Ortalama;
                    kenar.Y1 = Seçen_y + SEÇENK.Height / 2;//Seçen_y+azaltılacak_yükseklik;
                    kenar.Y2 = Seçilen_y + SEÇİLENK.Height / 2;
                 

                }

            }
          
        }
       
        private void down(object sender, MouseEventArgs e)
        {
            Bilgi1Ver("R'ye basarak Düğüm'e rastgele bir renk verebilirsiniz!");
            Bilgi2Ver("Boşluk tuşuna basarak Düğümleri dağıtabilirsin!");
           
            if (e.Button == MouseButtons.Left)
            {
                Mouse_Down_Lokasyon =e.Location;
            }
            
        }

        private void Bilgi1Ver(string bilgi)
        {
            Bilgi1.Text = bilgi;
            Bilgi1.Visible = true;
      
        }
        private void Bilgi2Ver(string bilgi)
        {
            Bilgi2.Text = bilgi;
            Bilgi2.Visible = true;

        }


        private void düğümünAdınıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ToolStripItem geçerli_sağtık = sender as ToolStripItem;
            ContextMenuStrip Sahip = geçerli_sağtık.Owner as ContextMenuStrip;
            Control Düğüm = Sahip.SourceControl;

            GirdiAl VeriÇek = new GirdiAl();

            VeriÇek.Başlık = "Düğüm Adı";
            VeriÇek.LabelVeri = "Yeni düğüm adı:";

            if (VeriÇek.ShowDialog() == DialogResult.OK)
            {
                 
                Size Uzunluk = TextRenderer.MeasureText(VeriÇek.Veri, Düğüm.Font);
                if (Uzunluk.Width <= 0)
                {
                    Uzunluk.Width = 10;
                }
                if (Uzunluk.Height <= 0)
                {
                    Uzunluk.Height =5;
                }
                Düğüm.Text = VeriÇek.Veri;
                Düğüm.Size = new Size(Uzunluk.Width * 2, Düğüm.Height);

            }
            else
            {
                // İptal
            }

        }

        private void düğümüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ToolStripItem geçerli_sağtık = sender as ToolStripItem;
            ContextMenuStrip Sahip = geçerli_sağtık.Owner as ContextMenuStrip;
            Control Düğüm = Sahip.SourceControl;

            this.Controls.Remove(Düğüm);
            Bağlanma_Modu = false;
            DüğümSil(Düğüm.Tag.ToString());



        }

        // T1:A
        // T1:A,B
        // T1:A,B,C
        // T1:

        private void DüğümBağıSil(string DüğümAdı)
        {
            int say = 0;
            List<string> Prototip_Düğümler = new List<string>();
            Prototip_Düğümler.AddRange(Düğümler);

            foreach (string düğümcük in Düğümler)
            {
                try
                {
                    if (düğümcük.Split(':')[1].Contains(DüğümAdı))
                    {
                        Prototip_Düğümler[say] = Prototip_Düğümler[say].Split(':')[0].ToString() + ":" + Prototip_Düğümler[say].Split(':')[1].Replace(DüğümAdı, "").ToString();

                    }
                }
                catch
                {

                }
                say += 1;
            }




            Düğümler.Clear();
            Düğümler.AddRange(Prototip_Düğümler);
        }


        private void DüğümSil(string DüğümAdı)
        {
            int say = 0;
            foreach (string düğümcük in Düğümler)
            {
                try
                {
                    if (düğümcük.Split(':')[0] == DüğümAdı)
                    {
                        Düğümler.RemoveAt(say);
                        break;
                    }
                }
                catch
                {
                }
                say += 1;
            }

            say = 0;
            List<string> Prototip_Düğümler = new List<string>();
            Prototip_Düğümler.AddRange(Düğümler);

            foreach (string düğümcük in Düğümler)
            {
                try
                {
                    if (düğümcük.Split(':')[1].Contains(DüğümAdı))
                    {
                        Prototip_Düğümler[say] = Prototip_Düğümler[say].Split(':')[0].ToString() + ":" + Prototip_Düğümler[say].Split(':')[1].Replace(DüğümAdı, "").ToString();

                    }
                }
                catch
                {

                }
                say += 1;
            }




            Düğümler.Clear();
            Düğümler.AddRange(Prototip_Düğümler);


            ShapeContainer Silinmeyecekler = new ShapeContainer();
            foreach (LineShape Çizgi in Tablo.Shapes)
            {
                if (Çizgi.Tag.ToString().Contains(DüğümAdı))
                {

                }
                else
                {

                    LineShape Hassiktir = new LineShape(Çizgi.X1, Çizgi.Y1, Çizgi.X2, Çizgi.Y2);
                    Hassiktir.BorderWidth = Çizgi.BorderWidth;
                    Hassiktir.Tag = Çizgi.Tag;
                    Hassiktir.BorderColor = Çizgi.BorderColor;
                    Silinmeyecekler.Shapes.Add(Hassiktir);
                }

            }

            Tablo.Shapes.Clear();
            foreach (LineShape Çizgi in Silinmeyecekler.Shapes)
            {

                LineShape Dream = new LineShape(Çizgi.X1, Çizgi.Y1, Çizgi.X2, Çizgi.Y2);
                Dream.Tag = Çizgi.Tag;
                Dream.BorderWidth = Çizgi.BorderWidth;
                Dream.BorderColor = Çizgi.BorderColor;
                Dream.ContextMenuStrip = KenarSağTık;
                Tablo.Shapes.Add(Dream);
            }

        }



        private void DüğümOluştur(string DüğümAdı)
        {
            Düğümler.Add(DüğümAdı + ":");
        }
        private bool DüğümBağlıMı(string AnaDüğüm, string BağlanacakOlanDüğüm)
        {
            foreach (LineShape Kenar in Tablo.Shapes)
            {

                if (Kenar.Tag.ToString().Contains(AnaDüğüm) && Kenar.Tag.ToString().Contains(BağlanacakOlanDüğüm))
                {
                    return true;
                }

            }
            return false;
        }

        private bool DüğümVarMı(string DüğümAdı)
        {
            bool var_mi = false;
            foreach (string düğümcük in Düğümler)
            {
                try
                {
                    if (düğümcük.Split(':')[0] == DüğümAdı)
                    {
                        var_mi = true;
                    }
                }
                catch
                {
                }
            }
            if (var_mi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool DüğümDeVarMı(string EklenecekDüğümAdı, string EklenenDüğümAdı)
        {
            bool var_mi = false;
            int say = 0;
            foreach (string düğümcük in Düğümler)
            {
                try
                {
                    if (düğümcük.Split(':')[0] == EklenecekDüğümAdı && düğümcük.Split(':')[1].Contains(EklenenDüğümAdı))
                    {
                        var_mi = true;
                        break;
                    }

                }
                catch
                {

                }
                say += 1;
            }
            return var_mi;
        }
        private void DüğümeEkle(string EklenecekDüğümAdı, string EklenenDüğümAdı)
        {
            if (DüğümVarMı(EklenecekDüğümAdı))
            {
                if (DüğümDeVarMı(EklenecekDüğümAdı, EklenenDüğümAdı))
                {
                    // Ekleme
                }
                else
                {
                    int say = 0;
                    foreach (string düğümcük in Düğümler)
                    {
                        try
                        {
                            if (düğümcük.Split(':')[0] == EklenecekDüğümAdı)
                            {
                                break;
                            }
                        }
                        catch
                        {
                        }
                        say += 1;
                    }

                    Düğümler[say] = Düğümler[say] + EklenenDüğümAdı.ToString();
                }

            }
            else
            {
                DüğümOluştur(EklenecekDüğümAdı);
                DüğümeEkle(EklenecekDüğümAdı, EklenenDüğümAdı);
            }

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string eleman in Düğümler)
            {
                listBox1.Items.Add(eleman);
            }
        }

        private bool Bağlanma_Modu = false;
        private Control Seçen_Kontrol;
        private Color Seçen_Kontrol_Renk;
        private Control Seçilen_Kontrol;
        private Color Seçilen_Kontrol_Renk;
        private void düğümüBağlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bağlanma_Modu)
            {

            }
            else
            {
                Bağlanma_Modu = true;
                ToolStripItem geçerli_sağtık = sender as ToolStripItem;
                ContextMenuStrip Sahip = geçerli_sağtık.Owner as ContextMenuStrip;
                Control Düğüm = Sahip.SourceControl;
                Seçen_Kontrol = Düğüm;

                Seçen_Kontrol_Renk = Düğüm.BackColor;
                Seçen_Kontrol.BackColor = Color.Aqua;
                //   MessageBox.Show("Lütfen bağlamak istediğiniz düğümü seçiniz!");
            }

        }

        private void Işıkları_Söndür_Tick(object sender, EventArgs e)
        {

            try
            {

                Işıkları_Söndür.Enabled = false;
                Seçen_Kontrol.BackColor = Seçen_Kontrol_Renk;
                Seçilen_Kontrol.BackColor = Seçilen_Kontrol_Renk;
                Seçen_Kontrol = null;
                Seçilen_Kontrol = null;
            }
            catch
            {
                try
                {
                    Işıkları_Söndür.Enabled = false;
                    Seçen_Kontrol.BackColor = Seçen_Kontrol_Renk;
                    Seçen_Kontrol = null;
                    Seçilen_Kontrol = null;
                }
                catch
                {
                    try
                    {
                        Işıkları_Söndür.Enabled = false;
                        Seçilen_Kontrol.BackColor = Seçilen_Kontrol_Renk; ;
                        Seçen_Kontrol = null;
                        Seçilen_Kontrol = null;
                    }
                    catch
                    {

                    }
                }
            }

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            ToolStripItem geçerli_sağtık = sender as ToolStripItem;
           ContextMenuStrip Sahip = geçerli_sağtık.Owner as ContextMenuStrip;
            ShapeContainer ÜstSahip = Sahip.SourceControl as ShapeContainer;
            LineShape altolay  = ÜstSahip.Shapes.get_Item(0) as LineShape;
            string node1 = "D"+altolay.Tag.ToString().Split('D')[1].ToString();
            // d 0 d1
            string node2 = "D" + altolay.Tag.ToString().Split('D')[2].ToString();
            DüğümBağıSil(node1);
            DüğümBağıSil(node2);
            ÜstSahip.Shapes.Remove(altolay);
        */

            // UYKUSUZLUKTAN YAPAMADIM

        }

        List<string> Düğümlerin_Frekansı = new List<string>();
        private void renklendirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           


            // Welsch Pawell
            // Adım 1 Düğümleri bul
            //Düğümler_Ojbe
            // Adım 2 Düğümlerin frekanslarını bul
            Düğümlerin_Frekansı.Clear();
            foreach (string Düğümcük in Düğümler)
            {
                int say = 0;
                foreach (char harf in Düğümcük.Split(':')[1].ToString())
                {
                    if (harf == 'D')
                    {
                        say += 1;
                    }
                }
                Düğümlerin_Frekansı.Add(Düğümcük.Split(':')[0].ToString() + ":" + say.ToString());
            }
            //D0:1
            //D1:2 VS HEPSİ OOKEY
            ITERASYON_HEDEFI_KOYULDU:

            // Adım 3 Düğümleri frekanslarıyla birlikte büyükten küçüğe sırala
            List<string> Proto = new List<string>();
            List<int> Freqler = new List<int>();
            foreach (string Eleman in Düğümlerin_Frekansı)
            {
                Freqler.Add(Convert.ToInt32(Eleman.Split(':')[1].ToString()));
            }
            Freqler.Sort();
            foreach (int frekans in Freqler)
            {
         
                foreach (string eleman in Düğümlerin_Frekansı)
                {
                    if (eleman.Split(':')[1] == frekans.ToString())
                    {
                        Proto.Add(eleman);
                   

                    }
                }

            }
            List<string> annenartık = new List<string>();
            annenartık.AddRange(Proto.Distinct());
            Düğümlerin_Frekansı.Clear();
            Düğümlerin_Frekansı.AddRange(annenartık.Reverse<string>());

            // Düğümlerin_Frekansı büyükten küçüğe dizildi
           //**
            // Büyükten küçüpe dizdikten sonra
            // Büyükten küçüğe doğru ilerle,
            // renk olayı




            List<Color> Renkler = new List<Color>();
            Renkler.Clear();


            //Olay şu şekilde
            //Her bir Q = düğüm için konuşacağım
            //A(for zaten)
            // ilk düğüm ise rastgele bir renk ver,ve listeye ekle.
            // ilk düğüm değil ise
            //      //  renk listesini klonla
            //      //  düğümün komşularının renklerini klon listeden çıkar
            //      //  eğer listede hiç renk kalmazsa yeni renk ver düğüme,ve rengi listeye ekle
            //      //  eğer listede bir renk kalırsa direk o rengi ver
            //      //  eğer listede birden fazla renk kalırsa rastgele bir renk ver
            //A'Ya git
            // NOT KOMŞUSUZ DÜĞÜM VARSA,RENKLENDİRME İPTAL!

            bool ilk_düğüm_olayı = true;
            foreach (string DÜĞÜM in Düğümlerin_Frekansı)
            {
                Random RastÜreteç = new Random();
                string DÜĞÜM_ADI = DÜĞÜM.Split(':')[0].Trim().ToString();
                int KOMŞU_SAYISI = Convert.ToInt32(DÜĞÜM.Split(':')[1].Trim().ToString());
                if (ilk_düğüm_olayı)
                {
                    Color RRENK = new Color();
                    RRENK = Color.FromArgb(RastÜreteç.Next(0, 255), RastÜreteç.Next(0, 255), RastÜreteç.Next(0, 255));
                    TagdenButonBul(DÜĞÜM_ADI).BackColor = RRENK;
                    Renkler.Add(RRENK);
                    ilk_düğüm_olayı = false;
                }
                else
                {
                    List<Color> KlonListe = new List<Color>();
                    KlonListe.Clear();//batıl inanç :)
                    KlonListe = Renkler.ToList(); // Kopyalama metodu gibi düşün,basit ama etkili
                   
                    foreach (string itemcik in BağıOlanDüğümleriBul(DÜĞÜM_ADI))
                    {

                        string asıl_tag = "D" + itemcik;
                        
                        foreach (Color renkcik in Renkler)
                        {
                            if (renkcik == TagdenButonBul(asıl_tag).BackColor)
                            {
                                KlonListe.Remove(renkcik);
                            }
                        }


                        if (KlonListe.Count == 0)
                        {
                            Color RRENK = new Color();
                            RRENK = Color.FromArgb(RastÜreteç.Next(0, 255), RastÜreteç.Next(0, 255), RastÜreteç.Next(0, 255));
                            TagdenButonBul(DÜĞÜM_ADI).BackColor = RRENK;
                            Renkler.Add(RRENK);
                        }
                        else if (KlonListe.Count == 1)
                        {
                            TagdenButonBul(DÜĞÜM_ADI).BackColor = KlonListe[0];
                        }
                        else if (KlonListe.Count > 1)
                        {
                            TagdenButonBul(DÜĞÜM_ADI).BackColor = KlonListe[RastÜreteç.Next(0, KlonListe.Count)];
                        }
                       
                    }

                   
                }
             


            }

           

            if (iterasyon_hedefi)
            {
               
                if (iterbar.Value >= 99)
                {
                    MessageBox.Show("100 kere itere ettik fakat zaman aşımına uğradı!");
                    iterasyon_hedefi = false;
                    itere.BackColor = Color.LightGray;
                    iterbar.Value = 0;
                    goto BİTER;
                }
                if (Renkler.Count == iterasyon_hedefi_numerik)
                {
                    
                    MessageBox.Show("İterasyon Hedefine Ulaşıldı!");
                    iterasyon_hedefi = false;
                    itere.BackColor = Color.LightGray;

                }
                else
                {
                    iterbar.Value += 1;
                    goto ITERASYON_HEDEFI_KOYULDU;
                }
                this.Refresh();
                BİTER:;
            }



            //MessageBox.Show("Toplam " + Renkler.Count.ToString() + " adet renk kullanıldı!");
            //MessageBox.Show(string.Join("#", Renkler.ToArray()));


        }


        private List<string> BağıOlanDüğümleriBul(string düğümAdı)
        {
            List<string> seni_her_gördüğümde = new List<string>();
            foreach (string olay in Düğümler)
            {
                if (düğümAdı == olay.Split(':')[0].ToString())
                {
                    seni_her_gördüğümde.Clear();
                    seni_her_gördüğümde.AddRange(olay.Split(':')[1].Split('D').ToList());
                }

            }
            seni_her_gördüğümde.RemoveAll(string.IsNullOrEmpty);
            return seni_her_gördüğümde;

        }

        private Button TagdenButonBul(string tagcik)
        {
          
            foreach (Control düğmecik in this.Controls)
            {

                try
                {
                    if (düğmecik.Tag.ToString() == tagcik)
                    {
                        return düğmecik as Button;

                    }
                }
                catch
                {

                }
            }

            return null;
        }
        private void listBox2_Click(object sender, EventArgs e)
        {


            try
            {
                listBox2.Items.Clear();

                foreach (string düğümobj in Düğümlerin_Frekansı)
                {
                    listBox2.Items.Add(düğümobj.ToString());

                }

            }
            catch
            {

            }
        }

        private void listBox1_SizeChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string eleman in Düğümler)
            {
                listBox1.Items.Add(eleman);
            }
        }

        private void düğümeRenkVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem geçerli_sağtık = sender as ToolStripItem;
            ContextMenuStrip Sahip = geçerli_sağtık.Owner as ContextMenuStrip;
            Control Düğüm = Sahip.SourceControl;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Düğüm.BackColor = colorDialog1.Color;
            }
        }

        private void düğümreRastgeleRenkVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem geçerli_sağtık = sender as ToolStripItem;
            ContextMenuStrip Sahip = geçerli_sağtık.Owner as ContextMenuStrip;
            Control Düğüm = Sahip.SourceControl;
            Random Rastgele = new Random();
            Color Renkcik = new Color();
            Renkcik = Color.FromArgb(Rastgele.Next(0, 255), Rastgele.Next(0, 255), Rastgele.Next(0, 255));
            Düğüm.BackColor = Renkcik;
        }

       

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Düğümler.Clear();
            Düğümlerin_Frekansı.Clear();
            Tablo.Shapes.Clear();
            
            foreach (Button eleman in Düğüm_Butonlar)
            {
                this.Controls.Remove(eleman);
            }

            Düğüm_Butonlar.Clear();

            DüğümSay = 0;
            DüğümAd = "D";



        }

        bool iterasyon_hedefi = false;
        int iterasyon_hedefi_numerik = 0;
        private void iterasyonBelirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int iterasyon_kaç = Convert.ToInt32(itere.Text.ToString());
                iterasyon_hedefi_numerik = iterasyon_kaç;
                iterasyon_hedefi = true;
                itere.BackColor = Color.Green;
            }
            catch
            {
                itere.Text = "1";
                int iterasyon_kaç = Convert.ToInt32(itere.Text.ToString());
                iterasyon_hedefi_numerik = iterasyon_kaç;
                iterasyon_hedefi = true;
                itere.BackColor = Color.Green;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Düğümlerin lokasyonlarını bul
            //Düğümlerin renklerini bul
            //Düğümlerin isimlerini bul
            //Çizgilerin lokasyonlarını bul
            //Çizgilerin renklerini bul
            //Komşuları çıkart ve geri als

            string TamVeri="";
            List<string> Düğümlerin_Lokasyonları = new List<string>();
            List<Color> Düğümlerin_Renkleri = new List<Color>();
            List<string> Düğümlerin_İsimleri = new List<string>();
            List<string> Kenarların_Lokasyonları = new List<string>();
            List<Color> Kenarların_Renkleri = new List<Color>();
            List<string> Komşular_Elbette = new List<string>();
            
            foreach(string düğümcük in Düğümler)
            {
                string DüğümCük;
                if (düğümcük.Contains(":"))
                {
                    DüğümCük = düğümcük.Split(':')[0].Trim().ToString();
                }
                else
                {
                    DüğümCük = düğümcük;
                }

                Düğümlerin_Lokasyonları.Add(TagdenButonBul(DüğümCük).Location.ToString());
                Düğümlerin_Renkleri.Add(TagdenButonBul(DüğümCük).BackColor);
                Düğümlerin_İsimleri.Add(TagdenButonBul(DüğümCük).Text.ToString());
                Komşular_Elbette.Add(düğümcük);

            }

            foreach (LineShape Kenar in Tablo.Shapes)
            {
                Kenarların_Lokasyonları.Add(Kenar.X1.ToString() + "," + Kenar.X2.ToString() + "," + Kenar.Y1.ToString() + "," + Kenar.Y2.ToString());
                Kenarların_Renkleri.Add(Kenar.BorderColor);

            }
            //Düğümlerin lokasyonlarını bul
            //Düğümlerin renklerini bul
            //Düğümlerin isimlerini bul
            //Çizgilerin lokasyonlarını bul ;
            //Çizgilerin renklerini bul
            TamVeri = string.Join(",", Düğümlerin_Lokasyonları.ToArray()) + Environment.NewLine + string.Join(",", Düğümlerin_Renkleri.ToArray()) + Environment.NewLine + string.Join(",", Düğümlerin_İsimleri.ToArray()) + Environment.NewLine + string.Join(";", Kenarların_Lokasyonları.ToArray()) + Environment.NewLine + string.Join(",", Kenarların_Renkleri.ToArray()) + Environment.NewLine + string.Join(",", Komşular_Elbette.ToArray());


            saveFileDialog1.Filter = "Beyoğlu Gazoz | *.bğ";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Yazmacalar = new StreamWriter(saveFileDialog1.OpenFile());
                Yazmacalar.WriteLine(TamVeri);
                Yazmacalar.Dispose();
                Yazmacalar.Close();
            }

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // başka bir gün

        }
    }


}

