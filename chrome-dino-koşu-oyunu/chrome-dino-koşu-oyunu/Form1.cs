using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chrome_dino_koşu_oyunu
{
    public partial class Form1 : Form
    {

        int dinoX, dinoY;
        int engelHiz = 8;
        int zipGucu = 15;
        int yerCekimi = 1;
        int zeminY = 250;
        bool zipliyor = false;
        bool oyunBitti = false;
        int skor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            pictureBoxDino.Location = new Point(50, zeminY);
            pictureBoxEngel.Location = new Point(800, zeminY + 20);

            dinoX = pictureBoxDino.Location.X;
            dinoY = pictureBoxDino.Location.Y;

            labelSkor.Text = "Skor: 0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oyunBitti = false;
            skor = 0;
            labelSkor.Text = "Skor: 0";

            pictureBoxEngel.Left = this.Width;
            timer1.Start();

            buttonBasla.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (oyunBitti) return;

            // Engel hareketi
            pictureBoxEngel.Left -= engelHiz;

            if (pictureBoxEngel.Right < 0)
            {
                pictureBoxEngel.Left = this.Width;
                skor++;
                labelSkor.Text = "Skor: " + skor;

                if (skor % 5 == 0)
                    engelHiz++;
            }

            // Zıplama
            if (zipliyor)
            {
                dinoY -= zipGucu;
                zipGucu -= yerCekimi;

                if (dinoY >= zeminY)
                {
                    dinoY = zeminY;
                    zipliyor = false;
                    zipGucu = 15;
                }

                pictureBoxDino.Location = new Point(dinoX, dinoY);
            }

            // Çarpışma
            if (pictureBoxDino.Bounds.IntersectsWith(pictureBoxEngel.Bounds))
            {
                timer1.Stop();
                oyunBitti = true;
                MessageBox.Show("GAME OVER\nSkor: " + skor);
                buttonBasla.Visible = true;
            }


        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !zipliyor && !oyunBitti)
            {
                zipliyor = true;
            }


        }


    }
}
