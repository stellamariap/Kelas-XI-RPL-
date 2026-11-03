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
    public partial class Form6JadwalPenerbangan : Form
    {
        BandaraEntities db = new BandaraEntities();
        private int idJadwal = -1; // mode tambah

        public Form6JadwalPenerbangan()
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

        private void Form6JadwalPenerbangan_Load(object sender, EventArgs e)
        {
            dataGridJadwal.AutoGenerateColumns = false;
            dataGridJadwal.AllowUserToAddRows = false;
            dataGridJadwal.ReadOnly = true;

            departureTime.Format = DateTimePickerFormat.Custom;
            departureTime.CustomFormat = "HH:mm";
            departureTime.ShowUpDown = true;

            LoadBandara();
            LoadMaskapai();
            LoadJadwal();
        }

        private void LoadBandara()
        {
            // keberangkatan
            departureBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            departureBox.DisplayMember = "Nama";
            departureBox.ValueMember = "ID";
            departureBox.SelectedIndex = -1;

            // tujuan
            destinationBox.DataSource = db.Bandaras.OrderBy(b => b.Nama).ToList();
            destinationBox.DisplayMember = "Nama";
            destinationBox.ValueMember = "ID";
            destinationBox.SelectedIndex = -1;
        }

        private void LoadMaskapai()
        {
            maskapaiBox.DataSource = db.Maskapais.OrderBy(b => b.Nama).ToList();
            maskapaiBox.DisplayMember = "Nama";
            maskapaiBox.ValueMember = "ID";
            maskapaiBox.SelectedIndex = -1;
        }

        private void LoadJadwal()
        {
            // menampilkan semua jadwal ke dalam data grid view
            dataGridJadwal.DataSource = db.JadwalPenerbangans
                                        .OrderByDescending(j => j.TanggalWaktuKeberangkatan)
                                        .ToList()
                                        .Select(j => new
                                        {
                                            j.ID,
                                            j.KodePenerbangan,
                                            BandaraAsal = j.Bandara.Nama,
                                            BandaraTujuan = j.Bandara1.Nama,
                                            Maskapai = j.Maskapai.Nama,
                                            TanggalKeberangkatan = j.TanggalWaktuKeberangkatan.ToString("dd/MM/yy"),
                                            WaktuKeberangkatan = j.TanggalWaktuKeberangkatan.ToString("HH:mm"),
                                            DurasiPenerbangan = (j.DurasiPenerbangan / 60) + " Jam " + (j.DurasiPenerbangan % 60) + " Menit ",
                                            j.HargaPerTiket
                                        }).ToList();
        }

        private void ClearForm()
        {
            codeText.Clear();
            durationText.Text = "__ Jam __ Menit";

            departureBox.SelectedIndex = -1;
            destinationBox.SelectedIndex = -1;
            maskapaiBox.SelectedIndex = -1;

            departureDate.Value = DateTime.Now;
            departureTime.Value = DateTime.Now;

            priceCount.Value = 0;

            idJadwal = -1;

            saveBtn.Text = "Simpan";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // validasi input kosong
            if (codeText.Text == "" || durationText.Text == "" || departureBox.SelectedIndex == -1 || destinationBox.SelectedIndex == -1 || maskapaiBox.SelectedIndex == -1)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            // validasi kode penerbangan (cukup panjang)
            // format kode harus AA-0000 (2 huruf, 1 strip, 4 angka)

            if (codeText.Text.Length != 7)
            {
                MessageBox.Show("Format kode: AA-0000");
                return;
            }

            if (!char.IsLetter(codeText.Text[0]) || !char.IsLetter(codeText.Text[1]))
            {
                MessageBox.Show("2 karakter pertama harus berupa huruf");
                return;
            }

            if (codeText.Text[2] != '-')
            {
                MessageBox.Show("Kode harus mengandung '-'");
                return;
            }

            if (!char.IsDigit(codeText.Text[3]) || !char.IsDigit(codeText.Text[4]) || !char.IsDigit(codeText.Text[5]) || !char.IsDigit(codeText.Text[6]))
            {
                MessageBox.Show("4 karakter terakhir harus berupa angka");
                return;
            }

            // validasi bandara
            // keberangkatan dan tujuan tidak boleh sama
            if (departureBox.SelectedValue.Equals(destinationBox.SelectedValue))
            {
                MessageBox.Show("Bandara asal dan tujuan tidak boleh sama!");
                return;
            }

            // validasi format durasi
            string[] durasi = durationText.Text.Split(' '); // memisah durasi menjadi beberapa bagian

            // harus terdiri dari 4 bagian
            if (durasi.Length != 4)
            {
                MessageBox.Show("Format durasi : xx Jam xx Menit");
                return;
            }

            // bagian kedua harus "jam"
            // bagian keempat harus "menit"
            if (durasi[1] != "Jam" || durasi[3] != "Menit")
            {
                MessageBox.Show("Format durasi : xx Jam xx Menit");
                return;
            }

            // bagian pertama dan ketiga harus angla
            if (!durasi[0].All(char.IsDigit) || !durasi[2].All(char.IsDigit))
            {
                MessageBox.Show("Jam dan Menit harus berupa Angka");
                return;
            }

            int jam = Convert.ToInt32(durasi[0]);
            int menit = Convert.ToInt32(durasi[2]);

            int totalMenit = (jam * 60) + menit;

            // validasi harga
            if (priceCount.Value < 1)
            {
                MessageBox.Show("Harga tidak valid");
                return;
            }

            // validasi tanggal keberangkatan tidak boleh hari sebelum hari ini
            if (departureDate.Value < DateTime.Today)
            {
                MessageBox.Show("Tanggal keberangkatan tidak boleh hari kemarin");
                return;
            }

            MessageBox.Show("Data berhasil ditambahkan");

            if (idJadwal == -1) // mode tambah
            {
                JadwalPenerbangan jadwalBaru = new JadwalPenerbangan();
                PerubahanStatusJadwalPenerbangan statusJadwal = new PerubahanStatusJadwalPenerbangan();

                jadwalBaru.KodePenerbangan = codeText.Text;
                jadwalBaru.BandaraKeberangkatanID = Convert.ToInt32(departureBox.SelectedValue);
                jadwalBaru.BandaraTujuanID = Convert.ToInt32(destinationBox.SelectedValue);
                jadwalBaru.MaskapaiID = Convert.ToInt32(maskapaiBox.SelectedValue);
                jadwalBaru.TanggalWaktuKeberangkatan = departureDate.Value.Date + departureTime.Value.TimeOfDay;
                jadwalBaru.DurasiPenerbangan = totalMenit; // kita akan membuatkan variabel untuk memformat teks durasi
                jadwalBaru.HargaPerTiket = Convert.ToInt32(priceCount.Value);

                db.JadwalPenerbangans.Add(jadwalBaru);
                db.SaveChanges();

                statusJadwal.JadwalPenerbanganID = jadwalBaru.ID;
                statusJadwal.StatusPenerbanganID = 1;
                statusJadwal.WaktuPerubahanTerjadi = DateTime.Now;
                statusJadwal.PerkiraanDurasiDelay = null;

                db.PerubahanStatusJadwalPenerbangans.Add(statusJadwal);


                MessageBox.Show("Jadwal berhasil dibuat");
            }
            else
            {
                JadwalPenerbangan editJadwal = db.JadwalPenerbangans.Find(idJadwal);

                editJadwal.KodePenerbangan = codeText.Text;
                editJadwal.BandaraKeberangkatanID = Convert.ToInt32(departureBox.SelectedValue);
                editJadwal.BandaraTujuanID = Convert.ToInt32(destinationBox.SelectedValue);
                editJadwal.MaskapaiID = Convert.ToInt32(maskapaiBox.SelectedValue);
                editJadwal.TanggalWaktuKeberangkatan = departureDate.Value.Date + departureTime.Value.TimeOfDay;
                editJadwal.DurasiPenerbangan = totalMenit; // kita akan membuatkan variabel untuk memformat teks durasi
                editJadwal.HargaPerTiket = Convert.ToInt32(priceCount.Value);

                MessageBox.Show("Jadwal berhasil diubah");
            }

            db.SaveChanges();
            ClearForm();
            LoadJadwal();
        }

        private void dataGridJadwal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

