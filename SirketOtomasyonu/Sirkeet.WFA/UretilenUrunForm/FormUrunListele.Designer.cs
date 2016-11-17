namespace Sirkeet.WFA.UretilenUrunForm
{
    partial class FormUrunListele
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.nmrFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.rbStokEkle = new System.Windows.Forms.RadioButton();
            this.rbStokEksilt = new System.Windows.Forms.RadioButton();
            this.nmrStokDegisikligi = new System.Windows.Forms.NumericUpDown();
            this.lblStokmik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStokDegisikligi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnGuncelle.Location = new System.Drawing.Point(109, 326);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 40);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.Text = "Değişiklikleri kaydet";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(624, 406);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(139, 20);
            this.txtArama.TabIndex = 22;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Arama :";
            // 
            // dgvListe
            // 
            this.dgvListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(225, 3);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(538, 397);
            this.dgvListe.TabIndex = 20;
            this.dgvListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellContentClick);
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(80, 50);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(139, 21);
            this.cmbKategori.TabIndex = 19;
            // 
            // nmrFiyat
            // 
            this.nmrFiyat.DecimalPlaces = 2;
            this.nmrFiyat.Location = new System.Drawing.Point(80, 235);
            this.nmrFiyat.Name = "nmrFiyat";
            this.nmrFiyat.Size = new System.Drawing.Size(139, 20);
            this.nmrFiyat.TabIndex = 18;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(80, 12);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(139, 20);
            this.txtUrunAdi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stok Miktarı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kategorisi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ürün Adı :";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnSil.Location = new System.Drawing.Point(-7, 326);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 40);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rbStokEkle
            // 
            this.rbStokEkle.AutoSize = true;
            this.rbStokEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbStokEkle.ForeColor = System.Drawing.Color.Maroon;
            this.rbStokEkle.Location = new System.Drawing.Point(80, 111);
            this.rbStokEkle.Name = "rbStokEkle";
            this.rbStokEkle.Size = new System.Drawing.Size(81, 19);
            this.rbStokEkle.TabIndex = 25;
            this.rbStokEkle.TabStop = true;
            this.rbStokEkle.Text = "StokEkle";
            this.rbStokEkle.UseVisualStyleBackColor = true;
            this.rbStokEkle.CheckedChanged += new System.EventHandler(this.rbStokEkle_CheckedChanged);
            // 
            // rbStokEksilt
            // 
            this.rbStokEksilt.AutoSize = true;
            this.rbStokEksilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbStokEksilt.ForeColor = System.Drawing.Color.Maroon;
            this.rbStokEksilt.Location = new System.Drawing.Point(80, 134);
            this.rbStokEksilt.Name = "rbStokEksilt";
            this.rbStokEksilt.Size = new System.Drawing.Size(92, 19);
            this.rbStokEksilt.TabIndex = 26;
            this.rbStokEksilt.TabStop = true;
            this.rbStokEksilt.Text = "Stok Eksilt";
            this.rbStokEksilt.UseVisualStyleBackColor = true;
            this.rbStokEksilt.CheckedChanged += new System.EventHandler(this.rbStokEksilt_CheckedChanged);
            // 
            // nmrStokDegisikligi
            // 
            this.nmrStokDegisikligi.Location = new System.Drawing.Point(80, 159);
            this.nmrStokDegisikligi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nmrStokDegisikligi.Name = "nmrStokDegisikligi";
            this.nmrStokDegisikligi.Size = new System.Drawing.Size(139, 20);
            this.nmrStokDegisikligi.TabIndex = 27;
            this.nmrStokDegisikligi.Visible = false;
            // 
            // lblStokmik
            // 
            this.lblStokmik.AutoSize = true;
            this.lblStokmik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStokmik.ForeColor = System.Drawing.Color.Maroon;
            this.lblStokmik.Location = new System.Drawing.Point(81, 91);
            this.lblStokmik.Name = "lblStokmik";
            this.lblStokmik.Size = new System.Drawing.Size(0, 15);
            this.lblStokmik.TabIndex = 28;
            // 
            // FormUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(775, 438);
            this.Controls.Add(this.lblStokmik);
            this.Controls.Add(this.nmrStokDegisikligi);
            this.Controls.Add(this.rbStokEksilt);
            this.Controls.Add(this.rbStokEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.nmrFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUrunListele";
            this.Text = "FormUrunListele";
            this.Load += new System.EventHandler(this.FormUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrStokDegisikligi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.NumericUpDown nmrFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RadioButton rbStokEkle;
        private System.Windows.Forms.RadioButton rbStokEksilt;
        private System.Windows.Forms.NumericUpDown nmrStokDegisikligi;
        private System.Windows.Forms.Label lblStokmik;
    }
}