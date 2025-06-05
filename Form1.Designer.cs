namespace kargo_takip_sistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textTakipNo = new System.Windows.Forms.TextBox();
            this.textAlici = new System.Windows.Forms.TextBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            this.lstGonderiler = new System.Windows.Forms.ListBox();
            this.bnSorgula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTakipNo
            // 
            this.textTakipNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textTakipNo.Location = new System.Drawing.Point(167, 46);
            this.textTakipNo.Name = "textTakipNo";
            this.textTakipNo.Size = new System.Drawing.Size(100, 26);
            this.textTakipNo.TabIndex = 0;
            this.textTakipNo.TextChanged += new System.EventHandler(this.textTakipNo_TextChanged);
            // 
            // textAlici
            // 
            this.textAlici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textAlici.Location = new System.Drawing.Point(167, 81);
            this.textAlici.Name = "textAlici";
            this.textAlici.Size = new System.Drawing.Size(100, 26);
            this.textAlici.TabIndex = 1;
            this.textAlici.TextChanged += new System.EventHandler(this.textAlici_TextChanged);
            // 
            // cmbTip
            // 
            this.cmbTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(167, 153);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 28);
            this.cmbTip.TabIndex = 2;
            this.cmbTip.Text = "Seçiniz";
            this.cmbTip.SelectedIndexChanged += new System.EventHandler(this.cmbTip_SelectedIndexChanged);
            // 
            // cmbDurum
            // 
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(167, 119);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 28);
            this.cmbDurum.TabIndex = 3;
            this.cmbDurum.Text = "Seçiniz";
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbDurum_SelectedIndexChanged);
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.SystemColors.Info;
            this.btnOlustur.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.Location = new System.Drawing.Point(83, 224);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(158, 35);
            this.btnOlustur.TabIndex = 4;
            this.btnOlustur.Text = "Gönderi Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.BackColor = System.Drawing.SystemColors.Info;
            this.btnDurumGuncelle.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumGuncelle.Location = new System.Drawing.Point(83, 280);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(158, 40);
            this.btnDurumGuncelle.TabIndex = 5;
            this.btnDurumGuncelle.Text = "Durum Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = false;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // lstGonderiler
            // 
            this.lstGonderiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstGonderiler.FormattingEnabled = true;
            this.lstGonderiler.ItemHeight = 16;
            this.lstGonderiler.Location = new System.Drawing.Point(330, -1);
            this.lstGonderiler.Name = "lstGonderiler";
            this.lstGonderiler.Size = new System.Drawing.Size(475, 436);
            this.lstGonderiler.TabIndex = 6;
            this.lstGonderiler.SelectedIndexChanged += new System.EventHandler(this.lstGonderiler_SelectedIndexChanged);
            // 
            // bnSorgula
            // 
            this.bnSorgula.BackColor = System.Drawing.SystemColors.Info;
            this.bnSorgula.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bnSorgula.Location = new System.Drawing.Point(83, 348);
            this.bnSorgula.Name = "bnSorgula";
            this.bnSorgula.Size = new System.Drawing.Size(158, 33);
            this.bnSorgula.TabIndex = 7;
            this.bnSorgula.Text = "Sorgula";
            this.bnSorgula.UseVisualStyleBackColor = false;
            this.bnSorgula.Click += new System.EventHandler(this.bnSorgula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Takip No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Alıcı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Göneri Durumu: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gönderi Tipi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnSorgula);
            this.Controls.Add(this.lstGonderiler);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.textAlici);
            this.Controls.Add(this.textTakipNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTakipNo;
        private System.Windows.Forms.TextBox textAlici;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Button btnDurumGuncelle;
        private System.Windows.Forms.ListBox lstGonderiler;
        private System.Windows.Forms.Button bnSorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

