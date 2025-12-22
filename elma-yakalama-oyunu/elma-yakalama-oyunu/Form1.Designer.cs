namespace elma_yakalama_oyunu
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
            this.pictureBoxBasket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSTART = new System.Windows.Forms.Button();
            this.buttonEXİT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBasket
            // 
            this.pictureBoxBasket.Image = global::elma_yakalama_oyunu.Properties.Resources.basket;
            this.pictureBoxBasket.Location = new System.Drawing.Point(321, 302);
            this.pictureBoxBasket.Name = "pictureBoxBasket";
            this.pictureBoxBasket.Size = new System.Drawing.Size(100, 89);
            this.pictureBoxBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBasket.TabIndex = 0;
            this.pictureBoxBasket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skor :";
            // 
            // buttonSTART
            // 
            this.buttonSTART.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSTART.Location = new System.Drawing.Point(289, 61);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(194, 41);
            this.buttonSTART.TabIndex = 2;
            this.buttonSTART.TabStop = false;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = false;
            this.buttonSTART.Click += new System.EventHandler(this.buttonSTART_Click);
            // 
            // buttonEXİT
            // 
            this.buttonEXİT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEXİT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEXİT.Location = new System.Drawing.Point(289, 108);
            this.buttonEXİT.Name = "buttonEXİT";
            this.buttonEXİT.Size = new System.Drawing.Size(194, 41);
            this.buttonEXİT.TabIndex = 2;
            this.buttonEXİT.TabStop = false;
            this.buttonEXİT.Text = "EXİT";
            this.buttonEXİT.UseVisualStyleBackColor = false;
            this.buttonEXİT.Click += new System.EventHandler(this.buttonEXİT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(832, 403);
            this.Controls.Add(this.buttonEXİT);
            this.Controls.Add(this.buttonSTART);
            this.Controls.Add(this.pictureBoxBasket);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBasket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.Button buttonEXİT;
    }
}

