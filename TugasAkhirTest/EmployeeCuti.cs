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
    public partial class EmployeeCuti : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        Regex isAllLetters = new Regex(@"^[a-zA-Z ]+$");
        Regex isAlphaNumeric = new Regex(@"^[a-zA-Z0-9/. -]+$");
        Regex isAllNumbers = new Regex(@"^\d+$");
        public EmployeeCuti()
        {
            InitializeComponent();
        }

        private void EmployeeCuti_Load(object sender, EventArgs e)
        {
        }

        private void ajukancuti_txt_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string tglmulai = mulaicuti_txt.Value.ToString("yyyy-MM-dd");
                string tglakhir = akhircuti_txt.Value.ToString("yyyy-MM-dd");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into cuti(NIP, Tanggal_Mulai, Tanggal_Selesai, Keperluan) values('" + NIIPcuti_txt.Text + "','" + tglmulai + "','" + tglakhir + "','" + keterangancuti_txt.Text + "')";
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
                cmd2.CommandText = "select nip, namapegawai, namadiv, namajabat from employeeinfo where nip = '" + NIIPcuti_txt.Text + "'";
                cmd2.Connection = con;
                MySqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    NIIPcuti_txt.Text = dr["NIP"].ToString();
                    namapegawaicuti_txt.Text = dr["NamaPegawai"].ToString();
                    divisicuti_txt.Text = dr["NamaDiv"].ToString();
                    jabatancuti_txt.Text = dr["NamaJabat"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan");
            }

            con.Close();
        }

        private void keterangancuti_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(keterangancuti_txt.Text))
            {
                errorProvider1.SetError(keterangancuti_txt, "Wajib diisi");
                ajukancuti_txt.Enabled = false;
            }
            else if(keterangancuti_txt.Text.Length < 5 || keterangancuti_txt.Text.Length > 50 || !isAlphaNumeric.IsMatch(keterangancuti_txt.Text))
            {
                errorProvider1.SetError(keterangancuti_txt, "Minimal 5 Karakter, Maksimal 50 Karakter, Huruf dan Angka");
                ajukancuti_txt.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(keterangancuti_txt, null);
                ajukancuti_txt.Enabled = true;
            }
        }

        private void batalcuti_txt_Click(object sender, EventArgs e)
        {
            NIIPcuti_txt.Text = null;
            namapegawaicuti_txt.Text = null;
            divisicuti_txt.Text = null;
            jabatancuti_txt.Text = null;
            mulaicuti_txt.Value = DateTime.Now;
            akhircuti_txt.Value = DateTime.Now;
            keterangancuti_txt.Text = null;
        }
    }
}
