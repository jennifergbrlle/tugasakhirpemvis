namespace TugasAkhirTest
{
    partial class AttendanceMnAdmin
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
            this.absensiadmin_btn = new System.Windows.Forms.Button();
            this.laporanabsensiadmin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // absensiadmin_btn
            // 
            this.absensiadmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.absensiadmin_btn.Location = new System.Drawing.Point(173, 13);
            this.absensiadmin_btn.Name = "absensiadmin_btn";
            this.absensiadmin_btn.Size = new System.Drawing.Size(75, 33);
            this.absensiadmin_btn.TabIndex = 0;
            this.absensiadmin_btn.Text = "Absensi";
            this.absensiadmin_btn.UseVisualStyleBackColor = true;
            // 
            // laporanabsensiadmin_btn
            // 
            this.laporanabsensiadmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laporanabsensiadmin_btn.Location = new System.Drawing.Point(273, 13);
            this.laporanabsensiadmin_btn.Name = "laporanabsensiadmin_btn";
            this.laporanabsensiadmin_btn.Size = new System.Drawing.Size(146, 33);
            this.laporanabsensiadmin_btn.TabIndex = 1;
            this.laporanabsensiadmin_btn.Text = "Laporan Absensi";
            this.laporanabsensiadmin_btn.UseVisualStyleBackColor = true;
            // 
            // AttendanceMnAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.laporanabsensiadmin_btn);
            this.Controls.Add(this.absensiadmin_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AttendanceMnAdmin";
            this.Size = new System.Drawing.Size(582, 445);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button absensiadmin_btn;
        private System.Windows.Forms.Button laporanabsensiadmin_btn;
    }
}
