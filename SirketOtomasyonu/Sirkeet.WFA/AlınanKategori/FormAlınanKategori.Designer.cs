namespace Sirkeet.WFA
{
    partial class FormAlınanKategori
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.txtAlınanKategoriad = new System.Windows.Forms.TextBox();
            this.lblAlınanKategoriAdı = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGuncelle.Location = new System.Drawing.Point(285, 299);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(109, 40);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSil.Location = new System.Drawing.Point(142, 299);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 40);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKaydet.Location = new System.Drawing.Point(3, 299);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 40);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 212);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(16, 264);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(254, 20);
            this.txtArama.TabIndex = 9;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // txtAlınanKategoriad
            // 
            this.txtAlınanKategoriad.Location = new System.Drawing.Point(189, 12);
            this.txtAlınanKategoriad.Name = "txtAlınanKategoriad";
            this.txtAlınanKategoriad.Size = new System.Drawing.Size(155, 20);
            this.txtAlınanKategoriad.TabIndex = 8;
            this.txtAlınanKategoriad.TextChanged += new System.EventHandler(this.txtAlınanKategoriad_TextChanged);
            // 
            // lblAlınanKategoriAdı
            // 
            this.lblAlınanKategoriAdı.AutoSize = true;
            this.lblAlınanKategoriAdı.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAlınanKategoriAdı.Location = new System.Drawing.Point(12, 9);
            this.lblAlınanKategoriAdı.Name = "lblAlınanKategoriAdı";
            this.lblAlınanKategoriAdı.Size = new System.Drawing.Size(154, 24);
            this.lblAlınanKategoriAdı.TabIndex = 7;
            this.lblAlınanKategoriAdı.Text = "Alınan Kategori Adı:";
            // 
            // FormAlınanKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 348);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtAlınanKategoriad);
            this.Controls.Add(this.lblAlınanKategoriAdı);
            this.Name = "FormAlınanKategori";
            this.Text = "FormAlınanKategori";
            this.Load += new System.EventHandler(this.FormAlınanKategori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.TextBox txtAlınanKategoriad;
        private System.Windows.Forms.Label lblAlınanKategoriAdı;
    }
}