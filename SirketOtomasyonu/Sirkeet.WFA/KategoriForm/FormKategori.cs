using Sirket.BLL;
using Sirket.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirkeet.WFA.KategoriForm
{
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        private void FormKategori_Load(object sender, EventArgs e)
        {
            lstList.DataSource = new KategoriRepo().getAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtKategoriAdi.Text

                });
            MessageBox.Show("Kategori Kaydedildi.");
            lstList.DataSource = new KategoriRepo().getAll();
        }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }
        public Kategori SecilenKategori { get; set; }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SecilenKategori == null)
            {
                MessageBox.Show("Nesne Secilmedi.");
                return;
            }
            new KategoriRepo().Delete(SecilenKategori);
            lstList.DataSource = new KategoriRepo().getAll();


        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenKategori = lstList.SelectedItem as Kategori;
            txtKategoriAdi.Text = SecilenKategori.KategoriAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (SecilenKategori == null)
            {
                MessageBox.Show("Nesne Secilmedi");
                return;
            }
            var guncellenecekkategori = new KategoriRepo().GetByID(SecilenKategori.KategoriID);
            guncellenecekkategori.KategoriAdi = txtKategoriAdi.Text;
            try
            {
                new KategoriRepo().Update();
                lstList.DataSource = new KategoriRepo().getAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            lstList.DataSource = new KategoriRepo().Arama(txtArama.Text);
        }
    }
}
