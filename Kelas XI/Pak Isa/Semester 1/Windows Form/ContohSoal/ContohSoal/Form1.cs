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
    public partial class Form1 : Form
    {
        BandaraEntities db = new BandaraEntities();

        public Form1()
        {
            // Inisialisasi komponen-komponen yang digunakan, agar bisa dirender saat dimulai
            InitializeComponent();
        }

        // Saat label4 (teks "Daftar Sekarang") ditekan, maka:
        private void label4_Click(object sender, EventArgs e)
        {
            // Buat instansi halaman register (Form2Register)
            Form2Register register = new Form2Register();

            // Sembunyikan halaman saat ini (Form1)
            this.Hide();

            // Tampilkan instansi halaman Form2Register
            register.Show();
        }

        // Saat button1 (tombol login) ditekan, maka:
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                // Jika textbox kosong proses login dihentikan
                MessageBox.Show("Username dan Password harus diisi");
                return;
            }

            // Cari Akun berdasarkan username dan password
            var user = db.Akuns.FirstOrDefault(a => a.Username == textBox2.Text && a.Password == textBox1.Text);

            // Cek User
            if (user == null) // Jika user tidak ditemukan
            {
                MessageBox.Show("Password atau Username salah");
                return;
            }

            MessageBox.Show("Login Berhasil"); // Messagebox tampil
            Session.loggedIn = user;

            if (user.MerupakanAdmin)
            {
                // Masuk ke dashboard
                Form3Dashboard dashboard = new Form3Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                Form9CustomerMain customer = new Form9CustomerMain();
                customer.Show();
                this.Hide();
            }
        }
    }
}
