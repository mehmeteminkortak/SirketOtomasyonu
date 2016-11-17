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
using System.Windows.Forms.DataVisualization.Charting;

namespace Sirkeet.WFA.RaporlarForm
{
    public partial class FormGrafik3 : Form
    {
        public FormGrafik3()
        {
            InitializeComponent();
        }

        private void FormGrafik3_Load(object sender, EventArgs e)
        {
            BugunSiparis();
        }
        private void BugunSiparis()
        {
            List<Siparis> siparisler = new List<Siparis>();
            siparisler = new SiparisRepo().getAll().Where(x => x.SiparisTarihi.Day == DateTime.Now.Day&& x.SiparisTarihi.Month == DateTime.Now.Month && x.SiparisTarihi.Year == DateTime.Now.Year).ToList();

            var series = new Series("BUGÜN ALINAN SİPARİŞ SAYISI");
            series.Points.AddXY("SİPARİŞ SAYISI", siparisler.Count);
            chart1.Series.Add(series);
        }
    }
}
