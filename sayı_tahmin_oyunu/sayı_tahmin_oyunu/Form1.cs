using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace sayı_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        //değişken oluşturur
        int sayı;
        bool exit = false;
       
        //ses dosyaları kullanılabilir hale getiir
        SoundPlayer Sezen_aksu = new SoundPlayer(Properties.Resources.Sezen_Aksu___Kaç_Yıl_Geçti_Aradan__Official_Audio_);
        SoundPlayer button_sound = new SoundPlayer(Properties.Resources.buttton_sound);
        SoundPlayer success = new SoundPlayer(Properties.Resources.succesful);
        SoundPlayer fail = new SoundPlayer(Properties.Resources.fail_trumpet);
        public Form1()
        {
            InitializeComponent();

           
           
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu oyunumuz bilgisayarın rasgele tutuğu bir sayıyı \n denemeler yaparak bulmayı amaçlar. \n İyi oyunlar Dilerim. :) \n Sezen Aksu sever misiniz? ", "Öğretici");
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

            button_sound.Play();//buton sesi çalar

            int girilen_sayı = Convert.ToInt32(textBox1.Text);//metin değişkenini ssayısal veriye dönüştürür
            if( sayı == girilen_sayı)//eğer girilen sayı doğru olma koluşu
            {
                //eğer cevap doğruysa bu kodlar çalışır
                success.Play();
                label2.Text = "Tebrikler doğru sayıyı buldun";
                label3.Text = "Seçilen sayı :" + sayı;
                MessageBox.Show("Tekrar oynamak için Start'a bas.");

            }else if(sayı > girilen_sayı)//tahminin küçük bir değer olması koşulu
            {
                fail.Play();//ses çalar
                label2.Text = "Tahmininden daha büyük";
            }else if(sayı < girilen_sayı)
            {
                fail.Play();//ses çalar
                label2.Text = "Tahmininden daha küçük";
            }
            else
            {   
                //hatalı giriş yapıldığında çıkar
                MessageBox.Show("Hatalı giriş yaptınız.Ayıp");
            }

            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            timer1.Stop();


        }
        private void button2_Click(object sender, EventArgs e)
        {
          //Start butonuna basıldığında çalışan kodlar
          //oyun tekrar başa dönmesi için gerekli değişiklikler yapılar
            button_sound.Play();

            label3.Text = " ";
            listBox1.Items.Clear();
            textBox1.Text = "";
           
            Random rnd = new Random();//random değer üretir
            sayı = rnd.Next(0, 61);
           
            label2.Text = "Random Bir Sayı Seçilmiştir.";
            timer1.Stop();//zamanlayıcıyı durdurur

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //oyundan çıkış işlemleri
            button_sound.Play();
            exit = true;

            if (exit == true)
            {
                System.Threading.Thread.Sleep(1500);
                Application.Exit();
            }

        }   
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MessageBox.Show("Oyuna geçemden önce ufak bir müzik molası iyi gelir. Başlamadan önce müziği durdurunuz. :)");
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //sezen aksu durur
            timer1.Interval = 1000;
            Sezen_aksu.Stop();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // sezen aksu çalar
            Sezen_aksu.Play();
            timer1.Interval = 1000 * 4 * 60 + 32 * 100;
        }
    }
}
