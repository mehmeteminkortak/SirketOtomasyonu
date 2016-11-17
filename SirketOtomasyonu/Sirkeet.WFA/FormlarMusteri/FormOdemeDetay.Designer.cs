namespace Sirkeet.WFA.FormlarMusteri
{
    partial class FormOdemeDetay
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBorcAlacakli = new System.Windows.Forms.Label();
            this.lblToplamOdedigiMiktar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpArama = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(12, 53);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(567, 344);
            this.dgvListe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçilen Siparişteki Toplam Ödediği Miktar :";
            // 
            // lblBorcAlacakli
            // 
            this.lblBorcAlacakli.AutoSize = true;
            this.lblBorcAlacakli.Location = new System.Drawing.Point(525, 417);
            this.lblBorcAlacakli.Name = "lblBorcAlacakli";
            this.lblBorcAlacakli.Size = new System.Drawing.Size(13, 13);
            this.lblBorcAlacakli.TabIndex = 2;
            this.lblBorcAlacakli.Text = "..";
            // 
            // lblToplamOdedigiMiktar
            // 
            this.lblToplamOdedigiMiktar.AutoSize = true;
            this.lblToplamOdedigiMiktar.Location = new System.Drawing.Point(223, 417);
            this.lblToplamOdedigiMiktar.Name = "lblToplamOdedigiMiktar";
            this.lblToplamOdedigiMiktar.Size = new System.Drawing.Size(16, 13);
            this.lblToplamOdedigiMiktar.TabIndex = 2;
            this.lblToplamOdedigiMiktar.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seçilen Siparişe Göre Borç Durumu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ödeme Tarihi Ara :";
            // 
            // dtpArama
            // 
            this.dtpArama.Location = new System.Drawing.Point(237, 12);
            this.dtpArama.Name = "dtpArama";
            this.dtpArama.Size = new System.Drawing.Size(200, 20);
            this.dtpArama.TabIndex = 5;
            this.dtpArama.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // FormOdemeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 448);
            this.Controls.Add(this.dtpArama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToplamOdedigiMiktar);
            this.Controls.Add(this.lblBorcAlacakli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListe);
            this.Name = "FormOdemeDetay";
            this.Text = "FormOdemeDetay";
            this.Load += new System.EventHandler(this.FormOdemeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBorcAlacakli;
        private System.Windows.Forms.Label lblToplamOdedigiMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpArama;
    }
}