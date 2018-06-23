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
using System.Text.RegularExpressions;

namespace TugasAkhirTest
{
    public partial class AbsenMasuk : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        Regex isAllLetters = new Regex(@"^[a-zA-Z ]+$");
        Regex isAlphaNumeric = new Regex(@"^[a-zA-Z0-9/. -]+$");
        Regex isAllNumbers = new Regex(@"^\d+$");
        public AbsenMasuk()
        {
            InitializeComponent();
        }

        private void AbsenMasuk_Load(object sender, EventArgs e)
        { 
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            string NIPMasuk = NIPmasuk_txt.Text;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nip from employeeinfo where nip='" + NIPMasuk + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
               // con.Open();
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select nip, namapegawai, namadiv, namajabat from employeeinfo where nip = '"+NIPMasuk+"'";
                cmd2.Connection = con;
                MySqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    NIPmasuk_txt.Text = dr["NIP"].ToString();
                    namapegawaimasuk_txt.Text = dr["NamaPegawai"].ToString();
                    divisimasuk_txt.Text = dr["NamaDiv"].ToString();
                    jabatanmasuk_txt.Text = dr["NamaJabat"].ToString();
                }
                
            }
            con.Close();
        }

        private void NIPmasuk_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NIPmasuk_txt.Text))
            {
                errorProvider1.SetError(NIPmasuk_txt, "Silahkan masukan NIP");
                simpanmasuk_btn.Enabled = false;
            }
            else if (NIPmasuk_txt.Text.Length < 4 || NIPmasuk_txt.Text.Length > 10 || !isAllNumbers.IsMatch(NIPmasuk_txt.Text))
            {
                errorProvider1.SetError(NIPmasuk_txt, "NIP harus terdiri dari 4 digit atau lebih");
                simpanmasuk_btn.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(NIPmasuk_txt, null);
                simpanmasuk_btn.Enabled = true;
            }
        }
    }
}
