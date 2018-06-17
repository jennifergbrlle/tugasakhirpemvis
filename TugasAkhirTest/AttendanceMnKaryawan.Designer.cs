namespace TugasAkhirTest
{
    partial class AttendanceMnKaryawan
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
            this.absenmasuk_btn = new System.Windows.Forms.Button();
            this.absenkeluar_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // absenmasuk_btn
            // 
            this.absenmasuk_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absenmasuk_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenmasuk_btn.Location = new System.Drawing.Point(129, 18);
            this.absenmasuk_btn.Name = "absenmasuk_btn";
            this.absenmasuk_btn.Size = new System.Drawing.Size(163, 33);
            this.absenmasuk_btn.TabIndex = 0;
            this.absenmasuk_btn.Text = "Absen Masuk";
            this.absenmasuk_btn.UseVisualStyleBackColor = true;
            // 
            // absenkeluar_btn
            // 
            this.absenkeluar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absenkeluar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.absenkeluar_btn.Location = new System.Drawing.Point(322, 18);
            this.absenkeluar_btn.Name = "absenkeluar_btn";
            this.absenkeluar_btn.Size = new System.Drawing.Size(163, 33);
            this.absenkeluar_btn.TabIndex = 1;
            this.absenkeluar_btn.Text = "Absen Keluar";
            this.absenkeluar_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 379);
            this.panel1.TabIndex = 2;
            // 
            // AttendanceMnKaryawan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.absenkeluar_btn);
            this.Controls.Add(this.absenmasuk_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AttendanceMnKaryawan";
            this.Size = new System.Drawing.Size(615, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button absenmasuk_btn;
        private System.Windows.Forms.Button absenkeluar_btn;
        private System.Windows.Forms.Panel panel1;
    }
}
