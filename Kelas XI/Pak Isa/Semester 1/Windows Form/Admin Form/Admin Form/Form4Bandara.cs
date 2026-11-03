using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Form
{
    public partial class Form4Bandara : Form
    {
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
    }
}
