namespace TugasAkhirTest
{
    partial class AbsenMasuk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsenMasuk));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jam = new System.Windows.Forms.Label();
            this.NIPmasuk_txt = new System.Windows.Forms.TextBox();
            this.namapegawaimasuk_txt = new System.Windows.Forms.TextBox();
            this.divisimasuk_txt = new System.Windows.Forms.TextBox();
            this.jabatanmasuk_txt = new System.Windows.Forms.TextBox();
            this.simpanmasuk_btn = new System.Windows.Forms.Button();
            this.batalmasuk_btn = new System.Windows.Forms.Button();
            this.hari = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.search_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Absen Masuk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Pegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Divisi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jabatan";
            // 
            // jam
            // 
            this.jam.AutoSize = true;
            this.jam.Location = new System.Drawing.Point(352, 265);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(55, 19);
            this.jam.TabIndex = 5;
            this.jam.Text = "Waktu";
            // 
            // NIPmasuk_txt
            // 
            this.NIPmasuk_txt.Location = new System.Drawing.Point(290, 90);
            this.NIPmasuk_txt.Name = "NIPmasuk_txt";
            this.NIPmasuk_txt.Size = new System.Drawing.Size(139, 24);
            this.NIPmasuk_txt.TabIndex = 6;
            this.NIPmasuk_txt.Validating += new System.ComponentModel.CancelEventHandler(this.NIPmasuk_txt_Validating);
            // 
            // namapegawaimasuk_txt
            // 
            this.namapegawaimasuk_txt.Enabled = false;
            this.namapegawaimasuk_txt.Location = new System.Drawing.Point(290, 133);
            this.namapegawaimasuk_txt.Name = "namapegawaimasuk_txt";
            this.namapegawaimasuk_txt.Size = new System.Drawing.Size(139, 24);
            this.namapegawaimasuk_txt.TabIndex = 7;
            // 
            // divisimasuk_txt
            // 
            this.divisimasuk_txt.Enabled = false;
            this.divisimasuk_txt.Location = new System.Drawing.Point(290, 176);
            this.divisimasuk_txt.Name = "divisimasuk_txt";
            this.divisimasuk_txt.Size = new System.Drawing.Size(139, 24);
            this.divisimasuk_txt.TabIndex = 8;
            // 
            // jabatanmasuk_txt
            // 
            this.jabatanmasuk_txt.Enabled = false;
            this.jabatanmasuk_txt.Location = new System.Drawing.Point(290, 219);
            this.jabatanmasuk_txt.Name = "jabatanmasuk_txt";
            this.jabatanmasuk_txt.Size = new System.Drawing.Size(139, 24);
            this.jabatanmasuk_txt.TabIndex = 9;
            // 
            // simpanmasuk_btn
            // 
            this.simpanmasuk_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanmasuk_btn.Location = new System.Drawing.Point(196, 318);
            this.simpanmasuk_btn.Name = "simpanmasuk_btn";
            this.simpanmasuk_btn.Size = new System.Drawing.Size(87, 30);
            this.simpanmasuk_btn.TabIndex = 11;
            this.simpanmasuk_btn.Text = "SIMPAN";
            this.simpanmasuk_btn.UseVisualStyleBackColor = true;
            this.simpanmasuk_btn.Click += new System.EventHandler(this.simpanmasuk_btn_Click);
            // 
            // batalmasuk_btn
            // 
            this.batalmasuk_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batalmasuk_btn.Location = new System.Drawing.Point(315, 318);
            this.batalmasuk_btn.Name = "batalmasuk_btn";
            this.batalmasuk_btn.Size = new System.Drawing.Size(87, 30);
            this.batalmasuk_btn.TabIndex = 12;
            this.batalmasuk_btn.Text = "BATAL";
            this.batalmasuk_btn.UseVisualStyleBackColor = true;
            this.batalmasuk_btn.Click += new System.EventHandler(this.batalmasuk_btn_Click);
            // 
            // hari
            // 
            this.hari.AutoSize = true;
            this.hari.Location = new System.Drawing.Point(163, 265);
            this.hari.Name = "hari";
            this.hari.Size = new System.Drawing.Size(36, 19);
            this.hari.TabIndex = 13;
            this.hari.Text = "Hari";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // search_btn
            // 
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.Location = new System.Drawing.Point(430, 90);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(25, 25);
            this.search_btn.TabIndex = 14;
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AbsenMasuk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.hari);
            this.Controls.Add(this.batalmasuk_btn);
            this.Controls.Add(this.simpanmasuk_btn);
            this.Controls.Add(this.jabatanmasuk_txt);
            this.Controls.Add(this.divisimasuk_txt);
            this.Controls.Add(this.namapegawaimasuk_txt);
            this.Controls.Add(this.NIPmasuk_txt);
            this.Controls.Add(this.jam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AbsenMasuk";
            this.Size = new System.Drawing.Size(615, 380);
            this.Load += new System.EventHandler(this.AbsenMasuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label jam;
        private System.Windows.Forms.TextBox NIPmasuk_txt;
        private System.Windows.Forms.TextBox namapegawaimasuk_txt;
        private System.Windows.Forms.TextBox divisimasuk_txt;
        private System.Windows.Forms.TextBox jabatanmasuk_txt;
        private System.Windows.Forms.Button simpanmasuk_btn;
        private System.Windows.Forms.Button batalmasuk_btn;
        private System.Windows.Forms.Label hari;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
