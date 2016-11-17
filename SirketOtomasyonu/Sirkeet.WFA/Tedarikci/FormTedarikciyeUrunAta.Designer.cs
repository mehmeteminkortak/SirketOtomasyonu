namespace Sirkeet.WFA.Tedarikci
{
    partial class FormTedarikciyeUrunAta
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
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cListbox = new System.Windows.Forms.CheckedListBox();
            this.btnKAydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(100, 12);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(174, 21);
            this.cmbTedarikci.TabIndex = 0;
            this.cmbTedarikci.SelectedIndexChanged += new System.EventHandler(this.cmbTedarikci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tedarikçi";
            // 
            // cListbox
            // 
            this.cListbox.FormattingEnabled = true;
            this.cListbox.Location = new System.Drawing.Point(44, 54);
            this.cListbox.Name = "cListbox";
            this.cListbox.Size = new System.Drawing.Size(235, 169);
            this.cListbox.TabIndex = 2;
            // 
            // btnKAydet
            // 
            this.btnKAydet.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKAydet.Location = new System.Drawing.Point(44, 243);
            this.btnKAydet.Name = "btnKAydet";
            this.btnKAydet.Size = new System.Drawing.Size(230, 32);
            this.btnKAydet.TabIndex = 3;
            this.btnKAydet.Text = "Değişiklilkeri Kaydet";
            this.btnKAydet.UseVisualStyleBackColor = false;
            this.btnKAydet.Click += new System.EventHandler(this.btnKAydet_Click);
            // 
            // FormTedarikciyeUrunAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 320);
            this.Controls.Add(this.btnKAydet);
            this.Controls.Add(this.cListbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTedarikci);
            this.Name = "FormTedarikciyeUrunAta";
            this.Text = "FormTedarikciyeUrunAta";
            this.Load += new System.EventHandler(this.FormTedarikciyeUrunAta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cListbox;
        private System.Windows.Forms.Button btnKAydet;
    }
}