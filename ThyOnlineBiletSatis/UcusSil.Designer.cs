namespace ThyOnlineBiletSatis
{
    partial class UcusSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcusSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxNereye = new System.Windows.Forms.ComboBox();
            this.comboBoxNereden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxNereden = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNereye = new System.Windows.Forms.TextBox();
            this.txtUcus_Id = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBoxNereye);
            this.groupBox1.Controls.Add(this.comboBoxNereden);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uçuşu Arayın";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Uçuşları Ara\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.comboBoxNereye.Location = new System.Drawing.Point(362, 119);
            this.comboBoxNereye.Name = "comboBoxNereye";
            this.comboBoxNereye.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNereye.TabIndex = 6;
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
            this.comboBoxNereden.Location = new System.Drawing.Point(89, 119);
            this.comboBoxNereden.Name = "comboBoxNereden";
            this.comboBoxNereden.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNereden.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nereye";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Uçuş Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(450, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Uçuş Silme Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 517);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(998, 257);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // textBoxNereden
            // 
            this.textBoxNereden.Enabled = false;
            this.textBoxNereden.Location = new System.Drawing.Point(187, 81);
            this.textBoxNereden.Name = "textBoxNereden";
            this.textBoxNereden.Size = new System.Drawing.Size(100, 22);
            this.textBoxNereden.TabIndex = 10;
            this.textBoxNereden.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSaat);
            this.groupBox2.Controls.Add(this.textBoxTarih);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxNereye);
            this.groupBox2.Controls.Add(this.txtUcus_Id);
            this.groupBox2.Controls.Add(this.textBoxNereden);
            this.groupBox2.Location = new System.Drawing.Point(683, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 337);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Silinecek Uçuş";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxSaat
            // 
            this.textBoxSaat.Enabled = false;
            this.textBoxSaat.Location = new System.Drawing.Point(187, 227);
            this.textBoxSaat.Mask = "00:00";
            this.textBoxSaat.Name = "textBoxSaat";
            this.textBoxSaat.Size = new System.Drawing.Size(100, 22);
            this.textBoxSaat.TabIndex = 12;
            this.textBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxTarih
            // 
            this.textBoxTarih.Enabled = false;
            this.textBoxTarih.Location = new System.Drawing.Point(187, 178);
            this.textBoxTarih.Mask = "00/00/0000";
            this.textBoxTarih.Name = "textBoxTarih";
            this.textBoxTarih.Size = new System.Drawing.Size(100, 22);
            this.textBoxTarih.TabIndex = 12;
            this.textBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Saat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nereye :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ucus_ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nereden :";
            // 
            // textBoxNereye
            // 
            this.textBoxNereye.Enabled = false;
            this.textBoxNereye.Location = new System.Drawing.Point(187, 132);
            this.textBoxNereye.Name = "textBoxNereye";
            this.textBoxNereye.Size = new System.Drawing.Size(100, 22);
            this.textBoxNereye.TabIndex = 10;
            // 
            // txtUcus_Id
            // 
            this.txtUcus_Id.Enabled = false;
            this.txtUcus_Id.Location = new System.Drawing.Point(187, 38);
            this.txtUcus_Id.Name = "txtUcus_Id";
            this.txtUcus_Id.Size = new System.Drawing.Size(100, 22);
            this.txtUcus_Id.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(943, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Uygulamayı Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1022, 611);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Seç";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1120, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeriDön.BackgroundImage")));
            this.btnGeriDön.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDön.Location = new System.Drawing.Point(12, 106);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(61, 38);
            this.btnGeriDön.TabIndex = 24;
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // UcusSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1109, 795);
            this.Controls.Add(this.btnGeriDön);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "UcusSil";
            this.Text = "UcusSil";
            this.Load += new System.EventHandler(this.UcusSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxNereye;
        private System.Windows.Forms.ComboBox comboBoxNereden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxNereden;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNereye;
        private System.Windows.Forms.MaskedTextBox textBoxTarih;
        private System.Windows.Forms.MaskedTextBox textBoxSaat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUcus_Id;
        private System.Windows.Forms.Button btnGeriDön;
    }
}