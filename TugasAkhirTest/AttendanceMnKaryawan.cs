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
    public partial class AttendanceMnKaryawan : UserControl
    {
        public AttendanceMnKaryawan()
        {
            InitializeComponent();
            absenMasuk1.BringToFront();
        }

        private void absenmasuk_btn_Click(object sender, EventArgs e)
        {
            absenMasuk1.BringToFront();
        }

        private void absenkeluar_btn_Click(object sender, EventArgs e)
        {
            absenKeluar1.BringToFront();
        }
    }
}
