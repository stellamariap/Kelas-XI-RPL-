namespace ContohSoal
{
    partial class Form10ListPenerbangan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timeCheck1 = new System.Windows.Forms.CheckBox();
            this.timeCheck4 = new System.Windows.Forms.CheckBox();
            this.timeCheck3 = new System.Windows.Forms.CheckBox();
            this.timeCheck2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.passengerLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridPenerbangan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaPerTiket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeliTiket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Penerbangan";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.timeCheck1);
            this.groupBox1.Controls.Add(this.timeCheck4);
            this.groupBox1.Controls.Add(this.timeCheck3);
            this.groupBox1.Controls.Add(this.timeCheck2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // sortBox
            // 
            this.sortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(21, 152);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(272, 30);
            this.sortBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(707, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Terapkan Filter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timeCheck1
            // 
            this.timeCheck1.AutoSize = true;
            this.timeCheck1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck1.Location = new System.Drawing.Point(21, 58);
            this.timeCheck1.Name = "timeCheck1";
            this.timeCheck1.Size = new System.Drawing.Size(143, 29);
            this.timeCheck1.TabIndex = 5;
            this.timeCheck1.Text = "00:00 - 06:00";
            this.timeCheck1.UseVisualStyleBackColor = true;
            // 
            // timeCheck4
            // 
            this.timeCheck4.AutoSize = true;
            this.timeCheck4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck4.Location = new System.Drawing.Point(540, 58);
            this.timeCheck4.Name = "timeCheck4";
            this.timeCheck4.Size = new System.Drawing.Size(143, 29);
            this.timeCheck4.TabIndex = 5;
            this.timeCheck4.Text = "18:00 - 24:00";
            this.timeCheck4.UseVisualStyleBackColor = true;
            // 
            // timeCheck3
            // 
            this.timeCheck3.AutoSize = true;
            this.timeCheck3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck3.Location = new System.Drawing.Point(370, 58);
            this.timeCheck3.Name = "timeCheck3";
            this.timeCheck3.Size = new System.Drawing.Size(143, 29);
            this.timeCheck3.TabIndex = 5;
            this.timeCheck3.Text = "12:00 - 18:00";
            this.timeCheck3.UseVisualStyleBackColor = true;
            // 
            // timeCheck2
            // 
            this.timeCheck2.AutoSize = true;
            this.timeCheck2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCheck2.Location = new System.Drawing.Point(196, 58);
            this.timeCheck2.Name = "timeCheck2";
            this.timeCheck2.Size = new System.Drawing.Size(143, 29);
            this.timeCheck2.TabIndex = 5;
            this.timeCheck2.Text = "06:00 - 12:00";
            this.timeCheck2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Waktu Keberangkatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Urutkan Berdasarkan";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureLabel.Location = new System.Drawing.Point(54, 69);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(142, 25);
            this.departureLabel.TabIndex = 0;
            this.departureLabel.Text = "Bandara A (BAA)";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(250, 68);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(138, 25);
            this.destinationLabel.TabIndex = 0;
            this.destinationLabel.Text = "Bandara B (BAB)";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(448, 69);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(136, 25);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Wed, May 2026";
            // 
            // passengerLabel
            // 
            this.passengerLabel.AutoSize = true;
            this.passengerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerLabel.Location = new System.Drawing.Point(639, 68);
            this.passengerLabel.Name = "passengerLabel";
            this.passengerLabel.Size = new System.Drawing.Size(122, 25);
            this.passengerLabel.TabIndex = 0;
            this.passengerLabel.Text = "1 Penumpang";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = global::ContohSoal.Properties.Resources.WhatsApp_Image_2026_08_05_at_12_33_35_PM_removebg_preview;
            this.pictureBox4.Location = new System.Drawing.Point(4, 17);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(608, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(417, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(219, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridPenerbangan
            // 
            this.dataGridPenerbangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPenerbangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.HargaPerTiket,
            this.Tanggal,
            this.Jam,
            this.BeliTiket});
            this.dataGridPenerbangan.Location = new System.Drawing.Point(59, 358);
            this.dataGridPenerbangan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPenerbangan.Name = "dataGridPenerbangan";
            this.dataGridPenerbangan.RowHeadersWidth = 62;
            this.dataGridPenerbangan.Size = new System.Drawing.Size(892, 258);
            this.dataGridPenerbangan.TabIndex = 14;
            this.dataGridPenerbangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPenerbangan_CellClick);
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
            // HargaPerTiket
            // 
            this.HargaPerTiket.DataPropertyName = "HargaPerTiket";
            this.HargaPerTiket.HeaderText = "Harga";
            this.HargaPerTiket.MinimumWidth = 8;
            this.HargaPerTiket.Name = "HargaPerTiket";
            this.HargaPerTiket.Width = 150;
            // 
            // Tanggal
            // 
            this.Tanggal.DataPropertyName = "Tanggal";
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.MinimumWidth = 8;
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Width = 150;
            // 
            // Jam
            // 
            this.Jam.DataPropertyName = "Jam";
            this.Jam.HeaderText = "Jam Berangkat";
            this.Jam.MinimumWidth = 8;
            this.Jam.Name = "Jam";
            this.Jam.Width = 150;
            // 
            // BeliTiket
            // 
            this.BeliTiket.HeaderText = "";
            this.BeliTiket.MinimumWidth = 8;
            this.BeliTiket.Name = "BeliTiket";
            this.BeliTiket.Text = "Beli Tiket";
            this.BeliTiket.UseColumnTextForButtonValue = true;
            this.BeliTiket.Width = 150;
            // 
            // Form10ListPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1016, 640);
            this.Controls.Add(this.dataGridPenerbangan);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passengerLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form10ListPenerbangan";
            this.Text = "Form10ListPenerbangan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPenerbangan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label passengerLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox timeCheck1;
        private System.Windows.Forms.CheckBox timeCheck4;
        private System.Windows.Forms.CheckBox timeCheck3;
        private System.Windows.Forms.CheckBox timeCheck2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridPenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaPerTiket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jam;
        private System.Windows.Forms.DataGridViewButtonColumn BeliTiket;
    }
}