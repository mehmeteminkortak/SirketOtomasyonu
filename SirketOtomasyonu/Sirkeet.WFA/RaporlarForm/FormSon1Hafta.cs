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

namespace Sirkeet.WFA.RaporlarForm
{
    public partial class FormSon1Hafta : Form
    {
        public FormSon1Hafta()
        {
            InitializeComponent();
        }

        private void FormSon1Hafta_Load(object sender, EventArgs e)
        {
            var sorgu = new SiparisRepo().getAll().OrderByDescending(x => x.SiparisTarihi).Take(7).ToList();
            dataGridView1.DataSource = sorgu;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
    }
}
