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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsenKeluar));
            this.label1 = new System.Windows.Forms.Label();
            this.absenkeluar_btn = new System.Windows.Forms.Button();
            this.NIPkeluar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namapegawaikeluar_txt = new System.Windows.Forms.TextBox();
            this.jammasukkeluar_txt = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
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
            this.label1.Text = "Absen Keluar";
            // 
            // absenkeluar_btn
            // 
            this.absenkeluar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absenkeluar_btn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenkeluar_btn.Location = new System.Drawing.Point(241, 300);
            this.absenkeluar_btn.Name = "absenkeluar_btn";
            this.absenkeluar_btn.Size = new System.Drawing.Size(116, 30);
            this.absenkeluar_btn.TabIndex = 2;
            this.absenkeluar_btn.Text = "ABSEN KELUAR";
            this.absenkeluar_btn.UseVisualStyleBackColor = true;
            this.absenkeluar_btn.Click += new System.EventHandler(this.absenkeluar_btn_Click);
            // 
            // NIPkeluar_txt
            // 
            this.NIPkeluar_txt.Location = new System.Drawing.Point(290, 90);
            this.NIPkeluar_txt.Name = "NIPkeluar_txt";
            this.NIPkeluar_txt.Size = new System.Drawing.Size(137, 24);
            this.NIPkeluar_txt.TabIndex = 3;
            this.NIPkeluar_txt.TextChanged += new System.EventHandler(this.NIPkeluar_txt_TextChanged);
            this.NIPkeluar_txt.Validating += new System.ComponentModel.CancelEventHandler(this.NIPkeluar_txt_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama Pegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jam Masuk";
            // 
            // namapegawaikeluar_txt
            // 
            this.namapegawaikeluar_txt.Enabled = false;
            this.namapegawaikeluar_txt.Location = new System.Drawing.Point(290, 133);
            this.namapegawaikeluar_txt.Name = "namapegawaikeluar_txt";
            this.namapegawaikeluar_txt.Size = new System.Drawing.Size(137, 24);
            this.namapegawaikeluar_txt.TabIndex = 7;
            // 
            // jammasukkeluar_txt
            // 
            this.jammasukkeluar_txt.Enabled = false;
            this.jammasukkeluar_txt.Location = new System.Drawing.Point(290, 176);
            this.jammasukkeluar_txt.Name = "jammasukkeluar_txt";
            this.jammasukkeluar_txt.Size = new System.Drawing.Size(137, 24);
            this.jammasukkeluar_txt.TabIndex = 8;
            // 
            // search_button
            // 
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Image = ((System.Drawing.Image)(resources.GetObject("search_button.Image")));
            this.search_button.Location = new System.Drawing.Point(430, 90);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(25, 25);
            this.search_button.TabIndex = 9;
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AbsenKeluar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.jammasukkeluar_txt);
            this.Controls.Add(this.namapegawaikeluar_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NIPkeluar_txt);
            this.Controls.Add(this.absenkeluar_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AbsenKeluar";
            this.Size = new System.Drawing.Size(615, 380);
            this.Load += new System.EventHandler(this.AbsenKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button absenkeluar_btn;
        private System.Windows.Forms.TextBox NIPkeluar_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namapegawaikeluar_txt;
        private System.Windows.Forms.TextBox jammasukkeluar_txt;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
