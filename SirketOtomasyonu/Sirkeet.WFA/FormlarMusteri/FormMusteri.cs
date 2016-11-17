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
    public partial class FormMusteri : Form
    {
        public FormMusteri()
        {
            InitializeComponent();
            dgvMusteriListe.Click += DgvMusteriListe_Click;
        }

        private void DgvMusteriListe_Click(object sender, EventArgs e)

        {
            int MusteriID = int.Parse(dgvMusteriListe.SelectedRows[0].Cells[0].Value.ToString());
            SeciliMusteri = new MusteriRepo().GetByID(MusteriID);
            txtAdi.Text = SeciliMusteri.MusteriAdi;
            txtSoyadi.Text = SeciliMusteri.MusteriSoyadi;
            txtAdres.Text = SeciliMusteri.MusteriAdres;
            txtTelefon.Text = SeciliMusteri.Telefon;
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            dgvMusteriListe.DataSource = new MusteriRepo().getAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new MusteriRepo().Insert(new Musteri()
                {
                    MusteriAdi = txtAdi.Text,
                    MusteriAdres = txtAdres.Text,
                    MusteriSoyadi = txtSoyadi.Text,
                    Telefon = txtTelefon.Text
                });
                MessageBox.Show("Kayıt gerceklesti");
                dgvMusteriListe.DataSource = new MusteriRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Musteri SeciliMusteri { get; set; }
        private void dgvMusteriListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (SeciliMusteri==null)
            {
                MessageBox.Show("nesne secilmedi");
                return;
            }
            new MusteriRepo().Delete(SeciliMusteri);
            dgvMusteriListe.DataSource = new MusteriRepo().getAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (SeciliMusteri==null)
            {
                MessageBox.Show("Nesne Secilmedi");
                return;
            }
            var guncellenecekMusteri = new MusteriRepo().GetByID(SeciliMusteri.MusteriID);
            guncellenecekMusteri.MusteriAdi = txtAdi.Text;
            guncellenecekMusteri.MusteriSoyadi = txtSoyadi.Text;
            guncellenecekMusteri.Telefon = txtTelefon.Text;
            guncellenecekMusteri.MusteriAdres = txtAdres.Text;

            try
            {
                new MusteriRepo().Update();
                dgvMusteriListe.DataSource = new MusteriRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgvMusteriListe.DataSource = new MusteriRepo().Arama(txtArama.Text);
        }
    }
}
