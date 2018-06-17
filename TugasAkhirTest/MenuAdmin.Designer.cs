namespace TugasAkhirTest
{
    partial class MenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.aboutadmin_btn = new System.Windows.Forms.Button();
            this.attendanceadmin_btn = new System.Windows.Forms.Button();
            this.employeeadmin_btn = new System.Windows.Forms.Button();
            this.homeadmin_btn = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.homeAdmin1 = new TugasAkhirTest.HomeAdmin();
            this.about1 = new TugasAkhirTest.About();
            this.attendanceMnAdmin1 = new TugasAkhirTest.AttendanceMnAdmin();
            this.employeeMnAdmin1 = new TugasAkhirTest.EmployeeMnAdmin();
            this.panel1.SuspendLayout();
            this.sidemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.exit_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistem Informasi Kepegawaian";
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.sidemenu.Controls.Add(this.sidepanel);
            this.sidemenu.Controls.Add(this.aboutadmin_btn);
            this.sidemenu.Controls.Add(this.attendanceadmin_btn);
            this.sidemenu.Controls.Add(this.employeeadmin_btn);
            this.sidemenu.Controls.Add(this.homeadmin_btn);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sidemenu.Location = new System.Drawing.Point(0, 40);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(185, 510);
            this.sidemenu.TabIndex = 1;
            // 
            // aboutadmin_btn
            // 
            this.aboutadmin_btn.FlatAppearance.BorderSize = 0;
            this.aboutadmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutadmin_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.aboutadmin_btn.Image = ((System.Drawing.Image)(resources.GetObject("aboutadmin_btn.Image")));
            this.aboutadmin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutadmin_btn.Location = new System.Drawing.Point(16, 290);
            this.aboutadmin_btn.Name = "aboutadmin_btn";
            this.aboutadmin_btn.Size = new System.Drawing.Size(169, 37);
            this.aboutadmin_btn.TabIndex = 7;
            this.aboutadmin_btn.Text = "          About";
            this.aboutadmin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutadmin_btn.UseVisualStyleBackColor = true;
            this.aboutadmin_btn.Click += new System.EventHandler(this.aboutadmin_btn_Click);
            // 
            // attendanceadmin_btn
            // 
            this.attendanceadmin_btn.FlatAppearance.BorderSize = 0;
            this.attendanceadmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceadmin_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.attendanceadmin_btn.Image = ((System.Drawing.Image)(resources.GetObject("attendanceadmin_btn.Image")));
            this.attendanceadmin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceadmin_btn.Location = new System.Drawing.Point(16, 239);
            this.attendanceadmin_btn.Name = "attendanceadmin_btn";
            this.attendanceadmin_btn.Size = new System.Drawing.Size(169, 37);
            this.attendanceadmin_btn.TabIndex = 6;
            this.attendanceadmin_btn.Text = "          Attendance";
            this.attendanceadmin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceadmin_btn.UseVisualStyleBackColor = true;
            this.attendanceadmin_btn.Click += new System.EventHandler(this.attendanceadmin_btn_Click);
            // 
            // employeeadmin_btn
            // 
            this.employeeadmin_btn.FlatAppearance.BorderSize = 0;
            this.employeeadmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeadmin_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.employeeadmin_btn.Image = ((System.Drawing.Image)(resources.GetObject("employeeadmin_btn.Image")));
            this.employeeadmin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeadmin_btn.Location = new System.Drawing.Point(16, 188);
            this.employeeadmin_btn.Name = "employeeadmin_btn";
            this.employeeadmin_btn.Size = new System.Drawing.Size(169, 37);
            this.employeeadmin_btn.TabIndex = 5;
            this.employeeadmin_btn.Text = "          Employee";
            this.employeeadmin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeadmin_btn.UseVisualStyleBackColor = true;
            this.employeeadmin_btn.Click += new System.EventHandler(this.employeeadmin_btn_Click);
            // 
            // homeadmin_btn
            // 
            this.homeadmin_btn.FlatAppearance.BorderSize = 0;
            this.homeadmin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeadmin_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.homeadmin_btn.Image = ((System.Drawing.Image)(resources.GetObject("homeadmin_btn.Image")));
            this.homeadmin_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeadmin_btn.Location = new System.Drawing.Point(16, 137);
            this.homeadmin_btn.Name = "homeadmin_btn";
            this.homeadmin_btn.Size = new System.Drawing.Size(169, 37);
            this.homeadmin_btn.TabIndex = 4;
            this.homeadmin_btn.Text = "          Home";
            this.homeadmin_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeadmin_btn.UseVisualStyleBackColor = true;
            this.homeadmin_btn.Click += new System.EventHandler(this.homeadmin_btn_Click);
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.ForeColor = System.Drawing.Color.Transparent;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.Location = new System.Drawing.Point(758, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(30, 30);
            this.exit_button.TabIndex = 2;
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(255)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 137);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(13, 37);
            this.sidepanel.TabIndex = 6;
            // 
            // homeAdmin1
            // 
            this.homeAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.homeAdmin1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeAdmin1.Location = new System.Drawing.Point(185, 85);
            this.homeAdmin1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeAdmin1.Name = "homeAdmin1";
            this.homeAdmin1.Size = new System.Drawing.Size(615, 465);
            this.homeAdmin1.TabIndex = 2;
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.about1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about1.ForeColor = System.Drawing.SystemColors.Control;
            this.about1.Location = new System.Drawing.Point(185, 85);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(615, 465);
            this.about1.TabIndex = 3;
            // 
            // attendanceMnAdmin1
            // 
            this.attendanceMnAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.attendanceMnAdmin1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceMnAdmin1.ForeColor = System.Drawing.SystemColors.Control;
            this.attendanceMnAdmin1.Location = new System.Drawing.Point(185, 85);
            this.attendanceMnAdmin1.Name = "attendanceMnAdmin1";
            this.attendanceMnAdmin1.Size = new System.Drawing.Size(615, 465);
            this.attendanceMnAdmin1.TabIndex = 4;
            // 
            // employeeMnAdmin1
            // 
            this.employeeMnAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.employeeMnAdmin1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeMnAdmin1.ForeColor = System.Drawing.SystemColors.Control;
            this.employeeMnAdmin1.Location = new System.Drawing.Point(185, 85);
            this.employeeMnAdmin1.Name = "employeeMnAdmin1";
            this.employeeMnAdmin1.Size = new System.Drawing.Size(615, 465);
            this.employeeMnAdmin1.TabIndex = 5;
            // 
            // MenuAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.employeeMnAdmin1);
            this.Controls.Add(this.attendanceMnAdmin1);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.homeAdmin1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidemenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboutadmin_btn;
        private System.Windows.Forms.Button attendanceadmin_btn;
        private System.Windows.Forms.Button employeeadmin_btn;
        private System.Windows.Forms.Button homeadmin_btn;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel sidepanel;
        private HomeAdmin homeAdmin1;
        private About about1;
        private AttendanceMnAdmin attendanceMnAdmin1;
        private EmployeeMnAdmin employeeMnAdmin1;
    }
}