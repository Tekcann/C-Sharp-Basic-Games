using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace mayın_oyunu
{

    public partial class Form1 : Form
    {
        
        int mine_box = 0;//mayının hangi pictureBox ta olduğunu kaydeder
        int player_choose;//oyuncunun seçimini kaydeder
        bool secim_dogru_mu; //seçimin bomba olup olmadığını kotrol eder
        
        Random rnd_mine = new Random();//random değer üretir

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//çıkış butonunun kodu
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Oyunun başındaki öğretici metin
            MessageBox.Show("Oyunun Amacı Mayın Olmayan Çalıyı Bularak Hayatta Kalmaktır. \n İyi Oyunlar :)", "Mayından Kaçış Oyununa Hoş Geldiniz.");
            MessageBox.Show("Start Butonuna Basarak Oyunu Başlat");

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //pictureBox ların görselini değiştirir
            pictureBox00.Image = Properties.Resources.grass;
            pictureBox01.Image = Properties.Resources.grass;
            pictureBox02.Image = Properties.Resources.grass;
            pictureBox03.Image = Properties.Resources.grass;
            pictureBox04.Image = Properties.Resources.grass;
            
            mayınSırası0();// bütün çalıları(pictureBoxları) gösteren kod
            mine_box = rnd_mine.Next(0, 5);
            //MessageBox.Show(mine_box.ToString());
            player_choose = 1000;

            timer1.Start();//zamanlayıcıyı başlatır
     
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (mine_box == player_choose)//oyuncunun seçimi ile mayının olduğu çalı aynı ise
            {                            //oyuncu oyunu kaybeder ve bomba açığa çıkar
                if (player_choose == 0)
                {
                    pictureBox00.Image = Properties.Resources.bum;//pictureBox fotoğrafını değiştirir
                }
                else if (player_choose == 1)
                {
                    pictureBox01.Image = Properties.Resources.bum;
                }
                else if (player_choose == 2)
                {
                    pictureBox02.Image = Properties.Resources.bum;
                }
                else if (player_choose == 3)
                {
                    pictureBox03.Image = Properties.Resources.bum;
                }
                else if (player_choose == 4)
                {
                    pictureBox04.Image = Properties.Resources.bum;
                }
                timer1.Stop();//zamanlayıcıyı durdurur
                //ekranda yazı gösterir
                MessageBox.Show("MAYINA BASTINIZ!! :)", "TEBRİKLER HAHAHAHAH");
                secim_dogru_mu = false;//değişkenin değerini yanlış olarak değiştirir

                
                

            }//oyuncunun seçimin doğru olduğu durumda çalışır
            if (mine_box != player_choose && secim_dogru_mu == true)
            {
                secim_dogru_mu = false;
                MessageBox.Show(" MAYINDAN KAÇTINIZ!!!! :)", "TEBRİKL EDERİM EFENDİM");
                
                //Mayın olan pictureBox ı gösteren koşullar 
                if (mine_box == 0)
                {
                    pictureBox00.Image = Properties.Resources.bum;//pictureBox fotoğrafını değiştirir
                }
                else if (mine_box == 1)
                {
                    pictureBox01.Image = Properties.Resources.bum;
                }
                else if (mine_box == 2)
                {
                    pictureBox02.Image = Properties.Resources.bum;
                }
                else if (mine_box == 3)
                {
                    pictureBox03.Image = Properties.Resources.bum;
                }
                else if (mine_box == 4)
                {
                    pictureBox04.Image = Properties.Resources.bum;
                }
                

            }
        }
        private void mayınSırası0()
        {
            //sadece denedim ve olduğu için böyle bir kod kullandım :)
            //pictureBoxları görünür hale getirir
            pictureBox00.Visible = true;
            pictureBox01.Visible = true;
            pictureBox02.Visible = true;
            pictureBox03.Visible = true;
            pictureBox04.Visible = true;

        }
       

        #region Birinci Sıra Oyuncunun Secimi
        private void pictureBox01_Click(object sender, EventArgs e)
        {
            player_choose = 0;//oyunucnun seçtiği çimeni değişkene atar
            secim_dogru_mu = true;//değişkenin değerini değiştirir
        }

        private void pictureBox02_Click(object sender, EventArgs e)
        {
            player_choose = 1;
            secim_dogru_mu = true;
        }

        private void pictureBox03_Click(object sender, EventArgs e)
        {
            player_choose = 2;
            secim_dogru_mu = true;
        }

        private void pictureBox04_Click(object sender, EventArgs e)
        {
            player_choose = 3;
            secim_dogru_mu = true;
        }

        private void pictureBox05_Click(object sender, EventArgs e)
        {
            player_choose = 4;
            secim_dogru_mu = true;
        }



        #endregion
    
    }

}




