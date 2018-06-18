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
    public partial class EmployeeMnAdmin : UserControl
    {
        public EmployeeMnAdmin()
        {
            InitializeComponent();
            adminInfo1.BringToFront();
        }

        private void infopegawaiadmin_btn_Click(object sender, EventArgs e)
        {
            adminInfo1.BringToFront();
        }

        private void addpegawaiadmin_btn_Click(object sender, EventArgs e)
        {
            addPegawai1.BringToFront();
        }

        private void updatepegawaiadmin_btn_Click(object sender, EventArgs e)
        {
            updatePegawai1.BringToFront();
        }

        private void cutiadmin_btn_Click(object sender, EventArgs e)
        {
            adminCuti1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
