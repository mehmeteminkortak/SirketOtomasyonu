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
    public partial class FormOdemeDetay : Form
    {
        public FormOdemeDetay()
        {
            InitializeComponent();
        }
        public Siparis SeciliSiparis { get; set; }
        public Musteri SeciliMusteri { get; set; }

        private void FormOdemeDetay_Load(object sender, EventArgs e)
        {
            dgvListe.DataSource = new OdemeDetayRepo().getAll().Where(x => x.SiparisID == SeciliSiparis.SiparisID).ToList();
            dgvListe.Columns[1].Visible = false;
            dgvListe.Columns[2].Visible = false;
            dgvListe.Columns[3].Visible = false;

            decimal ToplamOdedigiMiktar = new OdemeDetayRepo().getAll().Where(x => x.SiparisID == SeciliSiparis.SiparisID).Sum(x => x.OdedigiMiktar);
            lblToplamOdedigiMiktar.Text = ToplamOdedigiMiktar.ToString();

            if ((new SiparisRepo().GetByID(SeciliSiparis.SiparisID).OdenecekTutar) > ToplamOdedigiMiktar)
                lblBorcAlacakli.Text = $"Borçlu : {(new SiparisRepo().GetByID(SeciliSiparis.SiparisID).OdenecekTutar) - ToplamOdedigiMiktar}";
            else
                lblBorcAlacakli.Text = $"Alacaklı : {((new SiparisRepo().GetByID(SeciliSiparis.SiparisID).OdenecekTutar) - ToplamOdedigiMiktar) * -1}";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dgvListe.DataSource = new OdemeDetayRepo().Arama(dtpArama.Value).Where(x => x.SiparisID == SeciliSiparis.SiparisID).ToList() ;
            dgvListe.Columns[1].Visible = false;
            dgvListe.Columns[2].Visible = false;
            dgvListe.Columns[3].Visible = false;
        }
    }
}
