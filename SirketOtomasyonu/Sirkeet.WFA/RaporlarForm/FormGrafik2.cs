using Sirket.BLL;
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
    public partial class FormGrafik2 : Form
    {
        public FormGrafik2()
        {
            InitializeComponent();
        }

        private void FormGrafik2_Load(object sender, EventArgs e)
        {
            AlinanUrun();
        }
        private void AlinanUrun()
        {
            List<Sirket.Models.AlınanUrun> AlinanUrunler = new List<Sirket.Models.AlınanUrun>();

            AlinanUrunler = new AlinanUrunRepo().getAll();

            var series = new Series("Alınan Ürün Stok");
            int i = 0;
            foreach (var item in AlinanUrunler)
            {

                series.Points.AddXY(AlinanUrunler[i].AlınanUrunAdı, AlinanUrunler[i].Stok);
                i++;
            }

            chart1.Series.Add(series);
        }
    }
}
