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

namespace Sirkeet.WFA.UretilenUrunForm
{
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
            dgvListe.Click += DgvListe_Click;
        }

        private void DgvListe_Click(object sender, EventArgs e)
        {
            int UretilenUrunID = int.Parse(dgvListe.SelectedRows[0].Cells[0].Value.ToString());
            SeciliUrun = new UretilenUrunRepo().GetByID(UretilenUrunID);
            txtUrunAdi.Text = SeciliUrun.UeretilenUrunAdi;
            lblStokmik.Text = SeciliUrun.Stok.ToString();
            nmrFiyat.Value = SeciliUrun.Fiyat;
            int cmbkategorinx = cmbKategori.FindString(SeciliUrun.Kategori.KategoriAdi);
            cmbKategori.SelectedIndex = cmbkategorinx;
        }

        private void FormUrunListele_Load(object sender, EventArgs e)
        {
            dgvListe.DataSource = new UretilenUrunRepo().getAll();
            cmbKategori.DataSource = new KategoriRepo().getAll();
            dgvListe.Columns[1].Visible = false;
        }
        public UretilenUrun  SeciliUrun { get; set; }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliUrun==null)
            {
                MessageBox.Show("Nesne secilmedi");
                return;
            }
            var guncellenecekUrun = new UretilenUrunRepo().GetByID(SeciliUrun.UretilenUrunID);
            if (rbStokEkle.Checked)
            {
                guncellenecekUrun.Stok = guncellenecekUrun.Stok + (int)nmrStokDegisikligi.Value;
            }
            else if(rbStokEksilt.Checked)
            {
                
                guncellenecekUrun.Stok = guncellenecekUrun.Stok - (int)nmrStokDegisikligi.Value;
            }
            guncellenecekUrun.UeretilenUrunAdi=txtUrunAdi.Text ;
            guncellenecekUrun.Fiyat=nmrFiyat.Value ;
            guncellenecekUrun.KategoriID=(cmbKategori.SelectedItem as Kategori).KategoriID;
            new UretilenUrunRepo().Update();
            dgvListe.DataSource = new UretilenUrunRepo().getAll();
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilensatir = dgvListe.SelectedCells[0].RowIndex;
            //SeciliUrun = dgvListe.Rows[secilensatir].Cells[0].Value as UretilenUrun;
            //txtUrunAdi.Text = SeciliUrun.UeretilenUrunAdi;
            //nmrStokMiktari.Value = SeciliUrun.Stok;
            //nmrFiyat.Value = SeciliUrun.Fiyat;
            //cmbKategori.SelectedItem = SeciliUrun.KategoriID;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            new UretilenUrunRepo().Delete(SeciliUrun);
            dgvListe.DataSource = new UretilenUrunRepo().getAll();
        }

        private void rbStokEkle_CheckedChanged(object sender, EventArgs e)
        {
            nmrStokDegisikligi.Visible = true;
        }

        private void rbStokEksilt_CheckedChanged(object sender, EventArgs e)
        {
            nmrStokDegisikligi.Visible = true;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            new UretilenUrunRepo().Arama(txtArama.Text);
        }
    }
}
