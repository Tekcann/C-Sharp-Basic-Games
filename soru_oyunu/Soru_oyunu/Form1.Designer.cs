namespace Soru_oyunu
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
            this.Question = new System.Windows.Forms.Label();
            this.A_choice = new System.Windows.Forms.Button();
            this.B_choice = new System.Windows.Forms.Button();
            this.C_choice = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.BackColor = System.Drawing.Color.CadetBlue;
            this.Question.Font = new System.Drawing.Font("SWItalc", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(12, 9);
            this.Question.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(847, 158);
            this.Question.TabIndex = 0;
            this.Question.Text = "Sorulara hazır mısın?";
            this.Question.Click += new System.EventHandler(this.Question_Click);
            // 
            // A_choice
            // 
            this.A_choice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.A_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A_choice.Location = new System.Drawing.Point(16, 245);
            this.A_choice.Name = "A_choice";
            this.A_choice.Size = new System.Drawing.Size(270, 75);
            this.A_choice.TabIndex = 1;
            this.A_choice.Text = "button1";
            this.A_choice.UseVisualStyleBackColor = false;
            this.A_choice.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_choice
            // 
            this.B_choice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.B_choice.Location = new System.Drawing.Point(298, 245);
            this.B_choice.Name = "B_choice";
            this.B_choice.Size = new System.Drawing.Size(270, 75);
            this.B_choice.TabIndex = 2;
            this.B_choice.Text = "button2";
            this.B_choice.UseVisualStyleBackColor = false;
            this.B_choice.Click += new System.EventHandler(this.B_choice_Click);
            // 
            // C_choice
            // 
            this.C_choice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.C_choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.C_choice.Location = new System.Drawing.Point(580, 245);
            this.C_choice.Name = "C_choice";
            this.C_choice.Size = new System.Drawing.Size(270, 75);
            this.C_choice.TabIndex = 3;
            this.C_choice.Text = "button3";
            this.C_choice.UseVisualStyleBackColor = false;
            this.C_choice.Click += new System.EventHandler(this.C_choice_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Blue;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.Location = new System.Drawing.Point(16, 333);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(400, 70);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Crimson;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.Location = new System.Drawing.Point(450, 333);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(400, 70);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Süre : 60";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puan : 0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(871, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.C_choice);
            this.Controls.Add(this.B_choice);
            this.Controls.Add(this.A_choice);
            this.Name = "Form1";
            this.Text = "Soru_testi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button A_choice;
        private System.Windows.Forms.Button B_choice;
        private System.Windows.Forms.Button C_choice;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
    }
}

