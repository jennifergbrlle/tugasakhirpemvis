using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace TugasAkhirTest
{
    public partial class MenuKaryawan : Form
    {
        public string b;
        public void ab(string a)
        {
            b = a.ToString();
        }
        public MenuKaryawan()
        {
            InitializeComponent();
            sidepanel.Height = homekaryawan_btn.Height;
            sidepanel.Top = homekaryawan_btn.Top;
            homeKaryawan1.BringToFront();
        }
        private void homekaryawan_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = homekaryawan_btn.Height;
            sidepanel.Top = homekaryawan_btn.Top;
            homeKaryawan1.BringToFront();
        }

        private void aboutkaryawan_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = aboutkaryawan_btn.Height;
            sidepanel.Top = aboutkaryawan_btn.Top;
            about1.BringToFront();
        }

        private void employeekaryawan_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = employeekaryawan_btn.Height;
            sidepanel.Top = employeekaryawan_btn.Top;
            employeeMnKaryawan1.BringToFront();
        }

        private void attendancekaryawan_btn_Click(object sender, EventArgs e)
        {
            sidepanel.Height = attendancekaryawan_btn.Height;
            sidepanel.Top = attendancekaryawan_btn.Top;
            attendanceMnKaryawan1.BringToFront();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employeeMnKaryawan1_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuKaryawan_Load(object sender, EventArgs e)
        {
        }
        
    }
}
