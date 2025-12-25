using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {// kullanılan kelimeler// 0         1          2        3        4         5         6          7        8        9
        string[] words = { "MEHMET", "SERKAN", "BURHAN", "RIDVAN", "ZEYNEP", "MELİKE", "HATİCE", "TEOMAN", "NURHAN", "TARKAN"};
        //Alfebedeki kelimler
        string[] alphabet ={"A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z"};


        Random rnd = new Random();//Random değer üretmek için kullanılan kod
        
        //değişkenler atanır
        int rndWord, wrongs = 0;
        string word,oneWord;
        bool wordIsRight;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEXİT_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamayı kapatır
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //Yazılan kelşmenin doğru olup olmamasını kontrol eder.Doğruysa calışır
            if (comboBox1.Text.Trim().ToUpper() == word.ToUpper().Trim())
            {  //ekranda metin gösteirir
                MessageBox.Show("Doğru Bildiniz.\n Tekrar Oynamak İçin Start Butonuna Bas", "MAŞALLAH");
                basaDön();//metot çağırır
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i;//değişken oluşturur
            wordIsRight = false;//değişkenin değeri yanlış olarak değiştirir

            //kelmenin uzunluğu kadar içindeki kodları takrar çalıştırır
            for (i = 0;i < word.Trim().Length; i++)
            {
                oneWord = word.ToUpper().Substring(i, 1);//kelimeden sırayla harfler alır
                //harf ile comboBax ın metninin doğru olup olmamasını kontrol eder
                if (comboBox1.Text == oneWord)
                {
                    wordIsRight = true;//değişkenin değerini doğru olarak değiştirir
                    //i değişkeninin değerine göre kodlar çalıştırır
                    switch (i) {
                        case 0://i değişkeninin değeri 0 ise altındaki kodlar çalışır
                            labelHarf0.Text = comboBox1.Text;//label a harf yazdırır
                            break;//geri kalan komutları atlar

                            //aynı mantık aşağıda ki kodlarda devam eder
                        case 1:
                            labelHarf1.Text = comboBox1.Text;
                            break;
                        case 2:
                            labelHarf2.Text = comboBox1.Text;
                            break;
                        case 3:
                            labelHarf3.Text = comboBox1.Text;
                            break;
                        case 4:
                            labelHarf4.Text = comboBox1.Text;
                            break;
                        case 5:
                            labelHarf5.Text = comboBox1.Text;
                            break;
                    }
                    
                }
                
            }
            if (wordIsRight == false)//değişkenin değeri doğru ise içindeki komutları çalıştırır
            {
                switch (wrongs)//değişkenin içindeki değere göre komutlar çalıştırır
                {
                    case 0://değişkenin değeri 0 ise bu komutlar çalışır
                        pictureBox1.Image = Properties.Resources._1_hata;//PictureBox ın resmini değiştirir
                      //değişkenin değerini bit artırır; geri kalan komutları atlar
                        wrongs++; break;
                    //aynı mantık aşağıda ki kodlarda devam eder
                    case 1:
                        pictureBox1.Image = Properties.Resources._2_hata;
                        wrongs++; break;
                    case 2:
                        pictureBox1.Image = Properties.Resources._3_hata;
                        wrongs++; break;
                    case 3:
                        pictureBox1.Image = Properties.Resources._4_hata;
                        wrongs++; break;
                    case 4:
                        pictureBox1.Image = Properties.Resources._5_hata;
                        wrongs++; break;
                    case 5:
                        pictureBox1.Image = Properties.Resources._6_hata;
                        wrongs++;break;
                    
                        
                        

                }

            }

            listBoxBosHarf.Items.Add(comboBox1.Text);//listBox a seçili olan harfi ekler
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);// seçili olan harfi comboBox ın listesinden siler

            //değişkenin değeri 6 olduğunda içindeki komutları çalıştırır
            if(wrongs == 6)
            {  //ekranda metin gösterir
                MessageBox.Show("Tekrar Oynamak İçin Start Butonuna Bas", "KAYBETTİN");

                basaDön();//metotu çalıştırır
               
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxBosHarf.Enabled = false;// listBox u kullanılmaz hale getirir
            comboBox1.Enabled = false;// comboBox u kullanılmaz hale getirir

            //ekranda metin gösterir
            MessageBox.Show("Bu bir ADAM ASMACA Oyunudur.\n Kelimeler İnsan İsimleridir.\n ComboBoxtan İstediğiniz Harfi secebilir Ya da Üstüne İstediğiniz Kelimeyi Yazarak Deneyebilirsiniz.","ÖĞRETİCi");
        }

        private void buttonSTART_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;// listBox u kullanılabilir hale getirir
            listBoxBosHarf.Enabled = true;// comboBox u kullanılabilir hale getirir


            rndWord = rnd.Next(0, 10);//random değer üretir

            word = words[rndWord];//değişkene dizilerden bir raskele kelime atar

            MessageBox.Show("Kelime Seçildi");//ekranda metin göstirir

            basaDön();//metodu çalıştırır


            //label ların matinlerini değiştirir
            labelHarf0.Text = "X";
            labelHarf1.Text = "X";
            labelHarf2.Text = "X";
            labelHarf3.Text = "X";
            labelHarf4.Text = "X";
            labelHarf5.Text = "X";



            #region boş kod
            //Bu kodlar random word armanın farklı bir yoludur.
            /*for(int i=0;i<10;i=i+1)
            {
                if (i == rndWord)
                {
                    string lazim = words[i];
                    MessageBox.Show(words[i]);
                }
            }*/
            #endregion
        }
        private void basaDön()
        {

            //lanel ların metinlerini değiştirir(seçilen kelimeyi ekrana yazılır
            labelHarf0.Text = word.Trim().Substring(0, 1);
            labelHarf1.Text = word.Trim().Substring(1, 1);
            labelHarf2.Text = word.Trim().Substring(2, 1);
            labelHarf3.Text = word.Trim().Substring(3, 1);
            labelHarf4.Text = word.Trim().Substring(4, 1);
            labelHarf5.Text = word.Trim().Substring(5, 1);

            comboBox1.Items.Clear();//ComboBoxtaki harfleri siler
            listBoxBosHarf.Items.Clear();//listBox un içinde yazılanları siler

            //bir döngü başlatır doğru olduğu süre boyunca çalışır
            for (int j = 0; j < 29; j++)
            {
                comboBox1.Items.Add(alphabet[j]);//comboBox a alfabeyi harf yazdırır
            }

            pictureBox1.Image = Properties.Resources._0_hata;//pictureBox ın resmini değiştirir
            wrongs = 0;//değişkenin değerini 0 olarak ayarlar


        }
    }
}
