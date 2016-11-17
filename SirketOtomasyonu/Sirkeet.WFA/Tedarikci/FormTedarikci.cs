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
    public partial class FormTedarikci : Form
    {
        public FormTedarikci()
        {
            InitializeComponent();
        }

        private void FormTedarikci_Load(object sender, EventArgs e)
        {
            lstTedarik.DataSource = new TedarikciRepo().getAll();
            lstTedarik.Click += LstTedarik_Click;
        }

        private void LstTedarik_Click(object sender, EventArgs e)
        {
            int TedarikID = int.Parse(lstTedarik.SelectedRows[0].Cells[0].Value.ToString());
            secilenTedarik = new TedarikciRepo().GetByID(TedarikID);
            txttedarikciAdi.Text = secilenTedarik.TedarikciAdi;
            txtTedarikSoyad.Text = secilenTedarik.TedarikciSoyadi;
            txtSirketadı.Text = secilenTedarik.SirketAdi;
            txtadres.Text = secilenTedarik.TedarikciAdresi;
            txtTelefon.Text = secilenTedarik.TedarikciTelefonu;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                new TedarikciRepo().Insert(new Sirket.Models.Tedarikci()
                {
                    TedarikciAdi = txttedarikciAdi.Text,
                    TedarikciSoyadi = txtTedarikSoyad.Text,
                    TedarikciAdresi = txtadres.Text,
                    SirketAdi = txtSirketadı.Text,
                    TedarikciTelefonu = txtTelefon.Text
                });
                MessageBox.Show("Kayıt gercekleşti");
                lstTedarik.DataSource = new TedarikciRepo().getAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public Sirket.Models.Tedarikci secilenTedarik { get; set; }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenTedarik == null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            new TedarikciRepo().Delete(secilenTedarik);
            lstTedarik.DataSource = new TedarikciRepo().getAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenTedarik == null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            var guncellecekTedarik = new TedarikciRepo().GetByID(secilenTedarik.TedarikID);
            guncellecekTedarik.TedarikciAdi = txttedarikciAdi.Text;
            guncellecekTedarik.TedarikciSoyadi = txtTedarikSoyad.Text;
            guncellecekTedarik.TedarikciTelefonu = txtTelefon.Text;
            guncellecekTedarik.SirketAdi = txtSirketadı.Text;
            guncellecekTedarik.TedarikciAdresi = txtadres.Text;
            try
            {
                new TedarikciRepo().Update();
                lstTedarik.DataSource = new TedarikciRepo().getAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            lstTedarik.DataSource = new TedarikciRepo().Arama(txtArama.Text);
        }

        private void lstTedarik_SelectedIndexChanged(object sender, EventArgs e)
        {
            //secilenTedarik = lstTedarik.SelectedItem as Sirket.Models.Tedarikci;
            //txttedarikciAdi.Text = secilenTedarik.TedarikciAdi;
            //txtTedarikSoyad.Text = secilenTedarik.TedarikciSoyadi;
            //txtSirketadı.Text = secilenTedarik.SirketAdi;
            //txtadres.Text = secilenTedarik.TedarikciAdresi;
            //txtTelefon.Text = secilenTedarik.TedarikciTelefonu;
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
