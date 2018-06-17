namespace TugasAkhirTest
{
    partial class EmployeeMnKaryawan
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
            this.employeeinfokaryawan_btn = new System.Windows.Forms.Button();
            this.cutikaryawan_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // employeeinfokaryawan_btn
            // 
            this.employeeinfokaryawan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeinfokaryawan_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeinfokaryawan_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.employeeinfokaryawan_btn.Location = new System.Drawing.Point(150, 13);
            this.employeeinfokaryawan_btn.Name = "employeeinfokaryawan_btn";
            this.employeeinfokaryawan_btn.Size = new System.Drawing.Size(153, 33);
            this.employeeinfokaryawan_btn.TabIndex = 0;
            this.employeeinfokaryawan_btn.Text = "Employee Info";
            this.employeeinfokaryawan_btn.UseVisualStyleBackColor = true;
            // 
            // cutikaryawan_btn
            // 
            this.cutikaryawan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutikaryawan_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutikaryawan_btn.Location = new System.Drawing.Point(326, 13);
            this.cutikaryawan_btn.Name = "cutikaryawan_btn";
            this.cutikaryawan_btn.Size = new System.Drawing.Size(113, 33);
            this.cutikaryawan_btn.TabIndex = 1;
            this.cutikaryawan_btn.Text = "Cuti";
            this.cutikaryawan_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 380);
            this.panel1.TabIndex = 2;
            // 
            // EmployeeMnKaryawan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cutikaryawan_btn);
            this.Controls.Add(this.employeeinfokaryawan_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "EmployeeMnKaryawan";
            this.Size = new System.Drawing.Size(615, 465);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employeeinfokaryawan_btn;
        private System.Windows.Forms.Button cutikaryawan_btn;
        private System.Windows.Forms.Panel panel1;
    }
}
