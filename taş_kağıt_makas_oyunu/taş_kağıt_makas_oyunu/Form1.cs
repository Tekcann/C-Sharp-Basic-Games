using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace taş_kağıt_makas_oyunu
{
    public partial class Form1 : Form
    {
        //değişkenler oluşturulur
        int counter = 3;        
        string player_choose, computer_choose;

        int oyuncu_kaç_kez_kazandı=0, bilgisayar_kaç_kez_kazandı=0;

        #region Ses Başlatıcı Kodlar
        SoundPlayer button_sound = new SoundPlayer(Properties.Resources.buttton_sound);
        SoundPlayer winner_sound = new SoundPlayer(Properties.Resources.succesful);
        SoundPlayer lose_sound = new SoundPlayer(Properties.Resources.fail_trumpet);
        #endregion
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1100;//zamanlayıcının tekrarının değiştirir
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player_choose = "kağıt";//değişkenin değerini değiştirir
            pictureChoose.Image = Properties.Resources.paper;//göreli değiştirir
            button_sound.Play();//ses çalar
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player_choose = "taş";//değişkenin değerini değiştirir
            pictureChoose.Image = Properties.Resources.rock;//göreli değiştirir
            button_sound.Play();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player_choose = "makas";//değişkenin değerini değiştirir
            pictureChoose.Image = Properties.Resources.scissors;//göreli değiştirir
            button_sound.Play();//ses çalar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_sound.Play();//ses çalar
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Oyun başlıyor seçimni yap";
            button_sound.Play();//ses çalar

            timer1.Start();//Zamanlayıcı çalıştırır.
            pictureChoose.Image = null;
            pictureComputer.Image = null;
            player_choose = null;

            

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Start butonunu kullanılmaz hale getiren kod.
            Start.Enabled = false;

            #region Geriye Sayım ve Diğer Bir Çok Şey
            if (counter == 3)//değişkenin eşit olma koşulu

            {
                pictureCounter1.Image = Properties.Resources.three;//görseli değiştirir
                pictureCounter2.Image = Properties.Resources.three;//görseli değiştirir
                counter--;//değişkenin değerini bir değiştirir

                //benzer kodlar tekrar eder
            }else if(counter == 2)

            {
                pictureCounter1.Image = Properties.Resources.two;
                pictureCounter2.Image = Properties.Resources.two;
                counter--;

            }else if(counter == 1)

            {
                pictureCounter1.Image = Properties.Resources.one;
                pictureCounter2.Image = Properties.Resources.one;
                counter--;

            }else if(counter == 0)

            {
                pictureCounter1.Image = Properties.Resources.zero;
                pictureCounter2.Image = Properties.Resources.zero;
                counter--;

            }
            else if(counter == -1)
            {
                counter = 3;// Değişkene 3 değeri atanır.

                timer1.Stop();//zamanlayıcıyı durdurur.

                //Start butonunu tekrar kullanılır hale getiren kod.
                Start.Enabled = true;

                #region Kullanıcının Seçimi
                if (player_choose == "makas")//değişkenin değerini kontrol eden koşul
                {
                    pictureChoose.Image = Properties.Resources.scissors;//görseli değiştirir

                }
                else if (player_choose == "taş")
                {
                    pictureChoose.Image = Properties.Resources.rock;

                }
                else if (player_choose == "kağıt")
                {
                    pictureChoose.Image = Properties.Resources.paper;
                }
                #endregion

                #region Bigisayarın Seçimi

                Random rnd = new Random();
                int computer_number = rnd.Next(1, 4);//random bir sayı oluşturuyor.


                #region verilen sayı string olarak yeniden yapılandırılıyor
                if (computer_number == 3)
                    computer_choose = "makas";
                else if(computer_number == 2)
                    computer_choose = "taş";
                else if (computer_number == 1)
                    computer_choose = "kağıt";
                #endregion


                if (computer_choose == "makas")
                {
                    pictureComputer.Image = Properties.Resources.scissors;

                }
                else if (computer_choose == "taş")
                {
                    pictureComputer.Image = Properties.Resources.rock;

                }
                else if (computer_choose == "kağıt")
                {
                    pictureComputer.Image = Properties.Resources.paper;
                }



                #endregion

                #region Kazanan

                if(player_choose == computer_choose)
                {
                    label1.Text = "BERABERE";
                    MessageBox.Show("BERABERE kaldınız.");
                }else if(player_choose == "makas")
                //oyuncu MAKAS seçtiğinde oluşacak senaryolar
                {
                    if (computer_choose == "kağıt")
                    {
                        label1.Text = "OYUNCU KAZANDI";
                        MessageBox.Show("OYUNCU kazandı");
                        winner_sound.Play();
                        oyuncu_kaç_kez_kazandı += 1;

                    }
                    else if (computer_choose == "taş")
                    {
                        label1.Text = "BİLGİSAYAR KAZANDI";
                        MessageBox.Show("BİLGİSAYAR kazandı");
                        lose_sound.Play();
                        bilgisayar_kaç_kez_kazandı += 1;
                    }


                }else if(player_choose == "taş")
                //oyuncu TAŞ seçtiğinde oluşacak senaryolar
                {
                    if (computer_choose == "makas")
                    {
                        label1.Text = "OYUNCU KAZANDI";
                        MessageBox.Show("OYUNCU kazandı");
                        winner_sound.Play();
                        oyuncu_kaç_kez_kazandı += 1;
                    }
                    else if (computer_choose == "kağıt")
                    {
                        label1.Text = "BİLGİSAYAR KAZANDI";
                        MessageBox.Show("BİLGİSAYAR kazandı");
                        lose_sound.Play();
                        bilgisayar_kaç_kez_kazandı += 1;
                    }

                }else if(player_choose == "kağıt")
                //oyuncu KAĞIT seçtiğinde oluşacak senaryolar
                {
                    if (computer_choose == "taş")
                    {
                        label1.Text = "OYUNCU KAZANDI";
                        MessageBox.Show("OYUNCU kazandı");
                        winner_sound.Play();
                        oyuncu_kaç_kez_kazandı += 1;
                    }
                    else if (computer_choose == "makas")
                    {
                        label1.Text = "BİLGİSAYAR KAZANDI";
                        MessageBox.Show("BİLGİSAYAR kazandı");
                        lose_sound.Play();
                        bilgisayar_kaç_kez_kazandı += 1;
                    }

                }




                #endregion
                MessageBox.Show(" Oyuncunun kazandığı maç sayısı : " + oyuncu_kaç_kez_kazandı + "\n Bilgisayarın kazandığı maç sayısı : " + bilgisayar_kaç_kez_kazandı);
            }
            #endregion
            
        }

        #region boş metotlar
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bu programın amacı: if else yapısını kullanarak taş-kağıt-makas oynamaktır.\n Geri sayım başladığında taş,kağıt ve makastan birini seçmelisiniz.\n İyi oyunlar.","ÖĞRETİCİ");
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Backsound_again_Tick(object sender, EventArgs e)
        {
           
        }

        private void pictureComputer_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
