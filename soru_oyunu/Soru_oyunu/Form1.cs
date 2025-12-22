using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru_oyunu
{
    public partial class Form1 : Form
    {

        int puan, time = 60, soru = 0;

        // iki boyutlu bir değişken oluşturup soruları içerisine kaydediyoruz.
        string[,] sorular =
        {     //  soru       A şıkkı - B şıkkı -        C şıkkı
            {"1) Nasılsınız?","İyi", "Fena değil", "Sana 100 vereceğim" },//Bu sorunun index'si 0,1 dir. // doğru cevap C şıkkı.
            {"2) Türkiye Cumhuriyeti'nin başkenti hangi ildir?", "Bursa", "İstanbul", "Ankara" },//Doğru cevap C şıkkı
            {"3) 5 makine, 5 dakikada, 5 düğme yapıyorsa, 100 makine, 100 düğmeyi \n kaç dakikada yapar?","100 dakika","5 dakika","Mesaiye kalırlar" },//Doğru cevap B şıkkı.
            {"4) Bir yarışta ikinci geçildiği zaman kaçıncı olunur?", "İkinci", "Birinci","Pekte bir şey olmaz" },//Doğru cevap A şıkkı.
            {"5) Atatürk hangi yılda doğmuştur?", "1881", "1938", "1923" },//Doğru cevap A şıkkı.
            {"6) Aşağıdaki değişkenlerden hangisi \n sayısal verileri kaydetmek için kullanılır?","integer", "string", "boolean"  },//Doğru cevap A şıkkı.
            {"7) Aşağıdakilerden hagisi bir döngü komutu değildir?","while", "for", "Switch-case" },//Doğru cevap C şıkkı.
            {"8) Hangi seçenek bir metot değildir?","Application.Exit()", "label1.Text", "timer1.Start()" },//Doğru cevap B şıkkı
            {"9) Aşağıdakilerden hangisi nesne \n yönelimli bir yazlım dilidir? ", "C", "C#", "Fortran" },//Doğru cevap B şıkkı.
            {"10) Bir fonksiyonun önceki çağrılarının sonuçlarını saklayarak sonraki çağrıları \n hızlandırmasını sağlayan teknik hangisidir?","Memoization", "Recursion", "Serialization" },//Doğru cevap A şıkkı.

            //Sorular bu şeklde ilerliyor.
            //1. soru 0,0
            //2. soru 1,0
            //3. soru 2,0
        };

        
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            soru = 1; // birinci sorudan başlatır.
            timer1.Start(); // sayacı başlatır.
           

            A_choice.Enabled = true;// butonları etkinleştirir.
            B_choice.Enabled = true;
            C_choice.Enabled = true;




        }
        private void button1_Click(object sender, EventArgs e)
        {
            time = 61;//değişkenin değeri değiştirir

            if (soru == 1)//diğer koşullar yanlış cevapta çalışır
            {
                puan += 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 2)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 3)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if(soru == 4)//Doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }else if (soru == 5)//Doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }else if (soru == 6)//Doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 7)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 8)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 9)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 10)//doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }



            soru++;//değişkenin değerini bir attırır
        }
        private void B_choice_Click(object sender, EventArgs e)
        {
            time = 61;//değişkenin değeri değiştirir

            if (soru == 1)//diğer koşullar yanlış cevapta çalışır
            {
                puan += 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 2)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if(soru == 3)// doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }else if (soru == 4)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 5)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 6)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 7)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 8)//Doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 9)// Doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 10)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }



            soru++;//değişkenin değerini bir attırır

        }
        private void C_choice_Click(object sender, EventArgs e)
        {
            time = 61;//değişkenin değeri değiştirir

            if (soru == 1)// doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }else if(soru == 2)// doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }else if(soru == 3)//diğer koşullar yanlış cevapta çalışır
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 4)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 5)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }else if (soru == 6)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 7)// doğru cevap
            {
                puan += 10;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 8)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 9)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }
            else if (soru == 10)
            {
                puan -= 5;
                label1.Text = "Puan : " + puan;

            }


            soru++;//değişkenin değerini bir attırır
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (soru == 1)// Birinci soruyu ve şıkları ekrana iletir.
            {
                Question.Text = sorular[0, 0];//soruların indexleri
                A_choice.Text = sorular[0, 1];//A şıkları
                B_choice.Text = sorular[0, 2];//B şıkları
                C_choice.Text = sorular[0, 3];//C şıkları

            }
            else if (soru == 2)
            {
                Question.Text = sorular[1, 0];
                A_choice.Text = sorular[1, 1];
                B_choice.Text = sorular[1, 2];
                C_choice.Text = sorular[1, 3];

            }
            else if (soru == 3)
            {
                Question.Text = sorular[2, 0];
                A_choice.Text = sorular[2, 1];
                B_choice.Text = sorular[2, 2];
                C_choice.Text = sorular[2, 3];

            }
            else if (soru == 4)
            {
                Question.Text = sorular[3, 0];
                A_choice.Text = sorular[3, 1];
                B_choice.Text = sorular[3, 2];
                C_choice.Text = sorular[3, 3];

            }
            else if (soru == 5)
            {
                Question.Text = sorular[4, 0];
                A_choice.Text = sorular[4, 1];
                B_choice.Text = sorular[4, 2];
                C_choice.Text = sorular[4, 3];

            }else if (soru == 6)
            {
                Question.Text = sorular[5, 0];
                A_choice.Text = sorular[5, 1];
                B_choice.Text = sorular[5, 2];
                C_choice.Text = sorular[5, 3];

            }else if (soru == 7)
            {
                Question.Text = sorular[6, 0];
                A_choice.Text = sorular[6, 1];
                B_choice.Text = sorular[6, 2];
                C_choice.Text = sorular[6, 3];

            }else if (soru == 8)
            {
                Question.Text = sorular[7, 0];
                A_choice.Text = sorular[7, 1];
                B_choice.Text = sorular[7, 2];
                C_choice.Text = sorular[7, 3];

            }else if (soru == 9)
            {
                Question.Text = sorular[8, 0];
                A_choice.Text = sorular[8, 1];
                B_choice.Text = sorular[8, 2];
                C_choice.Text = sorular[8, 3];

            }else if (soru == 10)
            {
                Question.Text = sorular[9, 0];
                A_choice.Text = sorular[9, 1];
                B_choice.Text = sorular[9, 2];
                C_choice.Text = sorular[9, 3];

            }else if(soru == 11)// terkar oynayabilmek için gerekli hazırlıklar
            {
                timer1.Stop();//zamanlayıcıyı durdurur
                timer2.Stop();

                MessageBox.Show("Tebrikler bütün soruları cevapladınız. Puanınız :" + puan);
                
                Question.Text = "Sorulara hazır mısınız?";
                A_choice.Text = "A şıkkı";
                B_choice.Text = "B şıkkı";
                C_choice.Text = "C şıkkı";

                A_choice.Enabled = false;
                B_choice.Enabled = false;
                C_choice.Enabled = false;
            }


            
        }

        private void Question_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Bu oyunun amacı: ekranda yazan sorulara doğru cevap vermektir. \n Üç seçenekten doğru cevabı seçerek en yüksek puanı almaya çalışınız. ","ÖĞRETİCİ");

            timer2.Start(); // sayacı başlatır.

            //oyunun başlangiç hazırlıkları.
            Question.Text = "Sorulara hazır mısınız?";
            A_choice.Text = "A şıkkı";
            B_choice.Text = "B şıkkı";
            C_choice.Text = "C şıkkı";

            A_choice.Enabled = false;
            B_choice.Enabled = false;
            C_choice.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;//zamanı eksiltir
            if (time == 0)//değişkenin sıfır olma koşulu
                //ekranda metin görünür
                MessageBox.Show("Süre bitti kaybettiniz. :(");
            label2.Text = "Süre : " + time.ToString();
        }

        

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadan çıkar
        }
    }
}
