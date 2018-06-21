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
            this.info_txt = new System.Windows.Forms.Label();
            this.absenkeluar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Absen Keluar";
            // 
            // info_txt
            // 
            this.info_txt.AutoSize = true;
            this.info_txt.Location = new System.Drawing.Point(230, 101);
            this.info_txt.Name = "info_txt";
            this.info_txt.Size = new System.Drawing.Size(41, 16);
            this.info_txt.TabIndex = 1;
            this.info_txt.Text = "label2";
            // 
            // absenkeluar_btn
            // 
            this.absenkeluar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absenkeluar_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenkeluar_btn.Location = new System.Drawing.Point(241, 296);
            this.absenkeluar_btn.Name = "absenkeluar_btn";
            this.absenkeluar_btn.Size = new System.Drawing.Size(100, 33);
            this.absenkeluar_btn.TabIndex = 2;
            this.absenkeluar_btn.Text = "Absen Keluar";
            this.absenkeluar_btn.UseVisualStyleBackColor = true;
            this.absenkeluar_btn.Click += new System.EventHandler(this.absenkeluar_btn_Click);
            // 
            // AbsenKeluar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.absenkeluar_btn);
            this.Controls.Add(this.info_txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AbsenKeluar";
            this.Size = new System.Drawing.Size(615, 380);
            this.Load += new System.EventHandler(this.AbsenKeluar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info_txt;
        private System.Windows.Forms.Button absenkeluar_btn;
    }
}
