using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContohSoal
{
    public partial class Form2Register : Form
    {
        BandaraEntities db = new BandaraEntities();

        public Form2Register()
        {
            // Inisialisasi komponen-komponen pada halaman Form2Register
            InitializeComponent();
        }

        // Apabila label9 (teks "login") ditekan, maka:
        private void label9_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman login (Form1)
            Form1 login = new Form1();

            // Sembunyikan halaman saat ini (Form2Register)
            this.Hide();

            // Tampilkan instansi halaman login (Form1)
            login.Show();
        }

        // Apabila button1 (tombol daftar) ditekan, maka:
        private void button1_Click(object sender, EventArgs e) // tempat logic simpan user
        {
            // cek semua textbox
            if (textBox1.Text == "" || textBox2.Text == "" ||
            textBox4.Text == "" || textBox5.Text == "" ||
            dateTimePicker1.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Tolong lengkapi semua data yang diperlukan untuk membuat akun baru");
                return;
            }

            // username harus unik
            bool usernameSudahAda = db.Akuns.Any(a => a.Username == textBox1.Text);

            if (usernameSudahAda)
            {
                MessageBox.Show("Username sudah digunakan");
                return;
            }

            // validasi nomor telepon
            if (!textBox4.Text.All(char.IsDigit)) // jika nomor telepon terdapat huruf atau simbol lainnya
            {
                MessageBox.Show("Nomor telepon hanya boleh berisikan angka");
                return;
            }

            if (textBox4.Text.Length < 10 || textBox4.Text.Length > 15) // Nomor telepon harus lebih dari 10
                                                                        // dan tidak lebih dari 15 karakter
            {
                MessageBox.Show("Nomor telepon harus 10 - 15 digit");
                return;
            }

            // validasi password
            if (textBox5.Text.Length < 8)
            {
                MessageBox.Show("Password minimal 8 karakter");
                return;
            }

            // validasi tanggal lahir (fitur tambahan)
            int umur = DateTime.Now.Year - dateTimePicker1.Value.Year;

            // jika ulang tahun ini belum lewat (belum genap)
            if (dateTimePicker1.Value.Date > DateTime.Today.AddYears(-umur)) // menyamakan tahun ini dengan
                                                                             // tahun lahir agar bisa
                                                                             // menghitung genapnya tanggal lahir
            {
                umur--; // mengurangi 1 jika ulang tahun belum terlewat (belum genap)
            }

            if (umur < 17) // validasi minimal 17 tahun untuk membuat akun
            {
                MessageBox.Show("Umur minimal 17 tahun!");
                return;
            }

            // Daftar akun baru dan masukkan ke dalam database
            Akun akunBaru = new Akun();

            akunBaru.Username = textBox1.Text;
            akunBaru.Nama = textBox2.Text;
            akunBaru.TanggalLahir = dateTimePicker1.Value;
            akunBaru.NomorTelepon = textBox4.Text;
            akunBaru.Password = textBox5.Text;
            akunBaru.MerupakanAdmin = false; // kita membuat akun customer

            db.Akuns.Add(akunBaru);
            db.SaveChanges();

            // tampilkan pesan
            MessageBox.Show("Berhasil membuat akun baru. \nSilahkan login");

            // lompat ke login screen
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
