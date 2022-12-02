
namespace Peminjaman_Buku
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBx1_id = new System.Windows.Forms.TextBox();
            this.txtBx2_Nama = new System.Windows.Forms.TextBox();
            this.txtBx3_Alamat = new System.Windows.Forms.TextBox();
            this.txtBx4_JdBuku = new System.Windows.Forms.TextBox();
            this.rdBttn1_Lk = new System.Windows.Forms.RadioButton();
            this.rdBttn2_Pl = new System.Windows.Forms.RadioButton();
            this.dateTime1_Pinjam = new System.Windows.Forms.DateTimePicker();
            this.dateTime2_Kembali = new System.Windows.Forms.DateTimePicker();
            this.bttn1_Simpan = new System.Windows.Forms.Button();
            this.bttn2_Hapus = new System.Windows.Forms.Button();
            this.cmbBox1_JsBuku = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Anggota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Buku";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Judul Buku";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(474, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "DATA ANGGOTA PEMINJAMAN BUKU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tanggal Pinjam";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tanggal Kembali";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtBx1_id
            // 
            this.txtBx1_id.Location = new System.Drawing.Point(113, 67);
            this.txtBx1_id.Name = "txtBx1_id";
            this.txtBx1_id.Size = new System.Drawing.Size(100, 20);
            this.txtBx1_id.TabIndex = 9;
            // 
            // txtBx2_Nama
            // 
            this.txtBx2_Nama.Location = new System.Drawing.Point(113, 93);
            this.txtBx2_Nama.Name = "txtBx2_Nama";
            this.txtBx2_Nama.Size = new System.Drawing.Size(100, 20);
            this.txtBx2_Nama.TabIndex = 10;
            // 
            // txtBx3_Alamat
            // 
            this.txtBx3_Alamat.Location = new System.Drawing.Point(113, 149);
            this.txtBx3_Alamat.Multiline = true;
            this.txtBx3_Alamat.Name = "txtBx3_Alamat";
            this.txtBx3_Alamat.Size = new System.Drawing.Size(142, 54);
            this.txtBx3_Alamat.TabIndex = 11;
            // 
            // txtBx4_JdBuku
            // 
            this.txtBx4_JdBuku.Location = new System.Drawing.Point(113, 237);
            this.txtBx4_JdBuku.Name = "txtBx4_JdBuku";
            this.txtBx4_JdBuku.Size = new System.Drawing.Size(145, 20);
            this.txtBx4_JdBuku.TabIndex = 12;
            this.txtBx4_JdBuku.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // rdBttn1_Lk
            // 
            this.rdBttn1_Lk.AutoSize = true;
            this.rdBttn1_Lk.Location = new System.Drawing.Point(113, 119);
            this.rdBttn1_Lk.Name = "rdBttn1_Lk";
            this.rdBttn1_Lk.Size = new System.Drawing.Size(70, 17);
            this.rdBttn1_Lk.TabIndex = 14;
            this.rdBttn1_Lk.TabStop = true;
            this.rdBttn1_Lk.Text = "Laki - laki";
            this.rdBttn1_Lk.UseVisualStyleBackColor = true;
            // 
            // rdBttn2_Pl
            // 
            this.rdBttn2_Pl.AutoSize = true;
            this.rdBttn2_Pl.Location = new System.Drawing.Point(189, 118);
            this.rdBttn2_Pl.Name = "rdBttn2_Pl";
            this.rdBttn2_Pl.Size = new System.Drawing.Size(79, 17);
            this.rdBttn2_Pl.TabIndex = 15;
            this.rdBttn2_Pl.TabStop = true;
            this.rdBttn2_Pl.Text = "Perempuan";
            this.rdBttn2_Pl.UseVisualStyleBackColor = true;
            // 
            // dateTime1_Pinjam
            // 
            this.dateTime1_Pinjam.Location = new System.Drawing.Point(113, 272);
            this.dateTime1_Pinjam.Name = "dateTime1_Pinjam";
            this.dateTime1_Pinjam.Size = new System.Drawing.Size(200, 20);
            this.dateTime1_Pinjam.TabIndex = 16;
            // 
            // dateTime2_Kembali
            // 
            this.dateTime2_Kembali.Location = new System.Drawing.Point(113, 304);
            this.dateTime2_Kembali.Name = "dateTime2_Kembali";
            this.dateTime2_Kembali.Size = new System.Drawing.Size(200, 20);
            this.dateTime2_Kembali.TabIndex = 17;
            // 
            // bttn1_Simpan
            // 
            this.bttn1_Simpan.Location = new System.Drawing.Point(113, 342);
            this.bttn1_Simpan.Name = "bttn1_Simpan";
            this.bttn1_Simpan.Size = new System.Drawing.Size(75, 23);
            this.bttn1_Simpan.TabIndex = 18;
            this.bttn1_Simpan.Text = "SIMPAN";
            this.bttn1_Simpan.UseVisualStyleBackColor = true;
            // 
            // bttn2_Hapus
            // 
            this.bttn2_Hapus.Location = new System.Drawing.Point(208, 342);
            this.bttn2_Hapus.Name = "bttn2_Hapus";
            this.bttn2_Hapus.Size = new System.Drawing.Size(75, 23);
            this.bttn2_Hapus.TabIndex = 19;
            this.bttn2_Hapus.Text = "HAPUS";
            this.bttn2_Hapus.UseVisualStyleBackColor = true;
            // 
            // cmbBox1_JsBuku
            // 
            this.cmbBox1_JsBuku.FormattingEnabled = true;
            this.cmbBox1_JsBuku.Location = new System.Drawing.Point(113, 210);
            this.cmbBox1_JsBuku.Name = "cmbBox1_JsBuku";
            this.cmbBox1_JsBuku.Size = new System.Drawing.Size(145, 21);
            this.cmbBox1_JsBuku.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(765, 431);
            this.Controls.Add(this.cmbBox1_JsBuku);
            this.Controls.Add(this.bttn2_Hapus);
            this.Controls.Add(this.bttn1_Simpan);
            this.Controls.Add(this.dateTime2_Kembali);
            this.Controls.Add(this.dateTime1_Pinjam);
            this.Controls.Add(this.rdBttn2_Pl);
            this.Controls.Add(this.rdBttn1_Lk);
            this.Controls.Add(this.txtBx4_JdBuku);
            this.Controls.Add(this.txtBx3_Alamat);
            this.Controls.Add(this.txtBx2_Nama);
            this.Controls.Add(this.txtBx1_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Data Anggota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBx1_id;
        private System.Windows.Forms.TextBox txtBx2_Nama;
        private System.Windows.Forms.TextBox txtBx3_Alamat;
        private System.Windows.Forms.TextBox txtBx4_JdBuku;
        private System.Windows.Forms.RadioButton rdBttn1_Lk;
        private System.Windows.Forms.RadioButton rdBttn2_Pl;
        private System.Windows.Forms.DateTimePicker dateTime1_Pinjam;
        private System.Windows.Forms.DateTimePicker dateTime2_Kembali;
        private System.Windows.Forms.Button bttn1_Simpan;
        private System.Windows.Forms.Button bttn2_Hapus;
        private System.Windows.Forms.ComboBox cmbBox1_JsBuku;
    }
}

