using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refleks_oyunu
{
    public partial class Form1 : Form
    {
        int button_index = 0,button_X, button_Y, rPuan;// değişken oluşturur
        Button btn = new Button();// yeni bir buton oluşturan metod
        Random rnd_location = new Random();//random değer oluşturan metod
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //programdan çıkış sağlar
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();//zamanlayıcıyı çalıştırır

            rPuan = 0;
            btn.Click += Btn_Click;//butonun tıklama metodunu açar

            //butonları görünmez kılar
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label1.Visible = false;
            

            
            btn.Name = "refleksButonu";//butona isim verir
            //boyutları ayarlanır
            btn.Width = 60;
            btn.Height = 60;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1500;//buton çıkış hızıı değiştirir
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//buton çıkış hızıı değiştirir
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;//buton çıkış hızıı değiştirir
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//buton çıkış hızıı değiştirir

            //Başlangıç konuşması
            MessageBox.Show(" Bu oyunun amacı reflekslerinizi test etmektir.\n Start butonuna bastıktan sonra hızlı bir şekilde butonlara basmaya başlayınız.", "ÖĞRETİCİ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(button_index == 0)// butonların sırayla çıkmasını sağlayan koşullar
            {
                btn.Visible = true;//butonu kullanılabilir kılar
                btn.Text = "btn0";//görünen metnini değiştirir
                this.Controls.Add(btn);//butpnu sahneye ekler
                // X ve Y konumlarını belirler
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height); 
                //beliri değerlerde yeni bir buton oluşturur
                btn.Location = new Point(button_X, button_Y);
                //puanı bir arttırır
                button_index += 1;

            }else if(button_index == 1)//buton birinci olma durumunu kontrol eder
            {              
                btn.Text = "btn1";//Butonun metnini btn1 yapar
                this.Controls.Add(btn);//butonu ekranda gösterir
                //butonun rasgele bir yerde çıkmasını sağlayan kodlar
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                //butonu yeni konumuna yerleştirir
                btn.Location = new Point(button_X, button_Y);    
                
                button_index += 1;//yenibutona geçiş sağlar

            }// aynı mantıkta farklı kodlar devam eder...
            else if (button_index == 2)
            {
                btn.Text = "btn2";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 3)
            {
                btn.Text = "btn3";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 4)
            {
                btn.Text = "btn4";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 5)
            {
                btn.Text = "btn5";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 6)
            {
                btn.Text = "btn6";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 7)
            {
                btn.Text = "btn7";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 8)
            {
                btn.Text = "btn8";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 9)
            {
                btn.Text = "btn9";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 10)
            {
                btn.Text = "btn10";
                this.Controls.Add(btn);
                button_X = rnd_location.Next(0, this.ClientSize.Width - btn.Width);
                button_Y = rnd_location.Next(0, this.ClientSize.Height - btn.Height);
                btn.Location = new Point(button_X, button_Y);
                button_index += 1;

            }
            else if (button_index == 11)//değişkenşn değrini kontrol eden koşul
            {
                timer1.Stop();//zamanlayıcıyı durdurur
                //ekranda metin gösterir
                MessageBox.Show($"Tebrik ederim \n Puanın:10/{rPuan} ", "Oyunu Bitirdin");

                //butonları ekranda görünür hale getirir
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                label1.Visible = true;
                btn.Visible = false;//görünmez yapar

                button_index = 0;//değişkenşn değerini sıfırlar




            }




        }
        private void Btn_Click(object sender, EventArgs e)
        {
            rPuan += 1;//puan artırır
            

        }
    }
}
