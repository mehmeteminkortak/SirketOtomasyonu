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
    public partial class AlınanUrun : Form
    {
        public AlınanUrun()
        {
            InitializeComponent();
            dataGridView1.Click += DataGridView1_Click;
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            int urunID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            seciliUrun = new AlinanUrunRepo().GetByID(urunID);
            txtAlınanUrunAdi.Text = seciliUrun.AlınanUrunAdı;
            nmrAlınanUrubFiyar.Value = seciliUrun.Fiyat;
            nmrAlınanStokMiktarı.Value = seciliUrun.Stok;
            int cmbindex = cmbAlınanKategori.FindString(seciliUrun.AlınanKategori.AlınanKategoriAdi);
            cmbAlınanKategori.SelectedIndex = cmbindex;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new AlinanUrunRepo().Insert(new Sirket.Models.AlınanUrun()
                {
                    AlınanUrunAdı = txtAlınanUrunAdi.Text,
                    AlınanKategoriID = (cmbAlınanKategori.SelectedItem as AlınanKategori).AlınanKategoriID,
                    Fiyat = nmrAlınanUrubFiyar.Value,
                    Stok = (int)nmrAlınanStokMiktarı.Value
                });
                MessageBox.Show("Kayıt gerçekleşti");
                dataGridView1.DataSource = new AlinanUrunRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Sirket.Models.AlınanUrun seciliUrun { get; set; }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliUrun == null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            new AlinanUrunRepo().Delete(seciliUrun);
            dataGridView1.DataSource = new AlinanUrunRepo().getAll();
        }

        private void AlınanUrun_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new AlinanUrunRepo().getAll();
            cmbAlınanKategori.DataSource = new AlinanKategoriRepo().getAll();
            dataGridView1.Columns[1].Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliUrun == null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }

            try
            {
                var guncellecekUrun = new AlinanUrunRepo().GetByID(seciliUrun.AlınanUrunID);
                guncellecekUrun.AlınanUrunAdı = txtAlınanUrunAdi.Text;
                guncellecekUrun.AlınanKategoriID = (cmbAlınanKategori.SelectedItem as AlınanKategori).AlınanKategoriID;
                guncellecekUrun.Fiyat = nmrAlınanUrubFiyar.Value;
                guncellecekUrun.Stok = (int)nmrAlınanStokMiktarı.Value;
                new AlinanUrunRepo().Update();
                dataGridView1.DataSource = new AlinanUrunRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
