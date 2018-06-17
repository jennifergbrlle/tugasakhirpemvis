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
    public partial class AttendanceMnAdmin : UserControl
    {
        public AttendanceMnAdmin()
        {
            InitializeComponent();
            absensiAdmin1.BringToFront();
        }

        private void absensiadmin_btn_Click(object sender, EventArgs e)
        {
            absensiAdmin1.BringToFront();
        }

        private void laporanabsensiadmin_btn_Click(object sender, EventArgs e)
        {
            laporanAbsen1.BringToFront();
        }
    }
}
