using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhirTest
{
    public partial class EmployeeMnKaryawan : UserControl
    {
        public EmployeeMnKaryawan()
        {
            InitializeComponent();
            employeeInfo1.BringToFront();
        }

        private void employeeinfokaryawan_btn_Click(object sender, EventArgs e)
        {
            employeeInfo1.BringToFront();
        }

        private void cutikaryawan_btn_Click(object sender, EventArgs e)
        {
            employeeCuti1.BringToFront();
        }
    }
}
