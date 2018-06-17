namespace TugasAkhirTest
{
    partial class AdminInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaPegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jabatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keterangan = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.search_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NIP,
            this.NamaPegawai,
            this.Divisi,
            this.Jabatan,
            this.Keterangan});
            this.dataGridView1.Location = new System.Drawing.Point(18, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // NIP
            // 
            this.NIP.HeaderText = "NIP";
            this.NIP.Name = "NIP";
            // 
            // NamaPegawai
            // 
            this.NamaPegawai.HeaderText = "Nama Pegawai";
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
            // Keterangan
            // 
            this.Keterangan.HeaderText = "";
            this.Keterangan.Name = "Keterangan";
            this.Keterangan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Keterangan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Keterangan.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Pegawai";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.search_txt);
            this.panel1.Location = new System.Drawing.Point(379, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 23);
            this.panel1.TabIndex = 2;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.ImageActive = null;
            this.search_btn.Location = new System.Drawing.Point(159, 0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(20, 23);
            this.search_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_btn.TabIndex = 3;
            this.search_btn.TabStop = false;
            this.search_btn.Zoom = 10;
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(3, 0);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(156, 23);
            this.search_txt.TabIndex = 0;
            // 
            // AdminInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AdminInfo";
            this.Size = new System.Drawing.Size(615, 380);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jabatan;
        private System.Windows.Forms.DataGridViewLinkColumn Keterangan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton search_btn;
        private System.Windows.Forms.TextBox search_txt;
    }
}
