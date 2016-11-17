using Sirkeet.WFA;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FormAlınanKategori frmalkat;
        private void aLINANÜRÜNKATEGORİSİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmalkat == null || frmalkat.IsDisposed)
                frmalkat = new FormAlınanKategori();
            frmalkat.MdiParent = this;
            frmalkat.Text = "Alınan Kategori Paneli";
            frmalkat.Show();
        }
        KategoriForm.FormKategori frmKat;
        private void üRETİLENÜRÜNKATEGOROSİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKat == null || frmKat.IsDisposed)
                frmKat = new KategoriForm.FormKategori();
            frmKat.MdiParent = this;
            frmKat.Text = "Üretilen Kategori Paneli";
            frmKat.Show();
        }
        AlınanUrun alnUrn;
        private void aLINANÜRÜNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alnUrn == null || alnUrn.IsDisposed)
                alnUrn = new AlınanUrun();
            alnUrn.MdiParent = this;
            alnUrn.Text = "Alınan Ürün Paneli";
            alnUrn.Show();
        }
        UretilenUrunForm.FormUretilenUrunEkle frmUret;
        private void eKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUret == null || frmUret.IsDisposed)
                frmUret = new UretilenUrunForm.FormUretilenUrunEkle();
            frmUret.MdiParent = this;
            frmUret.Text = "Uretılen urun Paneli";
            frmUret.Show();
        }
        Departman.FormDepartman dprm;
        private void dEPARTMANİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dprm == null || dprm.IsDisposed)
                dprm = new Departman.FormDepartman();
            dprm.MdiParent = this;
            dprm.Text = "Departman Paneli";
            dprm.Show();
        }
        FormMusteri frmmusteri;
        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmmusteri == null || frmmusteri.IsDisposed)
                frmmusteri = new FormMusteri();
            frmmusteri.MdiParent = this;
            frmmusteri.Text = "Müşteri Paneli";
            frmmusteri.Show();
        }
        FormSiparis frmSiparis;
        private void sİPARİŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSiparis == null || frmSiparis.IsDisposed)
                frmSiparis = new FormSiparis();
            frmSiparis.MdiParent = this;
            frmSiparis.Text = "Müşteri Sipariş Paneli";
            frmSiparis.Show();
        }
        FormPersonelEkle frmPerEkle;
        private void eKLEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmPerEkle == null || frmPerEkle.IsDisposed)
                frmPerEkle = new FormPersonelEkle();
            frmPerEkle.MdiParent = this;
            frmPerEkle.Text = "Personel Ekleme Paneli";
            frmPerEkle.Show();
        }
        PersonelForm.FormPersonelListele prsList;
        private void lİSTELEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (prsList == null || prsList.IsDisposed)
                prsList = new PersonelForm.FormPersonelListele();
            prsList.MdiParent = this;
            prsList.Text = "Personel Listeleme Paneli";
            prsList.Show();
        }
       
        private void tEDARİKÇİİŞLEMLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        UretilenUrunForm.FormUrunListele urnlist;
        private void lİSTELEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urnlist == null || urnlist.IsDisposed)
                urnlist = new UretilenUrunForm.FormUrunListele();
            urnlist.MdiParent = this;
            urnlist.Text = "Ürün Listeleme Paneli";
            urnlist.Show();
        }
        FormTedarikci frmTed;
        private void tEDARİKÇİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmTed == null || frmTed.IsDisposed)
                frmTed = new FormTedarikci();
            frmTed.MdiParent = this;
            frmTed.Text = "Tedarikçi Ekleme Paneli";
            frmTed.Show();
        }
        Tedarikci.FormTedarikciyeUrunAta tedarUrunAta;
        private void üRÜNATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tedarUrunAta == null || tedarUrunAta.IsDisposed)
                tedarUrunAta = new Tedarikci.FormTedarikciyeUrunAta();
            tedarUrunAta.MdiParent = this;
            tedarUrunAta.Text = "Tedarikçiye Ürün Atama Paneli";
            tedarUrunAta.Show();
        }
        RaporlarForm.FormSon1Hafta s1Hafta;
        private void sON1HAFTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (s1Hafta == null || s1Hafta.IsDisposed)
                s1Hafta = new RaporlarForm.FormSon1Hafta();
            s1Hafta.MdiParent = this;
            s1Hafta.Text = "Rapor Paneli";
            s1Hafta.Show();
        }
        RaporlarForm.FormSon1Ay s1Ay;
        private void sON1AYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (s1Ay == null || s1Ay.IsDisposed)
                s1Ay = new RaporlarForm.FormSon1Ay();
            s1Ay.MdiParent = this;
            s1Ay.Text = "Rapor Paneli";
            s1Ay.Show();
        }
        RaporlarForm.FormSonKayit sKayit;
        private void eNSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sKayit == null || sKayit.IsDisposed)
                sKayit = new RaporlarForm.FormSonKayit();
            sKayit.MdiParent = this;
            sKayit.Text = "Rapor Paneli";
            sKayit.Show();
        }
        RaporlarForm.FormGrafik GRFK;
        private void üRÜNSTOKDURUMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRFK == null || GRFK.IsDisposed)
                GRFK = new RaporlarForm.FormGrafik();
            GRFK.MdiParent = this;
            GRFK.Text = "Rapor Grafik Paneli";
            GRFK.Show();
        }
        RaporlarForm.FormGrafik2 GRFK2;
        private void üRETİLENÜRÜNSTOKDURUMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRFK2 == null || GRFK2.IsDisposed)
                GRFK2 = new RaporlarForm.FormGrafik2();
            GRFK2.MdiParent = this;
            GRFK2.Text = "Rapor Grafik Paneli";
            GRFK2.Show();
        }
        RaporlarForm.FormGrafik3 GRFK3;
        private void bUGÜNALINANSİPARİŞSAYISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRFK3 == null || GRFK3.IsDisposed)
                GRFK3 = new RaporlarForm.FormGrafik3();
            GRFK3.MdiParent = this;
            GRFK3.Text = "Rapor Grafik Paneli";
            GRFK3.Show();
        }
        RaporlarForm.FormGrafik4 GRFK4;
        private void üRÜNEGÖRESİPARİŞSAYISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GRFK4 == null || GRFK4.IsDisposed)
                GRFK4 = new RaporlarForm.FormGrafik4();
            GRFK4.MdiParent = this;
            GRFK4.Text = "Rapor Grafik Paneli";
            GRFK4.Show();
        }
        FormlarMusteri.FormSiparisDetay frmsDetay;
        private void öDEMEBİLSİGİRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmsDetay == null || frmsDetay.IsDisposed)
                frmsDetay = new FormlarMusteri.FormSiparisDetay();
            frmsDetay.MdiParent = this;
            frmsDetay.Text = "Sipariş Detay Paneli";
            frmsDetay.Show();
        }
    }
}
