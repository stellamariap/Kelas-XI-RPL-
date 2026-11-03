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

        // Event: setiap kali input harga berubah
        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            // Kalau kosong, reset semua
            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                lblHasilDiskon.Text = "0%";
                lblHasilPotongan.Text = "Rp0";
                lblHasilTotal.Text = "Rp0";
                return;
            }

            // Parse angka dari TextBox
            if (double.TryParse(txtHarga.Text, out double harga))
            {
                // ATURAN DISKON (bisa kamu ubah)
                double persenDiskon = 0;

                if (harga >= 500000)
                    persenDiskon = 25;   // 25%
                else if (harga >= 200000)
                    persenDiskon = 15;   // 15%
                else if (harga >= 100000)
                    persenDiskon = 10;   // 10%
                else
                    persenDiskon = 0;    // 0%

                // Hitung potongan dan total
                double potongan = harga * (persenDiskon / 100);
                double total = harga - potongan;

                // Tampilkan ke label hasil
                lblHasilDiskon.Text = persenDiskon.ToString() + "%";
                lblHasilPotongan.Text = "Rp" + potongan.ToString("N0");
                lblHasilTotal.Text = "Rp" + total.ToString("N0");
            }
            else
            {
                // Kalau input bukan angka
                lblHasilDiskon.Text = "???";
                lblHasilPotongan.Text = "Rp0";
                lblHasilTotal.Text = "Rp0";
            }
        }

        // EVENT UNTUK TOMBOL BATAL (reset)
        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtHarga.Text = "";
            lblHasilDiskon.Text = "0%";
            lblHasilPotongan.Text = "Rp0";
            lblHasilTotal.Text = "Rp0";
            txtHarga.Focus(); // Fokus ke input lagi
        }

        // EVENT UNTUK TOMBOL KIRIM (opsional)
        private void btnKirim_Click(object sender, EventArgs e)
        {
            // Bisa dipakai untuk validasi atau tampilkan pesan
            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Masukkan harga terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Data berhasil diproses!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}