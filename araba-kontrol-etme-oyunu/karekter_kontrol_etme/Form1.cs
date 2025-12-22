using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karekter_kontrol_etme
{
    public partial class Form1 : Form
    {
        int araba_x, araba_y;// arabanın konumu için değişken oluşturur
        string yon = "boş";//arabanın yönünü ilk başta boş olarak değiştirir
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 10;//zamanlayıcının aralığını 10 ms olarak değiştirir
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MessageBox.Show("Bu program, if else yapısını kullanarak \n bir arabanın hareket edilmesini sağlar." +
                " \n Yön tuşlarını kullanarak hareket sağlayabilirsiniz", "ÖĞRETİCİ");

            //değişkenlere arabanın X ve Y konumu atar
            araba_x = pictureBox1.Location.X;
            araba_y = pictureBox1.Location.Y;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up)//yukarı ok tuşuna basılma durumunu kontrol eder
                yon = "yukarı";//yukarı ok tuşuna basılırsa yönü yukarı yapar

            else if (e.KeyCode == Keys.Down)//aşağı ok tuşuna basılmasını kontrol eder
                yon = "aşağı";//aşağı ok tuşuna basıldığında yönü aşağı olarak değiştirir

            else if (e.KeyCode == Keys.Left)//sol ok tuşuna basılmasını kontrol eder
                yon = "sol";//sol ok tuşuna basılırsa yönü sol yapar

            else if (e.KeyCode == Keys.Right)//sağ ok tuşuna basılma durumunu kontrol eder
                yon = "sağ";//sağ ok tuşuna basılıyorsa  yönü sağ yapar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();//zamanlayıcıyı çalıştırır

            button1.Visible = false;

            //form uygulamasında buton kullınıyor ise program klavye tuplarından veri almaz
            //bu sebeple butona basıldığında KeyPrewiew komutu ile kavleyi kullanılabilir yapıyoruz
            //ActiveControl ile de buton kontrolünü devre dışı bırakıyoruz
            this.KeyPreview = true;
            this.ActiveControl = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yon == "yukarı")//yön yukarı ise çalışır
            {
                araba_y--;// arabanın Y konumumdan 1 çıkartır
                //arabanın resmini yukarı olarak değiştirir
                pictureBox1.Image = Properties.Resources.up;

            }
            else if (yon == "aşağı")//yön aşağı ise çalışır
            {
                araba_y++;//arabanın Y konumuna 1 ekler

                //arabanın resmini aşağı olarak değiştirir
                pictureBox1.Image = Properties.Resources.down;

            }
            else if (yon == "sol")//yön sol ise çalışır
            {
                araba_x--;//arabanın X konumumdan 1 çıkartır

                //arabanın resmini sol olarak değiştirir
                pictureBox1.Image = Properties.Resources.left;

            }
            else if (yon == "sağ")//yön sağ ise çalışır
            {
                araba_x++;//arabanın X konumuma 1 ekler

                //arabanın resmini sağ olarak değiştirir
                pictureBox1.Image = Properties.Resources.right;

            }
            //araba sekmenin boyutundan dışarı çıkmaması için gerekli kodlar

            if (araba_x < 0)//arabanın X konumu 0dan küçük olursa çalışır
                //arabanın X konumunu 0 a eşitler
                araba_x = 0;

            //araba sola giderken pencereden dışarı çıkmaması için gereklidir
            else if (araba_y < 0)//arabanın Y konumu 0dan küçükse çalışır
                //arabnın Y konumu 0 a eşitler
                araba_y = 0;


            //this.ClientSize.Width : bu komut pencerenin X düzlemindeki boyunu öğrenmek için kullanılır
            //this.ClientSize.Height: bu komut arabanın Y eksenindeki boyutunu öğrenmek için kullanılır
            //pictureBox1.Wigth : bu komut arabanın dikey olarak kaç pixel boyutunda olduğunu bulur  
            //pictureBox1.Height : bu komut arabanın yatay olarak kaç pixel boyutunda olduğunu bulur  



            //eğer arabanın X konumu oyunun pencere boyutundan arabanın yatay boyunu
            //çıkarmasının sonucundan büyükse çalışır
            if(araba_x > this.ClientSize.Width - pictureBox1.Width)
                araba_x = this.ClientSize.Width - pictureBox1.Width;//arabayı pencerenin içinde tutar

            //eğer arabanın Y konumu oyunun pencere boyutundan arabanın dikey boyunu
            //çıkarmasının sonucundan büyükse çalışır
            if (araba_y > this.ClientSize.Height - pictureBox1.Height)
                araba_y = this.ClientSize.Height - pictureBox1.Height;

            pictureBox1.Location = new Point(araba_x, araba_y);//arabayı yeni konuma götürür
           
        }
    }
}
