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
            
        }

        private void absenkeluar_btn_Click(object sender, EventArgs e)
        {
            string jamkeluar = DateTime.Now.ToString("H:mm:ss");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update absensi set jamkeluar = '"+jamkeluar+"' where NIP = '"+NIPkeluar_txt.Text+"' and hari_masuk=current_date()";
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

        private void search_button_Click(object sender, EventArgs e)
        {
            string NIPkeluar = NIPkeluar_txt.Text;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nip from absensi where nip='" + NIPkeluar + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count >= 1)
            {
                //con.Open();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select absensi.NIP, namapegawai, jammasuk from employeeinfo, absensi where employeeinfo.nip=absensi.nip and absensi.NIP = '"+NIPkeluar+"' and hari_masuk=current_date()";
                cmd2.Connection = con;
                MySqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    NIPkeluar_txt.Text = dr["NIP"].ToString();
                    namapegawaikeluar_txt.Text = dr["namapegawai"].ToString();
                    jammasukkeluar_txt.Text = dr["jammasuk"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan");
            }
            con.Close();
        }
    }
}
