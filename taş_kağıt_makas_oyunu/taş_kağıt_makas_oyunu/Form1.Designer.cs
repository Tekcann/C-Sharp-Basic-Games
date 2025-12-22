namespace taş_kağıt_makas_oyunu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureCounter2 = new System.Windows.Forms.PictureBox();
            this.pictureCounter1 = new System.Windows.Forms.PictureBox();
            this.pictureChoose = new System.Windows.Forms.PictureBox();
            this.pictureComputer = new System.Windows.Forms.PictureBox();
            this.picturePaper = new System.Windows.Forms.PictureBox();
            this.pictureRock = new System.Windows.Forms.PictureBox();
            this.pictureScissors = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCounter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oyunu başlatman bekleniyor...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Blue;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Start.FlatAppearance.BorderSize = 50;
            this.Start.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start.Location = new System.Drawing.Point(12, 552);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 60);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.BorderSize = 50;
            this.Exit.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.Location = new System.Drawing.Point(218, 552);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(200, 60);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureCounter2
            // 
            this.pictureCounter2.Image = global::taş_kağıt_makas_oyunu.Properties.Resources.zero;
            this.pictureCounter2.Location = new System.Drawing.Point(288, 134);
            this.pictureCounter2.Name = "pictureCounter2";
            this.pictureCounter2.Size = new System.Drawing.Size(130, 170);
            this.pictureCounter2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCounter2.TabIndex = 7;
            this.pictureCounter2.TabStop = false;
            this.pictureCounter2.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureCounter1
            // 
            this.pictureCounter1.Image = global::taş_kağıt_makas_oyunu.Properties.Resources.zero;
            this.pictureCounter1.Location = new System.Drawing.Point(12, 134);
            this.pictureCounter1.Name = "pictureCounter1";
            this.pictureCounter1.Size = new System.Drawing.Size(130, 170);
            this.pictureCounter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCounter1.TabIndex = 7;
            this.pictureCounter1.TabStop = false;
            this.pictureCounter1.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureChoose
            // 
            this.pictureChoose.Location = new System.Drawing.Point(165, 240);
            this.pictureChoose.Name = "pictureChoose";
            this.pictureChoose.Size = new System.Drawing.Size(100, 150);
            this.pictureChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureChoose.TabIndex = 6;
            this.pictureChoose.TabStop = false;
            this.pictureChoose.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureComputer
            // 
            this.pictureComputer.Location = new System.Drawing.Point(165, 52);
            this.pictureComputer.Name = "pictureComputer";
            this.pictureComputer.Size = new System.Drawing.Size(100, 150);
            this.pictureComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureComputer.TabIndex = 6;
            this.pictureComputer.TabStop = false;
            this.pictureComputer.Click += new System.EventHandler(this.pictureComputer_Click);
            // 
            // picturePaper
            // 
            this.picturePaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePaper.Image = global::taş_kağıt_makas_oyunu.Properties.Resources.paper;
            this.picturePaper.Location = new System.Drawing.Point(318, 396);
            this.picturePaper.Name = "picturePaper";
            this.picturePaper.Size = new System.Drawing.Size(100, 150);
            this.picturePaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePaper.TabIndex = 2;
            this.picturePaper.TabStop = false;
            this.picturePaper.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureRock
            // 
            this.pictureRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRock.Image = global::taş_kağıt_makas_oyunu.Properties.Resources.rock;
            this.pictureRock.Location = new System.Drawing.Point(165, 396);
            this.pictureRock.Name = "pictureRock";
            this.pictureRock.Size = new System.Drawing.Size(100, 150);
            this.pictureRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRock.TabIndex = 1;
            this.pictureRock.TabStop = false;
            this.pictureRock.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureScissors
            // 
            this.pictureScissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureScissors.Image = global::taş_kağıt_makas_oyunu.Properties.Resources.scissors;
            this.pictureScissors.Location = new System.Drawing.Point(13, 396);
            this.pictureScissors.Name = "pictureScissors";
            this.pictureScissors.Size = new System.Drawing.Size(100, 150);
            this.pictureScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureScissors.TabIndex = 0;
            this.pictureScissors.TabStop = false;
            this.pictureScissors.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(441, 618);
            this.Controls.Add(this.pictureCounter2);
            this.Controls.Add(this.pictureCounter1);
            this.Controls.Add(this.pictureChoose);
            this.Controls.Add(this.pictureComputer);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturePaper);
            this.Controls.Add(this.pictureRock);
            this.Controls.Add(this.pictureScissors);
            this.Name = "Form1";
            this.Text = "Taş-Kağıt-Makas-Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCounter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureScissors;
        private System.Windows.Forms.PictureBox pictureRock;
        private System.Windows.Forms.PictureBox picturePaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureComputer;
        private System.Windows.Forms.PictureBox pictureChoose;
        private System.Windows.Forms.PictureBox pictureCounter1;
        private System.Windows.Forms.PictureBox pictureCounter2;
        private System.Windows.Forms.Timer timer1;
    }
}

