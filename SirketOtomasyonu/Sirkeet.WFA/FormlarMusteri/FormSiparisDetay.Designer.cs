namespace Sirkeet.WFA.FormlarMusteri
{
    partial class FormSiparisDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparisAra = new System.Windows.Forms.TextBox();
            this.nmrOdemeEkle = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.dtpSonOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblToplamOdedigiMiktar = new System.Windows.Forms.Label();
            this.lblBorcAlacakli = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdemeGEcmisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrOdemeEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sipariş Bilgi :";
            // 
            // txtSiparisAra
            // 
            this.txtSiparisAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSiparisAra.Location = new System.Drawing.Point(20, 84);
            this.txtSiparisAra.Name = "txtSiparisAra";
            this.txtSiparisAra.Size = new System.Drawing.Size(610, 20);
            this.txtSiparisAra.TabIndex = 2;
            this.txtSiparisAra.TextChanged += new System.EventHandler(this.txtSiparisAra_TextChanged);
            // 
            // nmrOdemeEkle
            // 
            this.nmrOdemeEkle.DecimalPlaces = 2;
            this.nmrOdemeEkle.Location = new System.Drawing.Point(276, 296);
            this.nmrOdemeEkle.Name = "nmrOdemeEkle";
            this.nmrOdemeEkle.Size = new System.Drawing.Size(181, 20);
            this.nmrOdemeEkle.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ödeme Ekle :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(155, 322);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Son Ödeme Tarihi :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(180, 269);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Ödeme Şekli :";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Items.AddRange(new object[] {
            "NAKİT",
            "ÇEK",
            "SENET"});
            this.cmbOdemeSekli.Location = new System.Drawing.Point(276, 269);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(181, 21);
            this.cmbOdemeSekli.TabIndex = 5;
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Location = new System.Drawing.Point(20, 110);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(610, 140);
            this.dgvSiparisler.TabIndex = 6;
            this.dgvSiparisler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisler_CellContentClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(174, 414);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(119, 36);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(324, 414);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(119, 36);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(209, 25);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(309, 21);
            this.cmbMusteri.TabIndex = 9;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // dtpSonOdemeTarihi
            // 
            this.dtpSonOdemeTarihi.Location = new System.Drawing.Point(276, 322);
            this.dtpSonOdemeTarihi.Name = "dtpSonOdemeTarihi";
            this.dtpSonOdemeTarihi.Size = new System.Drawing.Size(181, 20);
            this.dtpSonOdemeTarihi.TabIndex = 10;
            // 
            // lblToplamOdedigiMiktar
            // 
            this.lblToplamOdedigiMiktar.AutoSize = true;
            this.lblToplamOdedigiMiktar.Location = new System.Drawing.Point(273, 352);
            this.lblToplamOdedigiMiktar.Name = "lblToplamOdedigiMiktar";
            this.lblToplamOdedigiMiktar.Size = new System.Drawing.Size(16, 13);
            this.lblToplamOdedigiMiktar.TabIndex = 13;
            this.lblToplamOdedigiMiktar.Text = "...";
            // 
            // lblBorcAlacakli
            // 
            this.lblBorcAlacakli.AutoSize = true;
            this.lblBorcAlacakli.Location = new System.Drawing.Point(273, 375);
            this.lblBorcAlacakli.Name = "lblBorcAlacakli";
            this.lblBorcAlacakli.Size = new System.Drawing.Size(16, 13);
            this.lblBorcAlacakli.TabIndex = 12;
            this.lblBorcAlacakli.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Toplam Ödediği Miktar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Borç Durumu :";
            // 
            // btnOdemeGEcmisi
            // 
            this.btnOdemeGEcmisi.Enabled = false;
            this.btnOdemeGEcmisi.Location = new System.Drawing.Point(506, 256);
            this.btnOdemeGEcmisi.Name = "btnOdemeGEcmisi";
            this.btnOdemeGEcmisi.Size = new System.Drawing.Size(124, 53);
            this.btnOdemeGEcmisi.TabIndex = 15;
            this.btnOdemeGEcmisi.Text = "Ödeme Geçmişini Görüntüle";
            this.btnOdemeGEcmisi.UseVisualStyleBackColor = true;
            this.btnOdemeGEcmisi.Click += new System.EventHandler(this.btnOdemeGEcmisi_Click);
            // 
            // FormSiparisDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 462);
            this.Controls.Add(this.btnOdemeGEcmisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblToplamOdedigiMiktar);
            this.Controls.Add(this.lblBorcAlacakli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSonOdemeTarihi);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.cmbOdemeSekli);
            this.Controls.Add(this.nmrOdemeEkle);
            this.Controls.Add(this.txtSiparisAra);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Name = "FormSiparisDetay";
            this.Text = "FormSiparisDetay";
            this.Load += new System.EventHandler(this.FormSiparisDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrOdemeEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSiparisAra;
        private System.Windows.Forms.NumericUpDown nmrOdemeEkle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.DateTimePicker dtpSonOdemeTarihi;
        private System.Windows.Forms.Label lblToplamOdedigiMiktar;
        private System.Windows.Forms.Label lblBorcAlacakli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdemeGEcmisi;
    }
}