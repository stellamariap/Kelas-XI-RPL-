using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {

        SekolahDBEntities db = new SekolahDBEntities();

        public Form1()
        {
            InitializeComponent();
        }

        int idSiswa;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            loadData();

            jurusanBox.DataSource = db.Jurusans.ToList();
            jurusanBox.DisplayMember = "NamaJurusan";
            jurusanBox.ValueMember = "Id";
            jurusanBox.SelectedIndex = -1;
        }


        private void loadData()
        {
            dataGridView1.DataSource = db.Siswas.Select(s => new
            {
                s.Id,
                s.Nama,
                s.Umur,
                s.Alamat,
                Jurusan = s.Jurusan.NamaJurusan
            }).ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (namaBox.Text == "" || umurBox.Text == "" 
                || alamatBox.Text == "" || jurusanBox.SelectedIndex == -1)
            {
                MessageBox.Show("Tolong lengkapi data yang diperlukan terlebih dahulu.");
                return;
            } 

            var siswa = new Siswa();

            siswa.Nama = namaBox.Text;
            siswa.Umur = Convert.ToInt32(umurBox.Text);
            siswa.Alamat = alamatBox.Text;
            siswa.JurusanID = Convert.ToInt32(jurusanBox.SelectedValue);

            db.Siswas.Add(siswa);
            db.SaveChanges();


            MessageBox.Show("Data Berhasil Ditambahkan");
            loadData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }   // Error Handling agar ketika pengguna mengklik Header DGV, nilai RowIndex akan bernilai -1
                // Jika kondisi tersebut terjadi, program akan langsung berhenti menggunakan perintah return  

            string columnName = dataGridView1.Columns[e.ColumnIndex].Name; // untuk mengambil nama kolom

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex]; 

            if (columnName == "Update")
            {
                idSiswa = Convert.ToInt32(row.Cells["Id"].Value); // Mengambil value kolom Id dari baris yang dipilih


                namaBox.Text = row.Cells["Nama"].Value.ToString();
                umurBox.Text = row.Cells["Umur"].Value.ToString();
                alamatBox.Text = row.Cells["Alamat"].Value.ToString();
                jurusanBox.Text = row.Cells["Jurusan"].Value.ToString();

                addButton.Text = "Update";
            } else if (columnName == "Delete")
            {
                var result = MessageBox.Show("Hapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idDelete = Convert.ToInt32(row.Cells["Id"].Value);

                    var siswa = db.Siswas.Find(idDelete);

                    if (siswa != null)
                    {
                        db.Siswas.Remove(siswa);
                        db.SaveChanges();

                        MessageBox.Show("Data Berhasil Dihapus");
                    }
                } 

                loadData();
            }

        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string key = searchTxt.Text;

            if (key == "") // Memasukkan Error Handling jika textbox search kosong
            {
                loadData(); // data akan terefresh jika textbox kosong
                return;
            }

            // Logic untuk search
            dataGridView1.DataSource = db.Siswas.Where(s => s.Nama.Contains(key) || s.Umur.ToString().Contains(key) 
            || s.Alamat.Contains(key) || s.Jurusan.NamaJurusan.Contains(key))
                .Select(s => new
                {
                    s.Id,
                    s.Nama,
                    s.Umur,
                    s.Alamat,
                    Jurusan = s.Jurusan.NamaJurusan
                }).ToList();
        }
    }
}
