namespace chrome_dino_koşu_oyunu
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
            this.buttonBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxEngel = new System.Windows.Forms.PictureBox();
            this.labelSkor = new System.Windows.Forms.Label();
            this.pictureBoxDino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDino)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBasla
            // 
            this.buttonBasla.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBasla.Location = new System.Drawing.Point(269, 78);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(239, 60);
            this.buttonBasla.TabIndex = 1;
            this.buttonBasla.Text = "START";
            this.buttonBasla.UseVisualStyleBackColor = false;
            this.buttonBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxEngel
            // 
            this.pictureBoxEngel.Location = new System.Drawing.Point(556, 267);
            this.pictureBoxEngel.Name = "pictureBoxEngel";
            this.pictureBoxEngel.Size = new System.Drawing.Size(24, 35);
            this.pictureBoxEngel.TabIndex = 2;
            this.pictureBoxEngel.TabStop = false;
            // 
            // labelSkor
            // 
            this.labelSkor.AutoSize = true;
            this.labelSkor.Location = new System.Drawing.Point(13, 13);
            this.labelSkor.Name = "labelSkor";
            this.labelSkor.Size = new System.Drawing.Size(44, 16);
            this.labelSkor.TabIndex = 3;
            this.labelSkor.Text = "label1";
            // 
            // pictureBoxDino
            // 
            this.pictureBoxDino.Image = global::chrome_dino_koşu_oyunu.Properties.Resources.dinoIdle;
            this.pictureBoxDino.Location = new System.Drawing.Point(16, 251);
            this.pictureBoxDino.Name = "pictureBoxDino";
            this.pictureBoxDino.Size = new System.Drawing.Size(40, 43);
            this.pictureBoxDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDino.TabIndex = 4;
            this.pictureBoxDino.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::chrome_dino_koşu_oyunu.Properties.Resources.BackGround;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxDino);
            this.Controls.Add(this.labelSkor);
            this.Controls.Add(this.pictureBoxEngel);
            this.Controls.Add(this.buttonBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxEngel;
        private System.Windows.Forms.Label labelSkor;
        private System.Windows.Forms.PictureBox pictureBoxDino;
    }
}

