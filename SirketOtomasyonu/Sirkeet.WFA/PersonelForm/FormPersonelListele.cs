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

namespace Sirkeet.WFA.PersonelForm
{
    public partial class FormPersonelListele : Form
    {
        public FormPersonelListele()
        {
            InitializeComponent();
            dgvListe.Click += DgvListe_Click;
        }

        private void DgvListe_Click(object sender, EventArgs e)
        {
            int PersonelID = int.Parse(dgvListe.SelectedRows[0].Cells[0].Value.ToString());
            SeciliPersonel = new PersonelRepo().GetByID(PersonelID);
            txtAd.Text = SeciliPersonel.PersonelAdi;
            txtSoyad.Text = SeciliPersonel.PersonelSoyadi;
            nmrMaas.Value = SeciliPersonel.GunlukMaas;
            txtTelefon.Text = SeciliPersonel.Telefon;
            txtAdres.Text = SeciliPersonel.Adres;
            dtpBaslangic.Value = SeciliPersonel.BaslangicTarihi;
            lblCalistigiGun.Text = SeciliPersonel.CalistigiGunSayisi.ToString();
            int cmbdepindx = cmbDepartman.FindString(SeciliPersonel.Departman.DepartmanAdi);
            cmbDepartman.SelectedIndex = cmbdepindx;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliPersonel == null)
            {
                MessageBox.Show("Nesne secilmedi");
                return;
            }
            var guncellenecekPersonel = new PersonelRepo().GetByID(SeciliPersonel.PersonelID);
            if (rbBugunGeldimi.Checked)
            {
                guncellenecekPersonel.CalistigiGunSayisi = guncellenecekPersonel.CalistigiGunSayisi + 1;
                new PersonelRepo().Update();
            }
            else if (rbIstenCiktimi.Checked)
            {
                guncellenecekPersonel.CıkısTarihi = DateTime.Now;
                new PersonelRepo().Update();
            }
            string CalistigiGun = SeciliPersonel.CalistigiGunSayisi.ToString();
            guncellenecekPersonel.PersonelAdi = txtAd.Text;
            guncellenecekPersonel.PersonelSoyadi = txtSoyad.Text;
            guncellenecekPersonel.GunlukMaas = nmrMaas.Value;
            guncellenecekPersonel.Telefon = txtTelefon.Text;
            guncellenecekPersonel.Adres = txtAdres.Text;
            guncellenecekPersonel.BaslangicTarihi = dtpBaslangic.Value;
            CalistigiGun = lblCalistigiGun.Text;
            guncellenecekPersonel.DepartmanID = (cmbDepartman.SelectedItem as Sirket.Models.Departman).DepartmanID;
            new PersonelRepo().Update();
            dgvListe.DataSource = new PersonelRepo().getAll();
        }
        public Personel SeciliPersonel { get; set; }
        private void dgvListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void FormPersonelListele_Load(object sender, EventArgs e)
        {
            dgvListe.DataSource = new PersonelRepo().getAll();
            cmbDepartman.DataSource = new DepartmanRepo().getAll();
            dgvListe.Columns[1].Visible = false;
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SeciliPersonel == null)
            {
                MessageBox.Show("Nesne secilmedi");
                return;
            }
            new PersonelRepo().Delete(SeciliPersonel);
            dgvListe.DataSource = new PersonelRepo().getAll();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            new PersonelRepo().Arama(txtArama.Text);
        }
    }
}
