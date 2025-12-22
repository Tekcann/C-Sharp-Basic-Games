namespace mayın_oyunu
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
            this.pictureBox00 = new System.Windows.Forms.PictureBox();
            this.pictureBox01 = new System.Windows.Forms.PictureBox();
            this.pictureBox02 = new System.Windows.Forms.PictureBox();
            this.pictureBox03 = new System.Windows.Forms.PictureBox();
            this.pictureBox04 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox04)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox00
            // 
            this.pictureBox00.Image = global::mayın_oyunu.Properties.Resources.grass;
            this.pictureBox00.Location = new System.Drawing.Point(15, 11);
            this.pictureBox00.Name = "pictureBox00";
            this.pictureBox00.Size = new System.Drawing.Size(125, 125);
            this.pictureBox00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox00.TabIndex = 0;
            this.pictureBox00.TabStop = false;
            this.pictureBox00.Visible = false;
            this.pictureBox00.Click += new System.EventHandler(this.pictureBox01_Click);
            // 
            // pictureBox01
            // 
            this.pictureBox01.Image = global::mayın_oyunu.Properties.Resources.grass;
            this.pictureBox01.Location = new System.Drawing.Point(145, 10);
            this.pictureBox01.Name = "pictureBox01";
            this.pictureBox01.Size = new System.Drawing.Size(125, 125);
            this.pictureBox01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox01.TabIndex = 0;
            this.pictureBox01.TabStop = false;
            this.pictureBox01.Visible = false;
            this.pictureBox01.Click += new System.EventHandler(this.pictureBox02_Click);
            // 
            // pictureBox02
            // 
            this.pictureBox02.Image = global::mayın_oyunu.Properties.Resources.grass;
            this.pictureBox02.Location = new System.Drawing.Point(278, 12);
            this.pictureBox02.Name = "pictureBox02";
            this.pictureBox02.Size = new System.Drawing.Size(125, 125);
            this.pictureBox02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox02.TabIndex = 0;
            this.pictureBox02.TabStop = false;
            this.pictureBox02.Visible = false;
            this.pictureBox02.Click += new System.EventHandler(this.pictureBox03_Click);
            // 
            // pictureBox03
            // 
            this.pictureBox03.Image = global::mayın_oyunu.Properties.Resources.grass;
            this.pictureBox03.Location = new System.Drawing.Point(409, 11);
            this.pictureBox03.Name = "pictureBox03";
            this.pictureBox03.Size = new System.Drawing.Size(125, 125);
            this.pictureBox03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox03.TabIndex = 0;
            this.pictureBox03.TabStop = false;
            this.pictureBox03.Visible = false;
            this.pictureBox03.Click += new System.EventHandler(this.pictureBox04_Click);
            // 
            // pictureBox04
            // 
            this.pictureBox04.Image = global::mayın_oyunu.Properties.Resources.grass;
            this.pictureBox04.Location = new System.Drawing.Point(540, 12);
            this.pictureBox04.Name = "pictureBox04";
            this.pictureBox04.Size = new System.Drawing.Size(125, 125);
            this.pictureBox04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox04.TabIndex = 0;
            this.pictureBox04.TabStop = false;
            this.pictureBox04.Visible = false;
            this.pictureBox04.Click += new System.EventHandler(this.pictureBox05_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Blue;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStart.Location = new System.Drawing.Point(15, 141);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(320, 74);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Brown;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.Location = new System.Drawing.Point(346, 141);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(320, 74);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "EXİT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 236);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox03);
            this.Controls.Add(this.pictureBox02);
            this.Controls.Add(this.pictureBox04);
            this.Controls.Add(this.pictureBox01);
            this.Controls.Add(this.pictureBox00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox04)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox00;
        private System.Windows.Forms.PictureBox pictureBox01;
        private System.Windows.Forms.PictureBox pictureBox02;
        private System.Windows.Forms.PictureBox pictureBox03;
        private System.Windows.Forms.PictureBox pictureBox04;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
    }
}

