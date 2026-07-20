namespace Praktek_Membuat_Kalkulator_Sederhana
{
    partial class Form1
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
            this.buttonTambah = new System.Windows.Forms.Button();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.lblHasil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonKurang = new System.Windows.Forms.Button();
            this.buttonKali = new System.Windows.Forms.Button();
            this.buttonBagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(33, 357);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(406, 41);
            this.buttonTambah.TabIndex = 1;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // txtAngka1
            // 
            this.txtAngka1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka1.Location = new System.Drawing.Point(35, 125);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(406, 34);
            this.txtAngka1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Angka 2";
            // 
            // txtAngka2
            // 
            this.txtAngka2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka2.Location = new System.Drawing.Point(35, 201);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(406, 34);
            this.txtAngka2.TabIndex = 2;
            this.txtAngka2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(30, 251);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(70, 28);
            this.lblHasil.TabIndex = 0;
            this.lblHasil.Text = "Hasil :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Calculator Sederhana";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Aksi";
            // 
            // buttonKurang
            // 
            this.buttonKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKurang.Location = new System.Drawing.Point(35, 404);
            this.buttonKurang.Name = "buttonKurang";
            this.buttonKurang.Size = new System.Drawing.Size(406, 43);
            this.buttonKurang.TabIndex = 1;
            this.buttonKurang.Text = "Kurang";
            this.buttonKurang.UseVisualStyleBackColor = true;
            this.buttonKurang.Click += new System.EventHandler(this.buttonKurang_Click);
            // 
            // buttonKali
            // 
            this.buttonKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKali.Location = new System.Drawing.Point(33, 453);
            this.buttonKali.Name = "buttonKali";
            this.buttonKali.Size = new System.Drawing.Size(406, 42);
            this.buttonKali.TabIndex = 1;
            this.buttonKali.Text = "Kali";
            this.buttonKali.UseVisualStyleBackColor = true;
            this.buttonKali.Click += new System.EventHandler(this.buttonKali_Click);
            // 
            // buttonBagi
            // 
            this.buttonBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBagi.Location = new System.Drawing.Point(33, 501);
            this.buttonBagi.Name = "buttonBagi";
            this.buttonBagi.Size = new System.Drawing.Size(406, 39);
            this.buttonBagi.TabIndex = 1;
            this.buttonBagi.Text = "Bagi";
            this.buttonBagi.UseVisualStyleBackColor = true;
            this.buttonBagi.Click += new System.EventHandler(this.buttonBagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 552);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBagi);
            this.Controls.Add(this.buttonKali);
            this.Controls.Add(this.buttonKurang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonKurang;
        private System.Windows.Forms.Button buttonKali;
        private System.Windows.Forms.Button buttonBagi;
    }
}

