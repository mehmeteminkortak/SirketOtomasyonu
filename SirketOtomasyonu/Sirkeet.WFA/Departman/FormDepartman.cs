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

namespace Sirkeet.WFA.Departman
{
    public partial class FormDepartman : Form
    {
        public FormDepartman()
        {
            InitializeComponent();
        }

        private void FormDepartman_Load(object sender, EventArgs e)
        {
            lstList.DataSource = new DepartmanRepo().getAll();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            lstList.DataSource = new DepartmanRepo().Arama(txtArama.Text);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new DepartmanRepo().Insert(new Sirket.Models.Departman()
                {
                    DepartmanAdi = txtDepartmanAdi.Text
                });
                MessageBox.Show("Kayıt gerçekleşti");
                lstList.DataSource = new DepartmanRepo().getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Sirket.Models.Departman seciliDepartman { get; set; }
        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDepartman = lstList.SelectedItem as Sirket.Models.Departman;
            txtDepartmanAdi.Text = seciliDepartman.DepartmanAdi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliDepartman==null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            var guncellenecekDEpartman = new DepartmanRepo().GetByID(seciliDepartman.DepartmanID);
            guncellenecekDEpartman.DepartmanAdi = txtDepartmanAdi.Text;

            new DepartmanRepo().Update();
            lstList.DataSource = new DepartmanRepo().getAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliDepartman==null)
            {
                MessageBox.Show("Nesne seçilmedi");
                return;
            }
            new DepartmanRepo().Delete(seciliDepartman);
            lstList.DataSource = new DepartmanRepo().getAll();
        }
    }
}
