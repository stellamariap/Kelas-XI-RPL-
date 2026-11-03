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
    public partial class Form4Bandara : Form
    {
        BandaraEntities db = new BandaraEntities(); // membuat koneksi ke database
        private int idBandara = -1; // menyimpan id bandara yang sedang diedit
                                    // (-1 mode tambah, jika > 0 mode update)

        private void Form4Bandara_Load(object sender, EventArgs e)
        {
            LoadNegara(); // menampilkan daftar negara ke combobox
            LoadBandara(); // menampilkan semua data bandara ke dalam dataGridView

            dataGridBandara.AutoGenerateColumns = false;
            dataGridBandara.AllowUserToAddRows = false;
            dataGridBandara.ReadOnly = true;
        }

        private void LoadNegara()
        {
            countryBox.DataSource = db.Negaras.OrderBy(n => n.Nama).ToList();
            countryBox.DisplayMember = "Nama";
            countryBox.ValueMember = "ID";
            countryBox.SelectedIndex = -1;
        }

        private void LoadBandara()
        {
            dataGridBandara.DataSource = db.Bandaras.Include("Negara") // Include() mengambil data dari
            .OrderBy(b => b.Nama) // urutkan berdasarkan nama, dari
            .Select(b => new // select() memilih kolom yang akan
            {
                b.ID,
                b.Nama,
                b.KodeIATA,
                b.Kota,
                Negara = b.Negara.Nama,
                b.JumlahTerminal,
                b.Alamat,
            }).ToList();
        }

        private void ResetForm()
        {
            nameTxt.Clear();
            iataTxt.Clear();
            cityTxt.Clear();
            addressTxt.Clear();
            countryBox.SelectedIndex = -1;
            terminalCount.Value = 1;
            idBandara = -1; // kembali ke mode tambah data
            saveBtn.Text = "Simpan";
        }

        public Form4Bandara()
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "" || iataTxt.Text == "" ||
            cityTxt.Text == "" || addressTxt.Text == "" || countryBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            // validasi panjang kode IATA
            if (iataTxt.Text.Length != 3)
            {
                MessageBox.Show("Kode IATA wajib memiliki 3 huruf!");
                return;
            }

            // semua karakter IATA harus berupa huruf
            if (!iataTxt.Text.All(char.IsLetter)) // All() mengecek semua karakter
            {
                MessageBox.Show("Kode IATA hanya boleh huruf!");
                return;
            }

            // validasi IATA tidak boleh sama
            bool adaIATA = db.Bandaras.Any(b => b.KodeIATA == iataTxt.Text
            && b.ID != idBandara);

            if (adaIATA)
            {
                MessageBox.Show("Kode IATA sudah digunakan!");
                return;
            }

            // validasi jumlah terminal (minimal 1 terminal)
            if (terminalCount.Value < 1)
            {
                MessageBox.Show("Jumlah terminal minimal 1");
                return;
            }

            // validasi nama bandara harus unik
            bool adaBandara = db.Bandaras.Any(b => b.Nama.ToLower() == nameTxt.Text.ToLower()
            && b.ID != idBandara);

            if (adaBandara)
            {
                MessageBox.Show("Nama bandara sudah dipakai!");
                return;
            }

            // percabangan edit atau add data
            if (idBandara == -1) // add data
            {
                // membuat object bandara baru
                Bandara bandara = new Bandara();
                bandara.Nama = nameTxt.Text;
                bandara.KodeIATA = iataTxt.Text;
                bandara.Kota = cityTxt.Text;
                bandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                bandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                bandara.Alamat = addressTxt.Text;

                db.Bandaras.Add(bandara);
                MessageBox.Show("Data berhasil ditambahkan!");
            }
            else // edit
            {
                Bandara editBandara = db.Bandaras.Find(idBandara);
                editBandara.Nama = nameTxt.Text;
                editBandara.KodeIATA = iataTxt.Text;
                editBandara.Kota = cityTxt.Text;
                editBandara.NegaraID = Convert.ToInt32(countryBox.SelectedValue);
                editBandara.JumlahTerminal = Convert.ToInt32(terminalCount.Value);
                editBandara.Alamat = addressTxt.Text;

                MessageBox.Show("Data berhasil diedit!");
            }

            db.SaveChanges();

            LoadBandara();
            ResetForm();
        }

        private void dataGridBandara_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
