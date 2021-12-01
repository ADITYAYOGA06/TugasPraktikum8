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
    public partial class HasilPerhitungan : Form
    {

        public delegate void HitungEventHandler(Calculator cal);

        public event HitungEventHandler PostHasil;

        public HasilPerhitungan()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            var nilaiA = int.Parse(txtNilaiA.Text);
            var nilaiB = Convert.ToInt32(txtNilaiB.Text);

            int hasil = 0;
            string teks = "";
       
            if (cmbOperasi.SelectedIndex == 0)
            {
                hasil = Penambahan(nilaiA, nilaiB);
                teks = $"Hasil penambahan {nilaiA} + {nilaiB} = {hasil}";
            }
            if (cmbOperasi.SelectedIndex == 1)
            {
                hasil = Pengurangan(nilaiA, nilaiB);
                teks = $"Hasil pengurangan {nilaiA} - {nilaiB} = {hasil}";

            }
            if (cmbOperasi.SelectedIndex == 2)
            {
                hasil = Perkalian(nilaiA, nilaiB);
                teks = $"Hasil perkalian {nilaiA} * {nilaiB} = {hasil}";

            }
            if (cmbOperasi.SelectedIndex == 3)
            {
                hasil = Pembagian(nilaiA, nilaiB);
                teks = $"Hasil pembagian {nilaiA} / {nilaiB} = {hasil}";

            }

            var cal = new Calculator();
            cal.teks = teks.ToString();
            PostHasil(cal);

        }


    }
}
