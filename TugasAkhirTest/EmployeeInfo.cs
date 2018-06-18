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
    public partial class EmployeeInfo : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        public EmployeeInfo()
        {
            InitializeComponent();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *, username from employeeinfo, user where user.username like employeeinfo.nip and nip = '"+NIPinfo_txt.Text+"' ";
            //cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                namapegawaiinfo_txt.Text = (dr["NamaPegawai"].ToString());
                jeniskelamininfo_txt.Text = (dr["JenisKelamin"].ToString());
                ttlinfo_txt.Text = (dr["TempatTglLahir"].ToString());
                agamainfo_txt.Text = (dr["Agama"].ToString());
                pendidikaninfo_txt.Text = (dr["Pendidikan"].ToString());
                alamatinfo_txt.Text = (dr["Alamat"].ToString());
                statusalamatinfo_txt.Text = (dr["Status_alamat"].ToString());
                notelpinfo_txt.Text = (dr["NoTelp"].ToString());
                goldarahinfo_txt.Text = (dr["GolDarah"].ToString());
                divisiinfo_txt.Text = (dr["NamaDiv"].ToString());
                jabataninfo_txt.Text = (dr["NamaJabat"].ToString());
                tglmasukinfo_txt.Text = (dr["TglMasuk"].ToString());
                noktpinfo_txt.Text = (dr["NoKTP"].ToString());
                nosiminfo_txt.Text = (dr["NoSIM"].ToString());
                npwpinfo_txt.Text = (dr["No_NPWP"].ToString());
                norekinfo_txt.Text = (dr["NoRek"].ToString());
                namarekinfo_txt.Text = (dr["NamaRek"].ToString());
                namabankinfo_txt.Text = (dr["NamaBank"].ToString());
                cabangbankinfo_txt.Text = (dr["CabangBank"].ToString());
            }
            con.Close();
        }
    }
}
