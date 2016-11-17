namespace Sirkeet.WFA
{
    partial class FormTedarikci
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
            this.txttedarikciAdi = new System.Windows.Forms.TextBox();
            this.lblTedarikAd = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.lblTedarikAdres = new System.Windows.Forms.Label();
            this.txtSirketadı = new System.Windows.Forms.TextBox();
            this.lblsirketadı = new System.Windows.Forms.Label();
            this.txtTedarikSoyad = new System.Windows.Forms.TextBox();
            this.lblTedarikSoyad = new System.Windows.Forms.Label();
            this.lblTedarikTelefon = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lstTedarik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.lstTedarik)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(315, 16);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(465, 20);
            this.txtArama.TabIndex = 6;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txttedarikciAdi
            // 
            this.txttedarikciAdi.Location = new System.Drawing.Point(147, 14);
            this.txttedarikciAdi.Name = "txttedarikciAdi";
            this.txttedarikciAdi.Size = new System.Drawing.Size(151, 20);
            this.txttedarikciAdi.TabIndex = 9;
            // 
            // lblTedarikAd
            // 
            this.lblTedarikAd.AutoSize = true;
            this.lblTedarikAd.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTedarikAd.Location = new System.Drawing.Point(18, 12);
            this.lblTedarikAd.Name = "lblTedarikAd";
            this.lblTedarikAd.Size = new System.Drawing.Size(113, 24);
            this.lblTedarikAd.TabIndex = 8;
            this.lblTedarikAd.Text = "Tedarikci Adı :";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(147, 166);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(151, 71);
            this.txtadres.TabIndex = 11;
            // 
            // lblTedarikAdres
            // 
            this.lblTedarikAdres.AutoSize = true;
            this.lblTedarikAdres.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTedarikAdres.Location = new System.Drawing.Point(66, 162);
            this.lblTedarikAdres.Name = "lblTedarikAdres";
            this.lblTedarikAdres.Size = new System.Drawing.Size(54, 24);
            this.lblTedarikAdres.TabIndex = 10;
            this.lblTedarikAdres.Text = "Adres:";
            // 
            // txtSirketadı
            // 
            this.txtSirketadı.Location = new System.Drawing.Point(147, 112);
            this.txtSirketadı.Name = "txtSirketadı";
            this.txtSirketadı.Size = new System.Drawing.Size(151, 20);
            this.txtSirketadı.TabIndex = 13;
            // 
            // lblsirketadı
            // 
            this.lblsirketadı.AutoSize = true;
            this.lblsirketadı.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblsirketadı.Location = new System.Drawing.Point(36, 110);
            this.lblsirketadı.Name = "lblsirketadı";
            this.lblsirketadı.Size = new System.Drawing.Size(92, 24);
            this.lblsirketadı.TabIndex = 12;
            this.lblsirketadı.Text = "Şirket Adı :";
            // 
            // txtTedarikSoyad
            // 
            this.txtTedarikSoyad.Location = new System.Drawing.Point(147, 55);
            this.txtTedarikSoyad.Name = "txtTedarikSoyad";
            this.txtTedarikSoyad.Size = new System.Drawing.Size(151, 20);
            this.txtTedarikSoyad.TabIndex = 15;
            // 
            // lblTedarikSoyad
            // 
            this.lblTedarikSoyad.AutoSize = true;
            this.lblTedarikSoyad.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTedarikSoyad.Location = new System.Drawing.Point(5, 53);
            this.lblTedarikSoyad.Name = "lblTedarikSoyad";
            this.lblTedarikSoyad.Size = new System.Drawing.Size(129, 24);
            this.lblTedarikSoyad.TabIndex = 14;
            this.lblTedarikSoyad.Text = "Tedarikci Soyadı:";
            // 
            // lblTedarikTelefon
            // 
            this.lblTedarikTelefon.AutoSize = true;
            this.lblTedarikTelefon.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTedarikTelefon.Location = new System.Drawing.Point(57, 248);
            this.lblTedarikTelefon.Name = "lblTedarikTelefon";
            this.lblTedarikTelefon.Size = new System.Drawing.Size(63, 24);
            this.lblTedarikTelefon.TabIndex = 16;
            this.lblTedarikTelefon.Text = "Telefon:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Teal;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGuncelle.Location = new System.Drawing.Point(194, 299);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(104, 35);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Teal;
            this.btnSil.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSil.Location = new System.Drawing.Point(101, 299);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 35);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Teal;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKaydet.Location = new System.Drawing.Point(7, 299);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 35);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(147, 252);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(151, 20);
            this.txtTelefon.TabIndex = 21;
            // 
            // lstTedarik
            // 
            this.lstTedarik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTedarik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstTedarik.Location = new System.Drawing.Point(315, 53);
            this.lstTedarik.Name = "lstTedarik";
            this.lstTedarik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstTedarik.Size = new System.Drawing.Size(465, 281);
            this.lstTedarik.TabIndex = 22;
            // 
            // FormTedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(796, 353);
            this.Controls.Add(this.lstTedarik);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblTedarikTelefon);
            this.Controls.Add(this.txtTedarikSoyad);
            this.Controls.Add(this.lblTedarikSoyad);
            this.Controls.Add(this.txtSirketadı);
            this.Controls.Add(this.lblsirketadı);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.lblTedarikAdres);
            this.Controls.Add(this.txttedarikciAdi);
            this.Controls.Add(this.lblTedarikAd);
            this.Controls.Add(this.txtArama);
            this.Name = "FormTedarikci";
            this.Text = "FormTedarikci";
            this.Load += new System.EventHandler(this.FormTedarikci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstTedarik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.TextBox txttedarikciAdi;
        private System.Windows.Forms.Label lblTedarikAd;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label lblTedarikAdres;
        private System.Windows.Forms.TextBox txtSirketadı;
        private System.Windows.Forms.Label lblsirketadı;
        private System.Windows.Forms.TextBox txtTedarikSoyad;
        private System.Windows.Forms.Label lblTedarikSoyad;
        private System.Windows.Forms.Label lblTedarikTelefon;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.DataGridView lstTedarik;
    }
}