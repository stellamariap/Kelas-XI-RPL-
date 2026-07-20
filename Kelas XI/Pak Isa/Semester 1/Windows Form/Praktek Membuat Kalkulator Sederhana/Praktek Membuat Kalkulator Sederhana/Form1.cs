using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktek_Membuat_Kalkulator_Sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            // Kita mengambil text dari textbox lalu mengubah menjadi interger
            // Kita ubah menjadi Interger karena hasil dari textbox adalah string (.Text)

            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // Lalu kita buat variabel untuk menjumlahkan 
            int hasil = angka1 + angka2;

            // setelah itu kita bisa langsung menampilkan ke Label Hasil 
            lblHasil.Text = "Hasil : " + hasil.ToString(); // Jangan lupa untuk diconvert menjadi string karena kita sudah mengubah ke bentuk interger sebelumnya 

        }

        private void buttonKurang_Click(object sender, EventArgs e)
        { 

            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // Lalu kita buat variabel untuk menjumlahkan 
            int hasil = angka1 - angka2;

            // setelah itu kita bisa langsung menampilkan ke Label Hasil 
            lblHasil.Text = "Hasil : " + hasil.ToString(); // Jangan lupa untuk diconvert menjadi string karena kita sudah mengubah ke bentuk interger sebelumnya 
        }

        private void buttonKali_Click(object sender, EventArgs e)
        {

            int angka1 = Convert.ToInt32(txtAngka1.Text);
            int angka2 = Convert.ToInt32(txtAngka2.Text);

            // Lalu kita buat variabel untuk menjumlahkan 
            int hasil = angka1 * angka2;

            // setelah itu kita bisa langsung menampilkan ke Label Hasil 
            lblHasil.Text = "Hasil : " + hasil.ToString(); // Jangan lupa untuk diconvert menjadi string karena kita sudah mengubah ke bentuk interger sebelumnya 
        }

        private void buttonBagi_Click(object sender, EventArgs e)
        {
           // Untuk pembagian, kita akan menggunakan variabel double agar hasil lebih akurat 

            double angka1 = Convert.ToInt32(txtAngka1.Text);
            double angka2 = Convert.ToInt32(txtAngka2.Text);

            // Lalu kita buat variabel untuk menjumlahkan 
            double hasil = angka1 / angka2;

            // setelah itu kita bisa langsung menampilkan ke Label Hasil 
            lblHasil.Text = "Hasil : " + hasil.ToString(); // Jangan lupa untuk diconvert menjadi string karena kita sudah mengubah ke bentuk interger sebelumnya 
        }
    }
}
