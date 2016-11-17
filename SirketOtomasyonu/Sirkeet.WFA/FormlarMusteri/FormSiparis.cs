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
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
            dgvSiparisListe.Click += DgvSiparisListe_Click;
        }


        private void DgvSiparisListe_Click(object sender, EventArgs e)
        {
            int SiparisID = int.Parse(dgvSiparisListe.SelectedRows[0].Cells[0].Value.ToString());
            seciliSiparis = new SiparisRepo().GetByID(SiparisID);
            nmrUrunAdedi.Value = (int)seciliSiparis.Adet;
            nmrUrunFiyati.Value = seciliSiparis.Fiyat;
            int cmbmusteriIndex = cmbMusteri.FindString($"{seciliSiparis.Musteri.MusteriAdi} {seciliSiparis.Musteri.MusteriSoyadi}");
            cmbMusteri.SelectedIndex = cmbmusteriIndex;
            int cmburunindx = cmbUrun.FindString(seciliSiparis.UretilenUrun.UeretilenUrunAdi);
            cmbUrun.SelectedIndex = cmburunindx;
            dtpSiparisTarihi.Value = seciliSiparis.SiparisTarihi;
            txtTeslimatAdres.Text = seciliSiparis.TeslimatAdresi;
            dtpTeslimatTarihi.Value = seciliSiparis.TeslimTarihi;

        }

        private void FormSiparis_Load(object sender, EventArgs e)
        {
            cmbMusteri.DataSource = new MusteriRepo().getAll();
            cmbUrun.DataSource = new UretilenUrunRepo().getAll();
            dgvSiparisListe.DataSource = new SiparisRepo().getAll();
            dgvSiparisListe.Columns[1].Visible = false;
            dgvSiparisListe.Columns[2].Visible = false;
        }
        public UretilenUrun SeciliUrun { get; set; }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SeciliUrun =new UretilenUrunRepo().GetByID((cmbUrun.SelectedItem as UretilenUrun).UretilenUrunID);
                SeciliUrun.Stok = SeciliUrun.Stok - (int)nmrUrunAdedi.Value;
                new UretilenUrunRepo().Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                new SiparisRepo().Insert(new Siparis()
                {
                    SiparisTarihi = dtpSiparisTarihi.Value,
                    TeslimTarihi = dtpTeslimatTarihi.Value,
                    MusteriID = (cmbMusteri.SelectedItem as Musteri).MusteriID,
                    UretilenUrunID = (cmbUrun.SelectedItem as UretilenUrun).UretilenUrunID,
                    TeslimatAdresi = txtTeslimatAdres.Text,
                    Adet = (int)nmrUrunAdedi.Value,
                    Fiyat = nmrUrunFiyati.Value

                });
                MessageBox.Show("Kayıt Gerceklesti");
                dgvSiparisListe.DataSource = new SiparisRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliSiparis == null)
            {
                MessageBox.Show("Nesne Secilmedi");
                return;
            }
            new SiparisRepo().Delete(seciliSiparis);
            dgvSiparisListe.DataSource = new SiparisRepo().getAll();
        }
        public Siparis seciliSiparis { get; set; }
        private void dgvSiparisListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliSiparis == null)
            {
                MessageBox.Show("Nesne Secilmedi");
                return;
            }
            var guncellenecekSiparis = new SiparisRepo().GetByID(seciliSiparis.SiparisID);
            guncellenecekSiparis.Adet = (int)nmrUrunAdedi.Value;
            guncellenecekSiparis.Fiyat = nmrUrunFiyati.Value;
            guncellenecekSiparis.MusteriID = (cmbMusteri.SelectedItem as Musteri).MusteriID;
            guncellenecekSiparis.SiparisTarihi = dtpSiparisTarihi.Value;
            guncellenecekSiparis.TeslimatAdresi = txtTeslimatAdres.Text;
            guncellenecekSiparis.TeslimTarihi = dtpTeslimatTarihi.Value;
            guncellenecekSiparis.UretilenUrunID = (cmbUrun.SelectedItem as UretilenUrun).UretilenUrunID;
            try
            {
                new SiparisRepo().Update();
                dgvSiparisListe.DataSource = new SiparisRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliUrun = (cmbUrun.SelectedItem as UretilenUrun);
            nmrUrunFiyati.Value = SeciliUrun.Fiyat;
        }
    }
}
