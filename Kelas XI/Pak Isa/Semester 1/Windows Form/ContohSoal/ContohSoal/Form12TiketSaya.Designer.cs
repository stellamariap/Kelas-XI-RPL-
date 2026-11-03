namespace ContohSoal
{
    partial class Form12TiketSaya
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leaveBtn = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTiket = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuPenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveBtn
            // 
            this.leaveBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leaveBtn.Image = global::ContohSoal.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_35_PM_removebg_preview;
            this.leaveBtn.Location = new System.Drawing.Point(15, 18);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(52, 43);
            this.leaveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leaveBtn.TabIndex = 21;
            this.leaveBtn.TabStop = false;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Semua tiket Anda yang aktif akan muncul di sini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tiket Saya";
            // 
            // dataGridTiket
            // 
            this.dataGridTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTiket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.TanggalKeberangkatan,
            this.WaktuPenerbangan,
            this.StatusTerakhir});
            this.dataGridTiket.Location = new System.Drawing.Point(15, 118);
            this.dataGridTiket.Name = "dataGridTiket";
            this.dataGridTiket.RowHeadersWidth = 62;
            this.dataGridTiket.RowTemplate.Height = 28;
            this.dataGridTiket.Size = new System.Drawing.Size(995, 437);
            this.dataGridTiket.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.DataPropertyName = "KodePenerbangan";
            this.KodePenerbangan.HeaderText = "Kode Penerbangan";
            this.KodePenerbangan.MinimumWidth = 8;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.Width = 150;
            // 
            // Maskapai
            // 
            this.Maskapai.DataPropertyName = "Maskapai";
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 8;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.Width = 150;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.DataPropertyName = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.HeaderText = "Bandara Keberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 8;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.Width = 150;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.DataPropertyName = "BandaraTujuan";
            this.BandaraTujuan.HeaderText = "Bandara Tujuan";
            this.BandaraTujuan.MinimumWidth = 8;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.Width = 150;
            // 
            // TanggalKeberangkatan
            // 
            this.TanggalKeberangkatan.DataPropertyName = "TanggalKeberangkatan";
            this.TanggalKeberangkatan.HeaderText = "Tanggal Keberangkatan";
            this.TanggalKeberangkatan.MinimumWidth = 8;
            this.TanggalKeberangkatan.Name = "TanggalKeberangkatan";
            this.TanggalKeberangkatan.Width = 150;
            // 
            // WaktuPenerbangan
            // 
            this.WaktuPenerbangan.DataPropertyName = "WaktuPenerbangan";
            this.WaktuPenerbangan.HeaderText = "Waktu Penerbangan";
            this.WaktuPenerbangan.MinimumWidth = 8;
            this.WaktuPenerbangan.Name = "WaktuPenerbangan";
            this.WaktuPenerbangan.Width = 150;
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.DataPropertyName = "StatusTerakhir";
            this.StatusTerakhir.HeaderText = "Status Terakhir";
            this.StatusTerakhir.MinimumWidth = 8;
            this.StatusTerakhir.Name = "StatusTerakhir";
            this.StatusTerakhir.Width = 150;
            // 
            // Form12TiketSaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 567);
            this.Controls.Add(this.dataGridTiket);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form12TiketSaya";
            this.Text = "Form12TiketSaya";
            this.Load += new System.EventHandler(this.Form12TiketSaya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leaveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhir;
    }
}