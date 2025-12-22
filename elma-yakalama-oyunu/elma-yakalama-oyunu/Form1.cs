using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace elma_yakalama_oyunu
{
    public partial class Form1 : Form
    {
        int basketX, basketY, speed = 5, inisYeri, skor, kaybetmek, gravity;
        int appleY, appleX;

        SoundPlayer backSound = new SoundPlayer(Properties.Resources.mixkit_dancing_fit_45);
        private void buttonEXİT_Click(object sender, EventArgs e)
        {
            Application.Exit();//çıkıs yapmak için kullanılır
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            timer1.Start();//zamanlayıcıyı çalıştırır
            //Butonları görünmez yapar
            buttonEXİT.Visible = false;
            buttonSTART.Visible = false;
            

            //form uygulamasında buton kullınıyor ise program klavye tuplarından veri almaz
            //bu sebeple butona basıldığında KeyPrewiew komutu ile kavleyi kullanılabilir yapıyoruz
            //ActiveControl ile de buton kontrolünü devre dışı bırakıyoruz
            this.KeyPreview = true;
            this.ActiveControl = null;

            //oyun başında değiken değerleri sıfırlanır
            kaybetmek = 0;
            skor = 0;
            gravity = 5;

            backSound.Play();


        }

        PictureBox apple = new PictureBox(); // elma diye bir PictureBox oluşturur
       
        Random rnd = new Random();// random değer üretimini sağlar
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;// görüntünğn daha net olması sağlar
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // elmayı form penceresinde olup olmadığını kontrol eder 
            //bu koşul oyuncunun elmayı yakalamama durumunda çalışır
            if(appleY > this.ClientSize.Height)
            {
                //elmanı oluşma yarini random şekilde belirler
                inisYeri = rnd.Next(50, this.ClientSize.Width - 60);
                appleY = 0;// elmanın Y konumunu 0 yapar
                kaybetmek += 1;// üç hakkından biri gider

            }
            // elmanın sepet ie temas ettiğini kontrol eder
            if (pictureBoxBasket.Bounds.IntersectsWith(apple.Bounds))
            {
                skor += 1;//skor değişkenini bir arttırır

                //elmanın oluşma yerini random şekilde belirler
                inisYeri = rnd.Next(50, this.ClientSize.Width - 60);

                appleY = 0;//elmanın Y konumunu 0 yapar

                // zamanla elmanın hızlanmasını durduran koşul
                if (gravity < 10)
                {
                    gravity += skor;//yerçekimini hızlandırır
                    speed += skor;//sepetin hızını arttırır
                }
                

            }
            // elmanın yere düşme sayısı 3 olunca çalışan koşul
            if (kaybetmek == 3)
            {
                timer1.Stop();//zamanlayıcıyı durdurur

                //ekranda metin gösterir
                MessageBox.Show("Olsun Herkesin Her şeye Yeteneği Yoktur.", "KAYBETTİN ");

                //butonları ekranda gösteririr
                buttonSTART.Visible = true;
                buttonEXİT.Visible = true;
                
            }
            appleY += gravity;//elmanın düşmesini sağlar
            appleX = inisYeri;// elmanın hangi yerden düşeceğini belirler

            label1.Text = "Skor : " + skor.ToString();// ekranda skoru gösteririr

            apple.Location = new Point(appleX, appleY);// elmanın yeni konuunu belirler

           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu oyunun amacı: Yukarıdan düşen elmaları, sepeti kontrol ederek yakalamaktır. \n Sağ ve sol yön tuşları ile hareket edebilirsiniz. ","ÖĞRETİCİ");


            #region elma
            apple.Name = "elma";// elma PictureBox ına isim verir
            this.Controls.Add(apple);// pictureBox u sahede gösteririr
            apple.Size = new Size(60, 60);// boyunutu 60 x 80 pixel yapar
            apple.SizeMode = PictureBoxSizeMode.StretchImage;// pictureBox ın SizeModudunu değiştirir
            
            //değişkenlere picturebox ın konumu yerleştirir
            appleY = apple.Location.Y;
            appleX = apple.Location.X;

            apple.Image = Properties.Resources.apple;// göreseli değiştirir
            #endregion         


            //değişlernlere piturebox ın konumu yerleştirir
            basketX = pictureBoxBasket.Location.X;
            basketY = pictureBoxBasket.Location.Y;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Left)// sol ok tuşuna basılma koşulu
            {
                basketX -= speed;// sepeti sola doğru hareket ettirir
                
            }else if(e.KeyCode == Keys.Right)// sağ ok tuşuna basıldımı
            {
                basketX += speed;
            }
           
            pictureBoxBasket.Location = new Point(basketX, basketY);//sepeti yeni konuma yerleştirir
        }
    }
}
