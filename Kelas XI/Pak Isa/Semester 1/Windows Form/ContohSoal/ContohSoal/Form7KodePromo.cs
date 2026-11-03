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
    public partial class Form7KodePromo : Form
    {
        BandaraEntities db = new BandaraEntities(); // membuat koneksi ke database
        private int idPromo = -1; // mode tambah

        public Form7KodePromo()
        {
            InitializeComponent();
        }

        private void Dashboard(object sender, EventArgs e)
        {
            Form3Dashboard dashboard = new Form3Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void Bandara(object sender, EventArgs e)
        {
            Form4Bandara bandara = new Form4Bandara();
            this.Hide();
            bandara.Show();
        }

        private void Maskapai(object sender, EventArgs e)
        {
            Form5Maskapai maskapai = new Form5Maskapai();
            this.Hide();
            maskapai.Show();
        }

        private void JadwalPenerbangan(object sender, EventArgs e)
        {
            Form6JadwalPenerbangan penerbangan = new Form6JadwalPenerbangan();
            this.Hide();
            penerbangan.Show();
        }

        private void KodePromo(object sender, EventArgs e)
        {
            Form7KodePromo promo = new Form7KodePromo();
            this.Hide();
            promo.Show();
        }

        private void UbahStatusPenerbangan(object sender, EventArgs e)
        {
            Form8UbahStatusPenerbangan status = new Form8UbahStatusPenerbangan();
            this.Hide();
            status.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            this.Close();
            logout.Show();
        }

        private void Form7KodePromo_Load(object sender, EventArgs e)
        {
            dataGridPromo.AutoGenerateColumns = false;
            dataGridPromo.AllowUserToAddRows = false;
            dataGridPromo.ReadOnly = true;

            LoadData();
        }

        private void LoadData()
        {
            dataGridPromo.DataSource = db.KodePromoes.ToList();
            // jika kolom yang ingin ditampilkan sesuai dengan kolom yang ada di tabel database
            // cukup seperti Syntax diatas saja
        }

        private void ClearForm()
        {
            promoText.Clear();
            descriptionText.Clear();

            percentCount.Value = 0;
            maxCount.Value = 0;

            expirationDate.Value = DateTime.Today;

            idPromo = -1; // kembali ke mode add

            saveBtn.Text = "Simpan";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void promoText_TextChanged(object sender, EventArgs e)
        {
            promoText.Text = promoText.Text.ToUpper();
            promoText.SelectionStart = promoText.Text.Length;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validasi input tidak boleh kosong
            if (promoText.Text == "" || descriptionText.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
                return;
            }

            // validasi kode promo harus unik
            bool kodeSudahAda = db.KodePromoes.Any(p => p.Kode == promoText.Text && p.ID == idPromo);

            if (kodeSudahAda)
            {
                MessageBox.Show("Kode promo sudah digunakan");
                return;
            }

            // validasi persentase dan maksimal diskon minimal 1
            if (percentCount.Value < 1 || maxCount.Value < 1)
            {
                MessageBox.Show("Input nilai tidak boleh kurang dari 1");
                return;
            }

            // validasi tanggal expiration date tidak boleh kurang dari hari ini
            if (expirationDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal expired tidak boleh kurang dari hari ini");
                return;
            }

            if (idPromo == -1) // mode tambah
            {
                KodePromo tambahPromo = new KodePromo();

                tambahPromo.Kode = promoText.Text;
                tambahPromo.BerlakuSampai = expirationDate.Value;
                tambahPromo.PersentaseDiskon = Convert.ToInt32(percentCount.Value);
                tambahPromo.MaksimumDiskon = Convert.ToInt32(maxCount.Value);
                tambahPromo.Deskripsi = descriptionText.Text;

                db.KodePromoes.Add(tambahPromo);
                db.SaveChanges();

                MessageBox.Show("Data berhasil disimpan");
            }
            else
            {
                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                editPromo.Kode = promoText.Text;
                editPromo.BerlakuSampai = expirationDate.Value;
                editPromo.PersentaseDiskon = Convert.ToInt32(percentCount.Value);
                editPromo.MaksimumDiskon = Convert.ToInt32(maxCount.Value);
                editPromo.Deskripsi = descriptionText.Text;

                MessageBox.Show("Data berhasil diedit");
            }

            db.SaveChanges();

            LoadData();
            ClearForm();
        }

        private void dataGridPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dataGridPromo.Columns[e.ColumnIndex].Name == "edit")
            {
                idPromo = Convert.ToInt32(dataGridPromo.Rows[e.RowIndex].Cells["ID"].Value);

                KodePromo editPromo = db.KodePromoes.Find(idPromo);

                promoText.Text = editPromo.Kode;
                expirationDate.Value = editPromo.BerlakuSampai;
                percentCount.Value = Convert.ToInt32(editPromo.PersentaseDiskon);
                maxCount.Value = Convert.ToInt32(editPromo.MaksimumDiskon);
                descriptionText.Text = editPromo.Deskripsi;

                saveBtn.Text = "Update";
            }
            else if (dataGridPromo.Columns[e.ColumnIndex].Name == "hapus")
            {
                int idHapus = Convert.ToInt32(dataGridPromo.Rows[e.RowIndex].Cells["ID"].Value);


                var hasil = MessageBox.Show("Apakah anda yakin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    KodePromo hapusPromo = db.KodePromoes.Find(idHapus);

                    db.KodePromoes.Remove(hapusPromo);
                    db.SaveChanges();

                    MessageBox.Show("Data berhasil dihapus");

                    LoadData();
                    ClearForm();
                }
            }
        }
    }
}
