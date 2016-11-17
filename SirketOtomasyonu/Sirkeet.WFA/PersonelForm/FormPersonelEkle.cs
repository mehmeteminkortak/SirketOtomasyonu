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

namespace Sirkeet.WFA
{
    public partial class FormPersonelEkle : Form
    {
        public FormPersonelEkle()
        {
            InitializeComponent();
            dgvListe.Click += DgvListe_Click;
        }
       
        private void DgvListe_Click(object sender, EventArgs e)
        {
            int PersonelID = int.Parse(dgvListe.SelectedRows[0].Cells[0].Value.ToString());
            seciliPersonel = new PersonelRepo().GetByID(PersonelID);
            txtAd.Text = seciliPersonel.PersonelAdi;
            txtSoyad.Text = seciliPersonel.PersonelSoyadi;
            dtpBaslangic.Value = seciliPersonel.BaslangicTarihi;
            txtTelefon.Text = seciliPersonel.Telefon;
            txtAdres.Text = seciliPersonel.Adres;
            nmrMaas.Value = seciliPersonel.GunlukMaas;
            cmbDepartman.SelectedItem = seciliPersonel.DepartmanID;
        }

        private void FormPersonelEkle_Load(object sender, EventArgs e)
        {
            cmbDepartman.DataSource = new DepartmanRepo().getAll();
            dgvListe.DataSource = new PersonelRepo().getAll();
            dgvListe.Columns[1].Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new PersonelRepo().Insert(new Personel()
                {
                    PersonelAdi = txtAd.Text,
                    PersonelSoyadi = txtSoyad.Text,
                    BaslangicTarihi = dtpBaslangic.Value,
                    Telefon = txtTelefon.Text,
                    Adres = txtAdres.Text,
                    GunlukMaas = nmrMaas.Value,
                    DepartmanID = (cmbDepartman.SelectedItem as Sirket.Models.Departman).DepartmanID
                });
                MessageBox.Show("Kayıt Gerceklesti");
                dgvListe.DataSource = new PersonelRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Personel seciliPersonel { get; set; }
        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvListe.DataSource = new PersonelRepo().Arama(txtArama.Text);
        }
    }
}
