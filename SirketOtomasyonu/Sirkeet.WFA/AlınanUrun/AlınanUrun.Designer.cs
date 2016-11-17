namespace Sirkeet.WFA
{
    partial class AlınanUrun
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
            this.txtAlınanUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAlınanKategori = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrAlınanStokMiktarı = new System.Windows.Forms.NumericUpDown();
            this.nmrAlınanUrubFiyar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAlınanStokMiktarı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAlınanUrubFiyar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlınanUrunAdi
            // 
            this.txtAlınanUrunAdi.Location = new System.Drawing.Point(172, 23);
            this.txtAlınanUrunAdi.Name = "txtAlınanUrunAdi";
            this.txtAlınanUrunAdi.Size = new System.Drawing.Size(178, 20);
            this.txtAlınanUrunAdi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alınan Ürün Adı :";
            // 
            // cmbAlınanKategori
            // 
            this.cmbAlınanKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlınanKategori.FormattingEnabled = true;
            this.cmbAlınanKategori.Location = new System.Drawing.Point(169, 161);
            this.cmbAlınanKategori.Name = "cmbAlınanKategori";
            this.cmbAlınanKategori.Size = new System.Drawing.Size(178, 21);
            this.cmbAlınanKategori.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(23, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Alınan Kategori :";
            // 
            // nmrAlınanStokMiktarı
            // 
            this.nmrAlınanStokMiktarı.Location = new System.Drawing.Point(172, 118);
            this.nmrAlınanStokMiktarı.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmrAlınanStokMiktarı.Name = "nmrAlınanStokMiktarı";
            this.nmrAlınanStokMiktarı.Size = new System.Drawing.Size(178, 20);
            this.nmrAlınanStokMiktarı.TabIndex = 25;
            // 
            // nmrAlınanUrubFiyar
            // 
            this.nmrAlınanUrubFiyar.DecimalPlaces = 2;
            this.nmrAlınanUrubFiyar.Location = new System.Drawing.Point(172, 64);
            this.nmrAlınanUrubFiyar.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrAlınanUrubFiyar.Name = "nmrAlınanUrubFiyar";
            this.nmrAlınanUrubFiyar.Size = new System.Drawing.Size(178, 20);
            this.nmrAlınanUrubFiyar.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Alınan Stok Miktarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Alınan Ürün Fiyatı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 313);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGuncelle.Location = new System.Drawing.Point(246, 269);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(112, 35);
            this.btnGuncelle.TabIndex = 31;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSil.Location = new System.Drawing.Point(128, 269);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(112, 35);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnKaydet.Location = new System.Drawing.Point(10, 269);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 35);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // AlınanUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(809, 345);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbAlınanKategori);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrAlınanStokMiktarı);
            this.Controls.Add(this.nmrAlınanUrubFiyar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlınanUrunAdi);
            this.Controls.Add(this.label1);
            this.Name = "AlınanUrun";
            this.Text = "AlınanUrun";
            this.Load += new System.EventHandler(this.AlınanUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAlınanStokMiktarı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAlınanUrubFiyar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlınanUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAlınanKategori;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrAlınanStokMiktarı;
        private System.Windows.Forms.NumericUpDown nmrAlınanUrubFiyar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
    }
}