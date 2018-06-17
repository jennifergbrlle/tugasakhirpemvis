namespace TugasAkhirTest
{
    partial class AbsenKeluar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kehadiran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Absen_Keluar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Absen Keluar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIP,
            this.NamaPegawai,
            this.Divisi,
            this.Jabatan,
            this.Kehadiran,
            this.Absen_Keluar});
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 287);
            this.dataGridView1.TabIndex = 1;
            // 
            // NIP
            // 
            this.NIP.HeaderText = "NIP";
            this.NIP.Name = "NIP";
            // 
            // NamaPegawai
            // 
            this.NamaPegawai.HeaderText = "NamaPegawai";
            this.NamaPegawai.Name = "NamaPegawai";
            // 
            // Divisi
            // 
            this.Divisi.HeaderText = "Divisi";
            this.Divisi.Name = "Divisi";
            // 
            // Jabatan
            // 
            this.Jabatan.HeaderText = "Jabatan";
            this.Jabatan.Name = "Jabatan";
            // 
            // Kehadiran
            // 
            this.Kehadiran.HeaderText = "Kehadiran";
            this.Kehadiran.Name = "Kehadiran";
            // 
            // Absen_Keluar
            // 
            this.Absen_Keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Absen_Keluar.HeaderText = "Absen Keluar";
            this.Absen_Keluar.Name = "Absen_Keluar";
            // 
            // AbsenKeluar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AbsenKeluar";
            this.Size = new System.Drawing.Size(582, 379);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jabatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kehadiran;
        private System.Windows.Forms.DataGridViewButtonColumn Absen_Keluar;
    }
}
