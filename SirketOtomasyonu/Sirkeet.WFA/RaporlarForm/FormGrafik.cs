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
    public partial class FormGrafik : Form
    {
        public FormGrafik()
        {
            InitializeComponent();
        }

        private void FormGrafik_Load(object sender, EventArgs e)
        {
            UretilenUrun();
        }
        private void UretilenUrun()
        {
            List<UretilenUrun> Uretilenler = new List<Sirket.Models.UretilenUrun>();

            Uretilenler = new UretilenUrunRepo().getAll();

            var series = new Series("Üretilen Ürün Stok");
            int i = 0;
            foreach (var item in Uretilenler)
            {
                
                series.Points.AddXY(Uretilenler[i].UeretilenUrunAdi, Uretilenler[i].Stok);
                i++;
            }
            
            chart1.Series.Add(series);
        }
       
    }
}
