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

namespace Sirkeet.WFA.FormlarMusteri
{
    public partial class FormSiparisDetay : Form
    {
        public FormSiparisDetay()
        {
            InitializeComponent();
            dgvSiparisler.Click += DgvSiparisler_Click;
        }

        private void DgvSiparisler_Click(object sender, EventArgs e)
        {
            int SiparisID = int.Parse(dgvSiparisler.SelectedRows[0].Cells[0].Value.ToString());
            SeciliSiparis = new SiparisRepo().GetByID(SiparisID);
            if (new SiparisDetayRepo().getAll().Where(x => x.SiparisID == SeciliSiparis.SiparisID).Count() == 0)
            {
                btnEkle.Enabled = true;
            }
            else if (new SiparisDetayRepo().getAll().Where(x => x.SiparisID == SeciliSiparis.SiparisID).Count() > 0)
            {
                btnEkle.Enabled = false;
            }

            SecilenSiparisDetay = new SiparisDetayRepo().getAll().Where(x => x.SiparisID == SeciliSiparis.SiparisID).ToList();
            if (SecilenSiparisDetay.Count!=0)
                dtpSonOdemeTarihi.Value = SecilenSiparisDetay[0].SonOdemeTarihi;
            
            if (SeciliSiparis!=null)
            { 
                btnOdemeGEcmisi.Enabled = true;
                btnGuncelle.Enabled = true;
            }
        }

        private void FormSiparisDetay_Load(object sender, EventArgs e)
        {
            cmbOdemeSekli.SelectedIndex = 0;
            cmbMusteri.DataSource = new MusteriRepo().getAll();
        }
        List<SiparisDetay> SecilenSiparisDetay = new List<SiparisDetay>();
        public Siparis SeciliSiparis { get; set; }
        public Musteri SeciliMusteri { get; set; }
        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliMusteri = new MusteriRepo().GetByID((cmbMusteri.SelectedItem as Musteri).MusteriID);
            dgvSiparisler.DataSource = new SiparisRepo().getAll().Where(x => x.MusteriID == SeciliMusteri.MusteriID).ToList();
            dgvSiparisler.Columns[1].Visible = false;
            dgvSiparisler.Columns[2].Visible = false;
            dgvSiparisler.Columns[9].Visible = false;

            decimal ToplamAldigiUrunDegeri = new SiparisRepo().getAll().Where(x => x.MusteriID == SeciliMusteri.MusteriID).Sum(x => x.OdenecekTutar);
            decimal ToplamOdedigiMiktar = new OdemeDetayRepo().getAll().Where(x => x.MusteriID == SeciliMusteri.MusteriID).Sum(x => x.OdedigiMiktar);

            lblToplamOdedigiMiktar.Text = ToplamOdedigiMiktar.ToString();

            if (ToplamAldigiUrunDegeri>ToplamOdedigiMiktar)
                lblBorcAlacakli.Text = $"Borçlu : {  ToplamAldigiUrunDegeri-ToplamOdedigiMiktar  }";
            else
                lblBorcAlacakli.Text = $"Alacaklı : {ToplamOdedigiMiktar-ToplamAldigiUrunDegeri}";
            
        }

        private void txtSiparisAra_TextChanged(object sender, EventArgs e)
        {
            dgvSiparisler.DataSource = new SiparisRepo().Arama(txtSiparisAra.Text).Where(x => x.MusteriID == (cmbMusteri.SelectedItem as Musteri).MusteriID).ToList();
            dgvSiparisler.Columns[1].Visible = false;
            dgvSiparisler.Columns[2].Visible = false;
            dgvSiparisler.Columns[9].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (SeciliSiparis == null)
            {
                MessageBox.Show("Sipariş Seçilmedi");
                return;
            }
            try
            {
                new SiparisDetayRepo().Insert(new SiparisDetay()
                {
                    MusteriID = SeciliMusteri.MusteriID,
                    SiparisID = SeciliSiparis.SiparisID,
                    SonOdemeTarihi = dtpSonOdemeTarihi.Value
                });

                var SoneklenenSiparisDetay = new SiparisDetayRepo().getAll().OrderByDescending(x => x.SiparisDetayID).Take(1).ToList();
                new OdemeDetayRepo().Insert(new OdemeDetay()
                {
                    OdemeSekli = cmbOdemeSekli.Text,
                    SiparisDetayID = SoneklenenSiparisDetay[0].SiparisDetayID,
                    OdedigiMiktar = nmrOdemeEkle.Value,
                    MusteriID = SeciliMusteri.MusteriID,
                    SiparisID = SeciliSiparis.SiparisID
                });
                MessageBox.Show("Kayıt işlemi gerçekleşti");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SeciliSiparis = null;
                btnEkle.Enabled = false;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliSiparis == null)
            {
                MessageBox.Show("Sipariş Seçiniz");
                return;
            }
            try
            {
                if (SecilenSiparisDetay[0].SonOdemeTarihi != dtpSonOdemeTarihi.Value)
                {
                    var guncellenecekSiparisDetay = new SiparisDetayRepo().getAll().Where(x => x.SiparisID == SeciliSiparis.SiparisID).ToList();
                    guncellenecekSiparisDetay[0].SonOdemeTarihi = dtpSonOdemeTarihi.Value;
                    new SiparisDetayRepo().Update();
                    MessageBox.Show("Son Ödeme Tarihi Değiştirildi");
                }
                if (nmrOdemeEkle.Value != 0)
                {
                    new OdemeDetayRepo().Insert(new OdemeDetay()
                    {
                        OdemeSekli = cmbOdemeSekli.Text,
                        SiparisDetayID = SecilenSiparisDetay[0].SiparisDetayID,
                        OdedigiMiktar = nmrOdemeEkle.Value,
                        MusteriID = SeciliMusteri.MusteriID,
                        SiparisID = SeciliSiparis.SiparisID
                    });
                    MessageBox.Show("Ödeme Eklendi");
                }
                SeciliSiparis = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SeciliSiparis = null;
                btnGuncelle.Enabled = false;
            }
        }

        private void dgvSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdemeGEcmisi_Click(object sender, EventArgs e)
        {
            FormOdemeDetay frmOdemeDetay = new FormOdemeDetay();
            frmOdemeDetay.SeciliSiparis = SeciliSiparis;
            frmOdemeDetay.SeciliMusteri = SeciliMusteri;
            frmOdemeDetay.Show();
            this.Close();
        }
    }
}
