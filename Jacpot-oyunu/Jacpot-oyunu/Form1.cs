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

namespace Jacpot_oyunu
{
    public partial class Form1 : Form
    {

        //değişenlere ayrlanıyor
        int donus_sayısı = 0;
        string dondurelim = "Dön";
        int kazanma_ihtimali, senaryo;

        Random rnd = new Random();
        int rnd_donuş;

        //ses dosyarı ayarlanıoyr
        SoundPlayer lose_sound = new SoundPlayer(Properties.Resources.fail_trumpet);
        SoundPlayer winner_sound = new SoundPlayer(Properties.Resources.succesful);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //başlangıçta çalışması için gerekli kodlar
            donus_sayısı = 0;
            dondurelim = "Dön";

            timer1.Start();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" Bu program bir şans oyunudur. \nOyuna başlamak için döndür butonuna tıklayınız. \n Bol şans dilerim.","ÖĞRETİCİ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(donus_sayısı > 25)//25 kez dönmesini bekliyor
            {
                dondurelim = "Boşta";
                timer1.Stop();//zamanlayıcıyı durdurur

                kazanma_ihtimali = rnd.Next(0, 101);//random değer üretir
                senaryo = rnd.Next(0, 4);

                //eğer random şekilde gelen değer 30 un altındaysa oyuncu kazanmış olur
                if (kazanma_ihtimali <= 30)// %30 ihtimalle kazanma şansı
                {

                    //Kazanma olasılıkları
                    if (senaryo == 0)
                    {
                        //pictureBox ların görsellerini değiştirir
                        pictureBox1.Image = Properties.Resources.kartMaça;
                        pictureBox2.Image = Properties.Resources.kartMaça;
                        pictureBox3.Image = Properties.Resources.kartMaça;

                    }
                    else if(senaryo == 1)
                    {
                        pictureBox1.Image = Properties.Resources.kartKupa;
                        pictureBox2.Image = Properties.Resources.kartKupa;
                        pictureBox3.Image = Properties.Resources.kartKupa;

                    }else if(senaryo == 2)
                    {
                        pictureBox1.Image = Properties.Resources.kartKaro;
                        pictureBox2.Image = Properties.Resources.kartKaro;
                        pictureBox3.Image = Properties.Resources.kartKaro;

                    }else if(senaryo == 3)
                    {
                        pictureBox1.Image = Properties.Resources.kartSinek;
                        pictureBox2.Image = Properties.Resources.kartSinek;
                        pictureBox3.Image = Properties.Resources.kartSinek;
                    }
                    winner_sound.Play();//ses çalar

                    //metin gösterir
                    MessageBox.Show("Kumar Oynadığınız İçin Teşekküler \n Yeni Oyunlarda Görüşmek Üzere...", "TEBBRİKKLERRRRR!!!");
                }
                else//oyunu kaybetme durumda çalışan kodlar
                {
                    lose_sound.Play();//ses çalar

                    //metin gösterir
                    MessageBox.Show("KAYBETTİN BİR DAHA DENEMEK İSTER MİSİN? :)", "HA! HA! HA! HA!!!");

                }
                

            }else if(dondurelim == "Dön")//jacpotun ddönme eylemini gerçekleştirir
            {
                rnd_donuş = rnd.Next(0, 4);//raskere değer üretir
               
                //gene raskele değerlere göre karmaşık bir döngü oluşur
                if(rnd_donuş == 0)
                {
                    pictureBox1.Image = Properties.Resources.kartMaça;//pictureBOx ları görütüsü deişir
                    pictureBox2.Image = Properties.Resources.kartKaro;
                    pictureBox3.Image = Properties.Resources.kartKupa;
                    donus_sayısı++;//döngü sayısını 1 arttırır 
                    //25 olduğunda döngü durur
                    
                }else if (rnd_donuş == 1)
                {
                    pictureBox1.Image = Properties.Resources.kartKupa;
                    pictureBox2.Image = Properties.Resources.kartSinek;
                    pictureBox3.Image = Properties.Resources.kartKaro;
                    donus_sayısı++;

                }
                else if (rnd_donuş == 2)
                {
                    pictureBox1.Image = Properties.Resources.kartKaro;
                    pictureBox2.Image = Properties.Resources.kartMaça;
                    pictureBox3.Image = Properties.Resources.kartSinek;
                    donus_sayısı++;

                }
                else if (rnd_donuş == 3)
                {
                    pictureBox1.Image = Properties.Resources.kartSinek;
                    pictureBox2.Image = Properties.Resources.kartKupa;
                    pictureBox3.Image = Properties.Resources.kartMaça;
                    donus_sayısı++;

                }
                


            }

        }
    }
}
