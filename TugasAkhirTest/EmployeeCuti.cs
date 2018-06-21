using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TugasAkhirTest
{
    public partial class EmployeeCuti : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        public EmployeeCuti()
        {
            InitializeComponent();
        }

        private void EmployeeCuti_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nip, namapegawai, namadiv, namajabat, username from employeeinfo, user where user.username like employeeinfo.nip";
            cmd.Connection = con;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NIIPcuti_txt.Text = dr["NIP"].ToString();
                namapegawaicuti_txt.Text = dr["NamaPegawai"].ToString();
                divisicuti_txt.Text = dr["NamaDiv"].ToString();
                jabatancuti_txt.Text = dr["NamaJabat"].ToString();
            }
            con.Close();
        }

        private void ajukancuti_txt_Click(object sender, EventArgs e)
        {
            string tglmulai = mulaicuti_txt.Value.ToString("yyyy-MM-dd");
            string tglakhir = akhircuti_txt.Value.ToString("yyyy-MM-dd");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into cuti(NIP, Tanggal_Mulai, Tanggal_Selesai, Keperluan) values('"+NIIPcuti_txt.Text+"','"+tglmulai+"','"+tglakhir+"','"+keterangancuti_txt.Text+"')";
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Cuti diajukan");
            }
            else
            {
                MessageBox.Show("Cuti gagal diajukan");
            }
            con.Close();
        }
    }
}
