using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhirTest
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            sidepanel.Height = homeadmin_btn.Height;
            sidepanel.Top = homeadmin_btn.Top;
            homeAdmin1.BringToFront();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void homeadmin_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = homeadmin_btn.Height;
            sidepanel.Top = homeadmin_btn.Top;
            homeAdmin1.BringToFront();
        }

        private void employeeadmin_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = employeeadmin_btn.Height;
            sidepanel.Top = employeeadmin_btn.Top;
            employeeMnAdmin1.BringToFront();
        }

        private void attendanceadmin_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = attendanceadmin_btn.Height;
            sidepanel.Top = attendanceadmin_btn.Top;
            attendanceMnAdmin1.BringToFront();
        }

        private void aboutadmin_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = aboutadmin_btn.Height;
            sidepanel.Top = aboutadmin_btn.Top;
            about1.BringToFront();
        }
    }
}
