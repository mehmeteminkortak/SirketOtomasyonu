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

namespace Sirkeet.WFA.Tedarikci
{
    public partial class FormTedarikciyeUrunAta : Form
    {
        public FormTedarikciyeUrunAta()
        {
            InitializeComponent();
        }
        private void FormTedarikciyeUrunAta_Load(object sender, EventArgs e)
        {
            cmbTedarikci.DataSource = new TedarikciRepo().getAll();
        }
        List<Sirket.Models.AlınanUrun> Urunler;
        private void cmbTedarikci_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenAlinanUrun_Tedarikci = new AlinanUrun_TedarikciRepo().getAll().Where(x => x.TedarikID == (cmbTedarikci.SelectedItem as Sirket.Models.Tedarikci).TedarikID).ToList();
            cListbox.Items.Clear();
            Urunler = new List<Sirket.Models.AlınanUrun>();
            Urunler = new AlinanUrunRepo().getAll();
            Urunler.ForEach(x => cListbox.Items.Add(x));
            for (int i = 0; i < secilenAlinanUrun_Tedarikci.Count; i++)
            {
                int indexx = cListbox.FindString(secilenAlinanUrun_Tedarikci[i].AlınanUrunu.AlınanUrunAdı);

                cListbox.SetItemChecked(indexx, true);
            }

            var UrunIDleri = new AlinanUrun_TedarikciRepo().getAll().Where(x => x.TedarikID == (cmbTedarikci.SelectedItem as Sirket.Models.Tedarikci).TedarikID).ToList();
        }
        public List<AlinanUrun_Tedarikci> secilenAlinanUrun_Tedarikci = new List<AlinanUrun_Tedarikci>();
        public Sirket.Models.AlinanUrun_Tedarikci AlinanUrun_Tedarikci { get; set; }
        private void btnKAydet_Click(object sender, EventArgs e)
        {
            secilenAlinanUrun_Tedarikci = new AlinanUrun_TedarikciRepo().getAll().Where(x => x.TedarikID == (cmbTedarikci.SelectedItem as Sirket.Models.Tedarikci).TedarikID).ToList();
            if (secilenAlinanUrun_Tedarikci.Count != 0)
            {
                int indexx = 0;
                foreach (var item in secilenAlinanUrun_Tedarikci)
                {
                    AlinanUrun_Tedarikci = secilenAlinanUrun_Tedarikci[indexx];
                    new AlinanUrun_TedarikciRepo().Deletee(AlinanUrun_Tedarikci.TedarikID);
                    indexx++;
                }
            }
            secilenAlinanUrun_Tedarikci = new AlinanUrun_TedarikciRepo().getAll().Where(x => x.TedarikID == (cmbTedarikci.SelectedItem as Sirket.Models.Tedarikci).TedarikID).ToList();
            if (secilenAlinanUrun_Tedarikci.Count == 0)
            {
                int indexx = 0;
                foreach (var item in cListbox.CheckedItems)
                {
                    new AlinanUrun_TedarikciRepo().Insert(new Sirket.Models.AlinanUrun_Tedarikci()
                    {
                        TedarikID = (cmbTedarikci.SelectedItem as Sirket.Models.Tedarikci).TedarikID,
                        AlınanUrunID = (cListbox.CheckedItems[indexx] as Sirket.Models.AlınanUrun).AlınanUrunID
                    });
                    indexx++;
                }
                MessageBox.Show("Değişiklikler Kaydedildi");
            }
            //else
            //{
            //    int indexx = 0;
            //    foreach (var item in secilenAlinanUrun_Tedarikci)
            //    {
            //        secilenAlinanUrun_Tedarikci[indexx].TedarikID = (cmbTedarikci.SelectedItem as Sirket.Models.Tedarikci).TedarikID;
            //        if (!cListbox.GetSelected(indexx))
            //        {
            //            new AlinanUrun_TedarikciRepo().Delete(secilenAlinanUrun_Tedarikci[indexx]);
            //        }
            //        else
            //        {
            //            secilenAlinanUrun_Tedarikci[indexx].AlınanUrunID = (cListbox.CheckedItems[indexx] as Sirket.Models.AlınanUrun).AlınanUrunID;
            //        }


            //        indexx++;
            //    }
            //    new AlinanUrun_TedarikciRepo().Update();
            //    MessageBox.Show("Değişiklikler Kaydedildi");
            //}

        }
    }
}
