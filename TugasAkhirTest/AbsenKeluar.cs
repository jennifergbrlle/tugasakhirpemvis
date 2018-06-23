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
    public partial class AbsenKeluar : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        Regex isAllLetters = new Regex(@"^[a-zA-Z ]+$");
        Regex isAlphaNumeric = new Regex(@"^[a-zA-Z0-9/. -]+$");
        Regex isAllNumbers = new Regex(@"^\d+$");
        public AbsenKeluar()
        {
            InitializeComponent();
        }

        private void AbsenKeluar_Load(object sender, EventArgs e)
        {
            
        }

        private void absenkeluar_btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                string jamkeluar = DateTime.Now.ToString("H:mm:ss");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update absensi set jamkeluar = '" + jamkeluar + "' where NIP = '" + NIPkeluar_txt.Text + "' and hari_masuk=current_date()";
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

        private void NIPkeluar_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NIPkeluar_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NIPkeluar_txt.Text))
            {
                errorProvider1.SetError(NIPkeluar_txt, "Silahkan masukan NIP");
                absenkeluar_btn.Enabled = false;
            }
            else if(NIPkeluar_txt.Text.Length < 4 || NIPkeluar_txt.Text.Length > 10 || !isAllNumbers.IsMatch(NIPkeluar_txt.Text))
            {
                errorProvider1.SetError(NIPkeluar_txt, "NIP harus terdiri dari 4 digit atau lebih");
                absenkeluar_btn.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(NIPkeluar_txt, null);
                absenkeluar_btn.Enabled = true;
            }
        }
    }
}
