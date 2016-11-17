namespace Sirkeet.WFA
{
    partial class FormSiparis
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpTeslimatTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTeslimatAdres = new System.Windows.Forms.TextBox();
            this.nmrUrunAdedi = new System.Windows.Forms.NumericUpDown();
            this.nmrUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.dgvSiparisListe = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunAdedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teslimat Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(36, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adedi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(37, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(9, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teslimat Adresi :";
            // 
            // dtpSiparisTarihi
            // 
            this.dtpSiparisTarihi.Location = new System.Drawing.Point(152, 41);
            this.dtpSiparisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSiparisTarihi.Name = "dtpSiparisTarihi";
            this.dtpSiparisTarihi.Size = new System.Drawing.Size(189, 20);
            this.dtpSiparisTarihi.TabIndex = 6;
            // 
            // dtpTeslimatTarihi
            // 
            this.dtpTeslimatTarihi.Location = new System.Drawing.Point(152, 90);
            this.dtpTeslimatTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTeslimatTarihi.Name = "dtpTeslimatTarihi";
            this.dtpTeslimatTarihi.Size = new System.Drawing.Size(189, 20);
            this.dtpTeslimatTarihi.TabIndex = 7;
            // 
            // txtTeslimatAdres
            // 
            this.txtTeslimatAdres.Location = new System.Drawing.Point(152, 318);
            this.txtTeslimatAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeslimatAdres.Multiline = true;
            this.txtTeslimatAdres.Name = "txtTeslimatAdres";
            this.txtTeslimatAdres.Size = new System.Drawing.Size(189, 88);
            this.txtTeslimatAdres.TabIndex = 8;
            // 
            // nmrUrunAdedi
            // 
            this.nmrUrunAdedi.Location = new System.Drawing.Point(152, 139);
            this.nmrUrunAdedi.Margin = new System.Windows.Forms.Padding(2);
            this.nmrUrunAdedi.Name = "nmrUrunAdedi";
            this.nmrUrunAdedi.Size = new System.Drawing.Size(188, 20);
            this.nmrUrunAdedi.TabIndex = 9;
            // 
            // nmrUrunFiyati
            // 
            this.nmrUrunFiyati.DecimalPlaces = 2;
            this.nmrUrunFiyati.Location = new System.Drawing.Point(152, 188);
            this.nmrUrunFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.nmrUrunFiyati.Name = "nmrUrunFiyati";
            this.nmrUrunFiyati.Size = new System.Drawing.Size(188, 20);
            this.nmrUrunFiyati.TabIndex = 10;
            // 
            // dgvSiparisListe
            // 
            this.dgvSiparisListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisListe.Location = new System.Drawing.Point(384, 41);
            this.dgvSiparisListe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSiparisListe.Name = "dgvSiparisListe";
            this.dgvSiparisListe.RowTemplate.Height = 24;
            this.dgvSiparisListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisListe.Size = new System.Drawing.Size(306, 411);
            this.dgvSiparisListe.TabIndex = 11;
            this.dgvSiparisListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSiparisListe_CellContentClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKaydet.Location = new System.Drawing.Point(23, 411);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 41);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSil.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSil.Location = new System.Drawing.Point(130, 411);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 41);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGuncelle.Location = new System.Drawing.Point(238, 411);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(103, 41);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(65, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Musteri :";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(152, 239);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(188, 21);
            this.cmbMusteri.TabIndex = 17;
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(152, 277);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(188, 21);
            this.cmbUrun.TabIndex = 19;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(65, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ürün :";
            // 
            // FormSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(699, 458);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvSiparisListe);
            this.Controls.Add(this.nmrUrunFiyati);
            this.Controls.Add(this.nmrUrunAdedi);
            this.Controls.Add(this.txtTeslimatAdres);
            this.Controls.Add(this.dtpTeslimatTarihi);
            this.Controls.Add(this.dtpSiparisTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSiparis";
            this.Text = "FormSiparis";
            this.Load += new System.EventHandler(this.FormSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunAdedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSiparisTarihi;
        private System.Windows.Forms.DateTimePicker dtpTeslimatTarihi;
        private System.Windows.Forms.TextBox txtTeslimatAdres;
        private System.Windows.Forms.NumericUpDown nmrUrunAdedi;
        private System.Windows.Forms.NumericUpDown nmrUrunFiyati;
        private System.Windows.Forms.DataGridView dgvSiparisListe;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label label7;
    }
}