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
    public partial class AbsenKeluar : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        public AbsenKeluar()
        {
            InitializeComponent();
        }

        private void AbsenKeluar_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select employeeinfo.nip, namapegawai, namadiv, namajabat, hari_masuk, jammasuk, username from employeeinfo, user, absensi where user.username = employeeinfo.nip and employeeinfo.nip = absensi.nip";
            cmd.Connection = con;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                info_txt.Text = dr["NIP"] + "\n" + dr["NamaPegawai"]+"\n"+dr["NamaDiv"]+"\n"+dr["NamaJabat"]+"\n"+dr["Hari_Masuk"]+"\n"+dr["JamMasuk"].ToString();
            }
            con.Close();
        }

        private void absenkeluar_btn_Click(object sender, EventArgs e)
        {
            string jamkeluar = DateTime.Now.ToString("H:mm:ss");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update absensi set jamkeluar = '"+jamkeluar+"' where ";
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Absen disimpan");
            }
            else
            {
                MessageBox.Show("Absen gagal");
            }
            con.Close();
        }
    }
}
