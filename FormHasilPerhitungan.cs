using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppTugas
{
    public partial class FormHasilPerhitungan : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();

        public FormHasilPerhitungan()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            lvwHasil.View = View.Details;
            lvwHasil.FullRowSelect = true;
            lvwHasil.Columns.Add("", 750, HorizontalAlignment.Left);

        }

        private void FormCalculator_PostHasil(Calculator cal)
        {
            listOfCalculator.Add(cal);

            ListViewItem item = new ListViewItem();
            lvwHasil.Items.Add(cal.teks);
            //lvwHasil.Items.Add(cal.nilaiA);
            //lvwHasil.Items.Add(cal.nilaiB);
            //lvwHasil.Items.Add(cal.hasil);
            //var jawaban = int.Parse(cal.hasil);
            //lvwHasil.Items.Add(string.Format("Hasilnya adalah {0} \n", cal.hasil));
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            HasilPerhitungan frmCalculator = new HasilPerhitungan();

            frmCalculator.PostHasil += FormCalculator_PostHasil;

            frmCalculator.ShowDialog();

        }   
    }
}
