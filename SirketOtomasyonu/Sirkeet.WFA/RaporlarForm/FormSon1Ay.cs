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
    public partial class FormSon1Ay : Form
    {
        public FormSon1Ay()
        {
            InitializeComponent();
        }

        private void FormSon1Ay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= new SiparisRepo().getAll().OrderByDescending(x=> x.SiparisTarihi).Take(30).ToList();
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
        }
    }
}
