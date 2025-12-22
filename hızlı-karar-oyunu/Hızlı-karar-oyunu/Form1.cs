using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hızlı_karar_oyunu
{
    public partial class Form1 : Form
    {

        Random rnd_sayi = new Random();//random sayı üretme nesnesi oluşturur

        //değişkenler oluşturur
        int rnd_renk,skor;
        string gerekli_renk, oyunucu_sectigi_renk;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadan çıkış sağlar
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();//zamanlayıcıyı çalıştırır

            //değişkenleri sıfırlar
            
            skor = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rnd_renk = rnd_sayi.Next(0,6);//rasgele değer üretir

            //0. renk = Turuncu
            //1. renk = Mavi
            //2. renk = Kırmızı
            //3. renk = Sarı
            //4. renk = Mor
            //5. renk = Yeşil

            #region Rasgele Renk oluşturma ve ekrana yazma komutları

            if (rnd_renk == 0)//değişkenin 0 olması durumunda çalışır
            {
                label1.Text = "Turuncu";//label nesnesine turuncu yazdırır
                label1.ForeColor = Color.Orange;//metnin rengini turuncu yapar
                gerekli_renk = "Turuncu";//oyuncunun basması gereken butonun koşulunu turuncu yapar

                //aşağıda aynı mantık farklı kodlarla devam eder
            }else if( rnd_renk == 1)
            {
                label1.Text = "Mavi";
                label1.ForeColor = Color.CornflowerBlue;
                gerekli_renk = "Mavi";

            }else if(rnd_renk == 2)
            {
                label1.Text = "Kırmızı";
                label1.ForeColor = Color.Crimson;
                gerekli_renk = "Kırmızı";

            }else if(rnd_renk == 3)
            {
                label1.Text = "Sarı";
                label1.ForeColor = Color.Yellow;
                gerekli_renk = "Sarı";

            }else if(rnd_renk == 4)
            {
                label1.Text = "Mor";
                label1.ForeColor = Color.BlueViolet;
                gerekli_renk = "Mor";

            }else if(rnd_renk == 5)
            {
                label1.Text = "Yeşil";
                label1.ForeColor = Color.Lime;
                gerekli_renk = "Yeşil";
            }
            #endregion


            timer1.Interval -= skor * 3;//zamanlayıcının hızını değiştirir

            


        }

        #region Buton basılma durumları
        private void button4_Click(object sender, EventArgs e)
        {
            // butona basıldığında değişkenin değerini sarı yapar
            oyunucu_sectigi_renk = "Sarı";
            secimKontrol();//seçimi kontrol eden metot
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oyunucu_sectigi_renk = "Mavi";
            secimKontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oyunucu_sectigi_renk = "Kırmızı";
            secimKontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oyunucu_sectigi_renk = "Mor";
            secimKontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oyunucu_sectigi_renk = "Yeşil";
            secimKontrol();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu oyunun amacı: Ekranda yazan rengin butonuna basarak puan toplamaktır. \n farenin sol tıkı ile renklere basabilirsiniz. ","ÖĞRETİCİ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyunucu_sectigi_renk = "Turuncu";
            secimKontrol();
        }
        #endregion


        private void secimKontrol()
        {   //bilgisayarın rasgele karar verdiği renk ile oyuncunu seçtiği butonon
            //aynı olması durumunda çalışır
            if (gerekli_renk == oyunucu_sectigi_renk)
            {
                skor++;//skor 1 artar
                label2.Text = "Skor :" + skor.ToString();//label ın metnini değiştirir

            }
            else
            {
                timer1.Stop();//zamanlayıcıyı durdurur

                //ekrana yazı gösteriri
                MessageBox.Show("Ne Yazık ki Kaybettin", "KAYBETTTİNN!!!!!!");
                MessageBox.Show($"Skorun {skor}", "Genende İyi İlerledin");

            }
            
        }
    }
}
