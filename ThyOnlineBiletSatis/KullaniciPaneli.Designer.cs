namespace ThyOnlineBiletSatis
{
    partial class KullaniciPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxNereye = new System.Windows.Forms.ComboBox();
            this.comboBoxNereden = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtSaat = new System.Windows.Forms.TextBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtNereye = new System.Windows.Forms.TextBox();
            this.txtUcus_Id = new System.Windows.Forms.TextBox();
            this.txtNereden = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelSoyisim = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelİsim = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.comboBoxNereye);
            this.groupBox1.Controls.Add(this.comboBoxNereden);
            this.groupBox1.Location = new System.Drawing.Point(13, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bilet Sorgula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(471, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gidiş Tarihi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nereden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(253, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nereye";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(475, 101);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 22);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxNereye
            // 
            this.comboBoxNereye.FormattingEnabled = true;
            this.comboBoxNereye.Items.AddRange(new object[] {
            "İstanbul",
            "Adana",
            "Ankara",
            "Antalya",
            "Aydın",
            "Erzurum",
            "Kars",
            "Sivas",
            "Trabzon"});
            this.comboBoxNereye.Location = new System.Drawing.Point(257, 99);
            this.comboBoxNereye.Name = "comboBoxNereye";
            this.comboBoxNereye.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNereye.TabIndex = 0;
            // 
            // comboBoxNereden
            // 
            this.comboBoxNereden.FormattingEnabled = true;
            this.comboBoxNereden.Items.AddRange(new object[] {
            "İstanbul",
            "Adana",
            "Ankara",
            "Antalya",
            "Aydın",
            "Erzurum",
            "Kars",
            "Sivas",
            "Trabzon"});
            this.comboBoxNereden.Location = new System.Drawing.Point(34, 99);
            this.comboBoxNereden.Name = "comboBoxNereden";
            this.comboBoxNereden.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNereden.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 333);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1074, 295);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(938, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Satın Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFiyat);
            this.groupBox2.Controls.Add(this.txtSaat);
            this.groupBox2.Controls.Add(this.txtKoltukSayisi);
            this.groupBox2.Controls.Add(this.txtTarih);
            this.groupBox2.Controls.Add(this.txtNereye);
            this.groupBox2.Controls.Add(this.txtUcus_Id);
            this.groupBox2.Controls.Add(this.txtNereden);
            this.groupBox2.Location = new System.Drawing.Point(13, 647);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1073, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Bilet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Saat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(806, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "KoltukSayisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tarih";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nereye";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Uçuş_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nereden";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Enabled = false;
            this.txtFiyat.Location = new System.Drawing.Point(809, 47);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 0;
            // 
            // txtSaat
            // 
            this.txtSaat.Enabled = false;
            this.txtSaat.Location = new System.Drawing.Point(547, 47);
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(100, 22);
            this.txtSaat.TabIndex = 0;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Enabled = false;
            this.txtKoltukSayisi.Location = new System.Drawing.Point(681, 47);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtKoltukSayisi.TabIndex = 0;
            // 
            // txtTarih
            // 
            this.txtTarih.Enabled = false;
            this.txtTarih.Location = new System.Drawing.Point(413, 47);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(100, 22);
            this.txtTarih.TabIndex = 0;
            // 
            // txtNereye
            // 
            this.txtNereye.Enabled = false;
            this.txtNereye.Location = new System.Drawing.Point(278, 47);
            this.txtNereye.Name = "txtNereye";
            this.txtNereye.Size = new System.Drawing.Size(100, 22);
            this.txtNereye.TabIndex = 0;
            // 
            // txtUcus_Id
            // 
            this.txtUcus_Id.Enabled = false;
            this.txtUcus_Id.Location = new System.Drawing.Point(17, 47);
            this.txtUcus_Id.Name = "txtUcus_Id";
            this.txtUcus_Id.Size = new System.Drawing.Size(100, 22);
            this.txtUcus_Id.TabIndex = 0;
            this.txtUcus_Id.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtNereden
            // 
            this.txtNereden.Enabled = false;
            this.txtNereden.Location = new System.Drawing.Point(142, 47);
            this.txtNereden.Name = "txtNereden";
            this.txtNereden.Size = new System.Drawing.Size(100, 22);
            this.txtNereden.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(12, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 36);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Uygulamayı Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(897, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(189, 54);
            this.button5.TabIndex = 13;
            this.button5.Text = "Alınan Bilet Sorgulama";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(16, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "TC";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSoyisim);
            this.groupBox3.Controls.Add(this.labelTC);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.labelİsim);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(869, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 173);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kullanıcı";
            // 
            // labelSoyisim
            // 
            this.labelSoyisim.AutoSize = true;
            this.labelSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyisim.Location = new System.Drawing.Point(99, 100);
            this.labelSoyisim.Name = "labelSoyisim";
            this.labelSoyisim.Size = new System.Drawing.Size(54, 18);
            this.labelSoyisim.TabIndex = 14;
            this.labelSoyisim.Text = "label12";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.Location = new System.Drawing.Point(99, 34);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(58, 18);
            this.labelTC.TabIndex = 14;
            this.labelTC.Text = "labelTC";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(99, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 18);
            this.label16.TabIndex = 14;
            // 
            // labelİsim
            // 
            this.labelİsim.AutoSize = true;
            this.labelİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelİsim.Location = new System.Drawing.Point(99, 66);
            this.labelİsim.Name = "labelİsim";
            this.labelİsim.Size = new System.Drawing.Size(54, 18);
            this.labelİsim.TabIndex = 14;
            this.labelİsim.Text = "label12";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(99, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 18);
            this.label14.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(16, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "İsim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(16, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 18);
            this.label13.TabIndex = 14;
            this.label13.Text = "Soyisim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThyOnlineBiletSatis.Properties.Resources.THY_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 792);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "KullaniciPaneli";
            this.Text = "BiletSorgula";
            this.Load += new System.EventHandler(this.KullaniciPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNereden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBoxNereye;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtNereye;
        private System.Windows.Forms.TextBox txtNereden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSaat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUcus_Id;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label labelSoyisim;
        public System.Windows.Forms.Label labelTC;
        public System.Windows.Forms.Label labelİsim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}