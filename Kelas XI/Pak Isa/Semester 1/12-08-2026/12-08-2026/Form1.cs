using System;
using System.Windows.Forms;

namespace KalkulatorDiskon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event: setiap kali angka di txtHarga berubah
        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            // Kalau kosong, reset tampilan
            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                lblDiskon.Text = "0%";
                lblPotongan.Text = "Rp0";
                lblTotal.Text = "Rp0";
                return;
            }

            // Coba parsing angka dari TextBox
            if (double.TryParse(txtHarga.Text, out double harga))
            {
                // 1. Tentukan persentase diskon
                double persenDiskon = 0;

                if (harga >= 500000)
                    persenDiskon = 25;   // 25%
                else if (harga >= 200000)
                    persenDiskon = 15;   // 15%
                else if (harga >= 100000)
                    persenDiskon = 10;   // 10%
                else
                    persenDiskon = 0;    // 0%

                // 2. Hitung potongan dan total
                double potongan = harga * (persenDiskon / 100);
                double total = harga - potongan;

                // 3. Tampilkan ke Label dengan format Rupiah
                lblDiskon.Text = persenDiskon.ToString() + "%";
                lblPotongan.Text = "Rp" + potongan.ToString("N0"); // N0 = tanpa desimal, ada ribuan
                lblTotal.Text = "Rp" + total.ToString("N0");
            }
            else
            {
                // Kalau input bukan angka valid
                lblDiskon.Text = "???";
                lblPotongan.Text = "Rp0";
                lblTotal.Text = "Rp0";
            }
        }
    }
}