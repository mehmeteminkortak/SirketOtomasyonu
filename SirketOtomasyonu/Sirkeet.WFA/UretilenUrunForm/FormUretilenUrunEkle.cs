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
    public partial class FormUretilenUrunEkle : Form
    {
        public FormUretilenUrunEkle()
        {
            InitializeComponent();
            dgvListe.Click += DgvListe_Click;
        }
       
        private void DgvListe_Click(object sender, EventArgs e)
        {
            int UretilenUrunID = int.Parse(dgvListe.SelectedRows[0].Cells[0].Value.ToString());
            seciliUretilenUrun = new UretilenUrunRepo().GetByID(UretilenUrunID);
            txtUrunAdi.Text = seciliUretilenUrun.UeretilenUrunAdi;
            int cmbkatinx = cmbKategori.FindString(seciliUretilenUrun.Kategori.KategoriAdi);
            cmbKategori.SelectedIndex =cmbkatinx;
        }

        public Sirket.Models.UretilenUrun seciliUretilenUrun { get; set; }
        private void FormUretilenUrunEkle_Load(object sender, EventArgs e)
        {
            dgvListe.DataSource = new UretilenUrunRepo().getAll();
            cmbKategori.DataSource = new KategoriRepo().getAll();
            dgvListe.Columns[1].Visible = false;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new UretilenUrunRepo().Insert(new UretilenUrun()
                {
                    UeretilenUrunAdi = txtUrunAdi.Text,
                    KategoriID = (cmbKategori.SelectedItem as Kategori).KategoriID
                });
                MessageBox.Show("Kayıt gerçekleşti");
                dgvListe.DataSource = new UretilenUrunRepo().getAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int secilisatir = dgvListe.SelectedCells[0].RowIndex;
            //seciliUretilenUrun = dgvListe.Rows[secilisatir].Cells[0].Value as Sirket.Models.UretilenUrun;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvListe.DataSource = new UretilenUrunRepo().Arama(txtArama.Text);
        }
    }
}
