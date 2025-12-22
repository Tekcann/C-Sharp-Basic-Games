using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazı_Tura_oyunu
{
    public partial class Form1 : Form
    {
        Random rnd_para = new Random();//random değer üretimini sağlar

        //değişkenler oluşturulur
        string yazı_mı_tura_mı = "Boşta",para_donuyor = "Tura";
        int random_deger,para_donus_sayısı;
        bool tek_çalışma;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamayı kapatır
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();// zamanyıcıyı çalıştırır
            
            para_donuyor = "Tura";//değişkenin değerini değiştirir
            para_donus_sayısı = 0;//değişkenin değerini sıfır yapar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tek_çalışma == true)//değişkenini değerini konrol eden koşul
            {
                tek_çalışma = false;//değişkenin değerini yanlış olarak değiştirir
                timer2.Stop();//zamanlayıcıyı durdurur

                random_deger = rnd_para.Next(0, 2);// 0 = yazı, 1 = tura olsun

                if (random_deger == 0 && yazı_mı_tura_mı == "Yazı")//oyunucu doğru bildi
                {
                    pictureBox1.Image = Properties.Resources.yazi;//görseli değiştirir
                    MessageBox.Show("Tebrikler Kazandın");//ekrana yazı yazdırır

                }
                else if (random_deger == 0 && yazı_mı_tura_mı == "Tura")//oyuncu yanlış seçim yaptı
                {
                    pictureBox1.Image = Properties.Resources.yazi;
                    MessageBox.Show("Olamaz Yanlış Seçim Yaptın");

                }
                else if (random_deger == 1 && yazı_mı_tura_mı == "Yazı")//oyuncu yanlış seçim yaptı
                {
                    pictureBox1.Image = Properties.Resources.tura;
                    MessageBox.Show("Olamaz Yanlış Seçim Yaptın");

                }
                else if (random_deger == 1 && yazı_mı_tura_mı == "Tura")//oyuncu doğru seçim yaptı
                {
                    pictureBox1.Image = Properties.Resources.tura;
                    MessageBox.Show("Tebrikler Kazandın");

                } else if (random_deger == 0 || random_deger == 1 && yazı_mı_tura_mı == "Boşta")
                {
                    MessageBox.Show("Bir seçenek seçmeniz gerekiyor", "SEÇİM YAPP");
                }

            }
            else
            {
                timer1.Stop();//zamanlayıcıyı durdurur
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yazı_mı_tura_mı = "Yazı";//değişkenin değerini değiştirir
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Yazı ya da turadan birini seç ve parayı döndür.\n İyi oyunlar dilerim.","ÖĞRETİCİ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            yazı_mı_tura_mı = "Tura";//değişkenin değerini değiştirir
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (para_donus_sayısı > 15)//deşikenin değerini kontrol eden koşul
            {   //değişkenini değerini değiştirir
                para_donuyor = "Boşta";
                tek_çalışma = true;
                timer1.Start();//zamanlayıcı çalıştırır
                timer2.Stop();//zamanlayıcıyı durdurur
            }
            else if (para_donuyor == "Tura")
            {
                para_donuyor = "Yazı";
                pictureBox1.Image = Properties.Resources.yazi;
                para_donus_sayısı += 1;
                               
            }else if(para_donuyor == "Yazı")
            {
                para_donuyor = "Tura";
                pictureBox1.Image = Properties.Resources.tura;
                para_donus_sayısı += 1;

            }

        }
    }
}
