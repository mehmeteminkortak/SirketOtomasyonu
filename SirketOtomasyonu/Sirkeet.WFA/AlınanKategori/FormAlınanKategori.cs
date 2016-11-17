using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirket.BLL;
using System.Windows.Forms;
using Sirket.Models;

namespace Sirkeet.WFA
{
    public partial class FormAlınanKategori : Form
    {
        public FormAlınanKategori()
        {
            InitializeComponent();
        }

        private void FormAlınanKategori_Load(object sender, EventArgs e)
        {
           listBox1.DataSource= new AlinanKategoriRepo().getAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new AlinanKategoriRepo().Insert(new AlınanKategori()
                {
                     AlınanKategoriAdi=txtAlınanKategoriad.Text
                });
                MessageBox.Show("Kategori Kaydedildi.");
                listBox1.DataSource = new AlinanKategoriRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public AlınanKategori secilenKategori { get; set; }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenKategori==null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            new AlinanKategoriRepo().Delete(secilenKategori);
            listBox1.DataSource = new AlinanKategoriRepo().getAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKategori = listBox1.SelectedItem as AlınanKategori;
            txtAlınanKategoriad.Text = secilenKategori.AlınanKategoriAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKategori==null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            var guncellenecekKategori = new AlinanKategoriRepo().GetByID(secilenKategori.AlınanKategoriID);
            guncellenecekKategori.AlınanKategoriAdi = txtAlınanKategoriad.Text;
            try
            {
                new AlinanKategoriRepo().Update();
                listBox1.DataSource = new AlinanKategoriRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
           listBox1.DataSource= new AlinanKategoriRepo().Arama(txtArama.Text);
        }

        private void txtAlınanKategoriad_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
