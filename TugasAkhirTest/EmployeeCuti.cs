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

        private void search_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nip from employeeinfo where nip='" + NIIPcuti_txt.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select nip, namapegawai, namadiv, namajabat,jatahcuti from employeeinfo where nip = '" + NIIPcuti_txt.Text + "'";
                cmd2.Connection = con;
                MySqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    NIIPcuti_txt.Text = dr["NIP"].ToString();
                    namapegawaicuti_txt.Text = dr["NamaPegawai"].ToString();
                    divisicuti_txt.Text = dr["NamaDiv"].ToString();
                    jabatancuti_txt.Text = dr["NamaJabat"].ToString();
                    sisacuti_txt.Text = dr["JatahCuti"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan");
            }

            con.Close();
        }

        private void akhircuti_txt_CloseUp(object sender, EventArgs e)
        {
            DateTime awalcuti = Convert.ToDateTime(mulaicuti_txt.Text);
            DateTime akhircuti = Convert.ToDateTime(akhircuti_txt.Text);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select jatahcuti from employeeinfo where nip = '" + NIIPcuti_txt.Text + "'";
            cmd.Connection = con;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int jatahcuti = Convert.ToInt32(dr["JatahCuti"]);
                if (awalcuti < akhircuti)
                {
                    TimeSpan ts = akhircuti.Subtract(awalcuti);
                    int jumlahcuti = ts.Days;
                    if (jatahcuti < jumlahcuti)
                    {
                        MessageBox.Show("Jatah cuti tidak mencukupi");
                        akhircuti_txt.Value = DateTime.Now;
                    }
                }
                else
                {
                    MessageBox.Show("Mulai cuti harus lebih kecil dari akhir cuti");
                    akhircuti_txt.Value = DateTime.Now;
                }
            }
            con.Close();
        }
    }
}
