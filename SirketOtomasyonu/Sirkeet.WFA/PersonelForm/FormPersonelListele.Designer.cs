namespace Sirkeet.WFA.PersonelForm
{
    partial class FormPersonelListele
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.nmrMaas = new System.Windows.Forms.NumericUpDown();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.rbBugunGeldimi = new System.Windows.Forms.RadioButton();
            this.rbIstenCiktimi = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCalistigiGun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(1035, 569);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(229, 22);
            this.txtArama.TabIndex = 54;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(905, 566);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 30);
            this.label8.TabIndex = 53;
            this.label8.Text = "Arama Yap :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Tomato;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGuncelle.Location = new System.Drawing.Point(195, 530);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(228, 62);
            this.btnGuncelle.TabIndex = 52;
            this.btnGuncelle.Text = "Değişiklikleri Kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(431, 18);
            this.dgvListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(789, 523);
            this.dgvListe.TabIndex = 51;
            this.dgvListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellContentClick);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(192, 391);
            this.cmbDepartman.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(229, 24);
            this.cmbDepartman.TabIndex = 50;
            // 
            // nmrMaas
            // 
            this.nmrMaas.DecimalPlaces = 2;
            this.nmrMaas.Location = new System.Drawing.Point(192, 341);
            this.nmrMaas.Margin = new System.Windows.Forms.Padding(4);
            this.nmrMaas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrMaas.Name = "nmrMaas";
            this.nmrMaas.Size = new System.Drawing.Size(231, 22);
            this.nmrMaas.TabIndex = 49;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(192, 178);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(229, 22);
            this.txtTelefon.TabIndex = 48;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(192, 123);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(229, 22);
            this.dtpBaslangic.TabIndex = 47;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(192, 230);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(229, 89);
            this.txtAdres.TabIndex = 46;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(192, 75);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(229, 22);
            this.txtSoyad.TabIndex = 45;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(192, 23);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(229, 22);
            this.txtAd.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(53, 386);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 30);
            this.label7.TabIndex = 43;
            this.label7.Text = "Departman :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.Location = new System.Drawing.Point(39, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 30);
            this.label6.TabIndex = 42;
            this.label6.Text = "Günlük Maaş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(107, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Adres :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(95, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 30);
            this.label4.TabIndex = 40;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 39;
            this.label3.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(99, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(128, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Adı :";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tomato;
            this.btnSil.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSil.Location = new System.Drawing.Point(31, 530);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 62);
            this.btnSil.TabIndex = 55;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rbBugunGeldimi
            // 
            this.rbBugunGeldimi.AutoSize = true;
            this.rbBugunGeldimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBugunGeldimi.ForeColor = System.Drawing.Color.Maroon;
            this.rbBugunGeldimi.Location = new System.Drawing.Point(431, 549);
            this.rbBugunGeldimi.Margin = new System.Windows.Forms.Padding(4);
            this.rbBugunGeldimi.Name = "rbBugunGeldimi";
            this.rbBugunGeldimi.Size = new System.Drawing.Size(213, 24);
            this.rbBugunGeldimi.TabIndex = 56;
            this.rbBugunGeldimi.TabStop = true;
            this.rbBugunGeldimi.Text = "Personel Bugün Geldi";
            this.rbBugunGeldimi.UseVisualStyleBackColor = true;
            // 
            // rbIstenCiktimi
            // 
            this.rbIstenCiktimi.AutoSize = true;
            this.rbIstenCiktimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbIstenCiktimi.ForeColor = System.Drawing.Color.Maroon;
            this.rbIstenCiktimi.Location = new System.Drawing.Point(705, 549);
            this.rbIstenCiktimi.Margin = new System.Windows.Forms.Padding(4);
            this.rbIstenCiktimi.Name = "rbIstenCiktimi";
            this.rbIstenCiktimi.Size = new System.Drawing.Size(189, 24);
            this.rbIstenCiktimi.TabIndex = 57;
            this.rbIstenCiktimi.TabStop = true;
            this.rbIstenCiktimi.Text = "İşten Bugün Ayrıldı";
            this.rbIstenCiktimi.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(-7, 437);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 30);
            this.label9.TabIndex = 58;
            this.label9.Text = "Çalıştığı Gün Sayısı :";
            // 
            // lblCalistigiGun
            // 
            this.lblCalistigiGun.AutoSize = true;
            this.lblCalistigiGun.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblCalistigiGun.Location = new System.Drawing.Point(210, 437);
            this.lblCalistigiGun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalistigiGun.Name = "lblCalistigiGun";
            this.lblCalistigiGun.Size = new System.Drawing.Size(0, 30);
            this.lblCalistigiGun.TabIndex = 59;
            // 
            // FormPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1281, 597);
            this.Controls.Add(this.lblCalistigiGun);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbIstenCiktimi);
            this.Controls.Add(this.rbBugunGeldimi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.nmrMaas);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPersonelListele";
            this.Text = "FormPersonelListele";
            this.Load += new System.EventHandler(this.FormPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.NumericUpDown nmrMaas;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RadioButton rbBugunGeldimi;
        private System.Windows.Forms.RadioButton rbIstenCiktimi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCalistigiGun;
    }
}