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
    public partial class FormGrafik4 : Form
    {
        public FormGrafik4()
        {
            InitializeComponent();
        }

        private void FormGrafik4_Load(object sender, EventArgs e)
        {
            UruneGoreSiparis();
        }
        private void UruneGoreSiparis()
        {
            var siparisler = new SiparisRepo().UruneGoreSiparisSayisi();
            

            var series = new Series("SİPARİŞ SAYISI");
            foreach (var item in siparisler)
            {
                series.Points.AddXY(item.UrunAdi, item.ToplamAdet);
            }
            chart1.Series.Add(series);
        }
    }
}
