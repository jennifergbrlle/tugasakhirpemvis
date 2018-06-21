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
    public partial class AbsenMasuk : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        public AbsenMasuk()
        {
            InitializeComponent();
        }

        private void AbsenMasuk_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nip, namapegawai, namadiv, namajabat, username from employeeinfo, user where user.username like employeeinfo.nip";
            cmd.Connection = con;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NIPmasuk_txt.Text = dr["NIP"].ToString();
                namapegawaimasuk_txt.Text = dr["NamaPegawai"].ToString();
                divisimasuk_txt.Text = dr["NamaDiv"].ToString();
                jabatanmasuk_txt.Text = dr["NamaJabat"].ToString();
            }
            con.Close();

            timer1.Start();
            hari.Text = DateTime.Now.ToLongDateString();
            jam.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void simpanmasuk_btn_Click(object sender, EventArgs e)
        {
            string harimasuk = DateTime.Today.ToString("yyyy-MM-dd");
            string jammasuk = DateTime.Now.ToString("H:mm:ss");
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into absensi(NIP, Hari_Masuk, JamMasuk) values('"+NIPmasuk_txt.Text+"','"+harimasuk+"','"+jammasuk+"' )";
            cmd.Connection = con;
            if(cmd.ExecuteNonQuery()==1){
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
