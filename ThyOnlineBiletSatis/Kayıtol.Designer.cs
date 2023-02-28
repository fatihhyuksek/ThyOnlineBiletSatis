namespace ThyOnlineBiletSatis
{
    partial class Kayıtol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıtol));
            this.txtTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(312, 326);
            this.txtTC.Mask = "00000000000";
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(207, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTC_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(139, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC kimlik:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(139, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsminiz:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(139, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyisminiz:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(139, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefon Numarası:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(139, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "E-posta:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(139, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şifre:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(312, 368);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(207, 22);
            this.txtİsim.TabIndex = 2;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(312, 413);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(207, 22);
            this.txtSoyisim.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(312, 458);
            this.txtTelefon.Mask = "0000000000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(207, 22);
            this.txtTelefon.TabIndex = 0;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(312, 504);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(207, 22);
            this.txtEposta.TabIndex = 3;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(312, 551);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(207, 22);
            this.txtŞifre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kayıt ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(555, 553);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label8.Location = new System.Drawing.Point(199, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 87);
            this.label8.TabIndex = 9;
            this.label8.Text = "MERHABA\r\nNereyi keşfetmek istersiniz?\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 277);
            this.panel1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(893, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "Uygulamayı Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(15, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 39);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kayıtol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1079, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTC);
            this.MaximizeBox = false;
            this.Name = "Kayıtol";
            this.Text = "Kayıtol";
            this.Load += new System.EventHandler(this.Kayıtol_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}