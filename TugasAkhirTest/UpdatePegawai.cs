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
    public partial class UpdatePegawai : UserControl
    {
        public UpdatePegawai()
        {
            InitializeComponent();
        }
        String namadepan, namabelakang, jeniskelamin, tempatlahir,
            tanggallahir, agama, pendidikan, alamat, statusalamat, notelp, goldarah,
            divisi, jabatan, tanggalmasuk, noktp, nosim, npwp, norek, namarek, namabank, cabangbank;
        private String NIPupdate;
        Regex isAllLetters = new Regex(@"^[a-zA-Z ]+$");
        Regex isAlphaNumeric = new Regex(@"^[a-zA-Z0-9/. -]+$");
        Regex isAllNumbers = new Regex(@"^\d+$");
        private String koneksi;
        MySqlConnection konek;
        MySqlCommand sqlquery;

       MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        private void clearForm()
        {
            namadepanupdate_txt.Text = null;
            namablkgupdate_txt.Text = null;
            lakilakiupdate_btn.Checked = false;
            perempuanupdate_btn.Checked = false;
            tempatlahirupdate_btn.SelectedIndex = -1;
            tgllahirupdate_txt.Value = DateTime.Now;
            agamaupdate_txt.SelectedIndex = -1;
            pendidikanupdate_txt.SelectedIndex = -1;
            alamatupdate_txt.Text = null;
            statusalamatupdate_txt.SelectedIndex = -1;
            notelpupdate_txt.Text = null;
            golAupdate_btn.Checked = false;
            golBupdate_btn.Checked = false;
            golOupdate_btn.Checked = false;
            golABupdate_btn.Checked = false;
            divisiupdate_txt.SelectedIndex = -1;
            jabatanupdate_txt.SelectedIndex = -1;
            tglmasukupdate_txt.Value = DateTime.Now;
            noktpupdate_txt.Text = null;
            nosimupdate_txt.Text = null;
            npwpupdate_txt.Text = null;
            norekupdate_txt.Text = null;
            namarekupdate_txt.Text = null;
            namabankupdate_txt.SelectedIndex = -1;
            cabangbankupdate_txt.Text = null;
            cbxUserLevelUpdate.SelectedIndex = -1;
        }
        private void NIPsearch_btn_Click(object sender, EventArgs e)
        {
            NIPupdate = nipupdate_txt.Text;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT NIP FROM pegawai WHERE NIP = '" + NIPupdate + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from pegawai,user where pegawai.NIP = user.username and pegawai.NIP = '" + NIPupdate + "'";
                cmd2.Connection = con;
                MySqlDataReader dr = cmd2.ExecuteReader();

                while (dr.Read())
                {
                    //nipupdate_txt.Text = (dr["NIP"].ToString());
                    namadepanupdate_txt.Text = (dr["NamaDepan"].ToString());
                    namablkgupdate_txt.Text = (dr["NamaBelakang"].ToString());
                    String jeniskelamin = dr["JenisKelamin"].ToString();
                    if (jeniskelamin == "Laki-Laki")
                    {
                        lakilakiupdate_btn.Checked = true;
                    }
                    else if (jeniskelamin == "Perempuan")
                    {
                        perempuanupdate_btn.Checked = true;
                    }
                    else
                    {
                        lakilakiupdate_btn.Checked = false;
                        perempuanupdate_btn.Checked = false;
                    }
                    String tempatlahir = (dr["TempatLahir"].ToString());
                    tempatlahirupdate_btn.SelectedIndex = tempatlahirupdate_btn.FindStringExact(tempatlahir);
                    String tanggalahir = (dr["TanggalLahir"].ToString());
                    tgllahirupdate_txt.Value = DateTime.Parse(tanggalahir);
                    String agama = (dr["Agama"].ToString());
                    agamaupdate_txt.SelectedIndex = agamaupdate_txt.FindStringExact(agama);
                    String pendidikan = (dr["Pendidikan"].ToString());
                    pendidikanupdate_txt.SelectedIndex = pendidikanupdate_txt.FindStringExact(pendidikan);
                    alamatupdate_txt.Text = (dr["Alamat"].ToString());
                    String statusalamat = (dr["Status_Alamat"].ToString());
                    statusalamatupdate_txt.SelectedIndex = statusalamatupdate_txt.FindStringExact(statusalamat);
                    notelpupdate_txt.Text = (dr["NoTelp"].ToString());
                    String goldarah = (dr["GolDarah"].ToString());
                    if (goldarah == "A")
                    {
                        golAupdate_btn.Checked = true;
                    }
                    else if (goldarah == "B")
                    {
                        golBupdate_btn.Checked = true;
                    }
                    else if (goldarah == "O")
                    {
                        golOupdate_btn.Checked = true;
                    }
                    else if (goldarah == "AB")
                    {
                        golABupdate_btn.Checked = true;
                    }
                    else
                    {
                        golAupdate_btn.Checked = false;
                        golBupdate_btn.Checked = false;
                        golOupdate_btn.Checked = false;
                        golABupdate_btn.Checked = false;
                    }
                    String divisi = (dr["KodeDiv"].ToString());
                    divisiupdate_txt.SelectedIndex = divisiupdate_txt.FindStringExact(divisi);
                    String jabatan = (dr["KodeJabat"].ToString());
                    jabatanupdate_txt.SelectedIndex = jabatanupdate_txt.FindStringExact(jabatan);
                    noktpupdate_txt.Text = (dr["NoKTP"].ToString());
                    nosimupdate_txt.Text = (dr["NoSIM"].ToString());
                    npwpupdate_txt.Text = (dr["No_NPWP"].ToString());
                    norekupdate_txt.Text = (dr["NoRek"].ToString());
                    namarekupdate_txt.Text = (dr["NamaRek"].ToString());
                    String namabank = (dr["NamaBank"].ToString());
                    namabankupdate_txt.SelectedIndex = namabankupdate_txt.FindStringExact(namabank);
                    cabangbankupdate_txt.Text = (dr["CabangBank"].ToString());
                    String leveluser = (dr["level"].ToString());
                    cbxUserLevelUpdate.SelectedIndex = cbxUserLevelUpdate.FindStringExact(leveluser);
                }
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan");
            }
            con.Close();
            
        }

        private void nipupdate_txt_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrWhiteSpace(nipupdate_txt.Text))
            {
                errorProvider1.SetError(NIPsearch_btn, "Silahkan Masukkan Nomor Rekening");
                NIPsearch_btn.Enabled = false;
            }
            else if (nipupdate_txt.Text.Length > 5 || !isAllNumbers.IsMatch(nipupdate_txt.Text))
            {
                errorProvider1.SetError(NIPsearch_btn, "Hanya angka, Minimal 5 Karakter");
                NIPsearch_btn.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(NIPsearch_btn, null);
                NIPsearch_btn.Enabled = true;
            }
        }

        private void namadepanupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namadepanupdate_txt.Text))
            {
                errorProvider2.SetError(namadepanupdate_txt, "Silahkan Masukkan Nama Depan Anda");
                update_btn.Enabled = false;
            }
            else if (namadepanupdate_txt.Text.Length < 3 || namadepanupdate_txt.Text.Length > 20 || !isAllLetters.IsMatch(namadepanupdate_txt.Text))
            {
                errorProvider2.SetError(namadepanupdate_txt, "Hanya huruf, Minimal 3 Karakter, Maksimal 20 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider2.SetError(namadepanupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void UpdatePegawai_Load(object sender, EventArgs e)
        {
            try
            {
                //SELECT * from sistem_pegawai.jabatan
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;Database=sistem_pegawai;username=root;password=");
                string selectQuery = "SELECT * from sistem_pegawai.jabatan"/*"SELECT jabatan.KodeJabat,NamaJabat FROM pegawai,jabatan where pegawai.KodeJabat=jabatan.KodeJabat"*/;
                connection.Open();
                MySqlCommand command = new MySqlCommand(selectQuery, connection);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    jabatanupdate_txt.Items.Add(reader.GetString("KodeJabat"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                MySqlConnection connection = new MySqlConnection("Datasource=localhost;username=root;password=");
                string selectQuery2 = "SELECT * from sistem_pegawai.divisi";
                connection.Open();
                MySqlCommand command2 = new MySqlCommand(selectQuery2, connection);

                MySqlDataReader reader = command2.ExecuteReader();

                while (reader.Read())
                {
                    divisiupdate_txt.Items.Add(reader.GetString("KodeDiv"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nipupdate_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NIPsearch_btn_Click(this, new EventArgs());
            }
        }

        private void batalupdate_btn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cbxUserLevel_Validating(object sender, CancelEventArgs e)
        {
            if (cbxUserLevelUpdate.SelectedIndex == -1)
            {
                errorProvider21.SetError(cbxUserLevelUpdate, "Pilih Level User");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider21.SetError(cbxUserLevelUpdate, null);
                update_btn.Enabled = true;
            }
        }

        private void namablkgupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namablkgupdate_txt.Text))
            {
                errorProvider3.SetError(namablkgupdate_txt, "Silahkan Masukkan Nama Belakang Anda");
                update_btn.Enabled = false;
            }
            else if (namablkgupdate_txt.Text.Length < 3 || namablkgupdate_txt.Text.Length > 20 || !isAllLetters.IsMatch(namablkgupdate_txt.Text))
            {
                errorProvider3.SetError(namablkgupdate_txt, "Hanya huruf, Minimal 3 Karakter, Maksimal 20 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider3.SetError(namablkgupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void lakilakiupdate_btn_Validating(object sender, CancelEventArgs e)
        {
            if (!lakilakiupdate_btn.Checked && !perempuanupdate_btn.Checked)
            {
                errorProvider4.SetError(perempuanupdate_btn, "Pilih Jenis Kelamin");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider4.SetError(perempuanupdate_btn, null);
                update_btn.Enabled = true;
            }
        }

        private void tempatlahirupdate_btn_Validating(object sender, CancelEventArgs e)
        {
            if (tempatlahirupdate_btn.SelectedIndex == -1)
            {
                errorProvider5.SetError(tempatlahirupdate_btn, "Pilih Tempat Lahir");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider5.SetError(tempatlahirupdate_btn, null);
                update_btn.Enabled = true;
            }
        }

        private void agamaupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (agamaupdate_txt.SelectedIndex == -1)
            {
                errorProvider6.SetError(agamaupdate_txt, "Pilih Agama");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider6.SetError(agamaupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void pendidikanupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (pendidikanupdate_txt.SelectedIndex == -1)
            {
                errorProvider7.SetError(pendidikanupdate_txt, "Pilih Pendidikan");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider7.SetError(pendidikanupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void alamatupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(alamatupdate_txt.Text))
            {
                errorProvider8.SetError(alamatupdate_txt, "Silahkan Masukkan Alamat Anda");
                update_btn.Enabled = false;
            }
            else if (alamatupdate_txt.Text.Length < 10 || alamatupdate_txt.Text.Length > 50 || !isAlphaNumeric.IsMatch(alamatupdate_txt.Text))
            {
                errorProvider8.SetError(alamatupdate_txt, "Minimal 10 Karakter, Maksimal 50 Karakter, Huruf dan /-.");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider8.SetError(alamatupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void statusalamatupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (statusalamatupdate_txt.SelectedIndex == -1)
            {
                errorProvider9.SetError(statusalamatupdate_txt, "Pilih Status Alamat");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider9.SetError(statusalamatupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void golABupdate_btn_Validating(object sender, CancelEventArgs e)
        {
            if (!golAupdate_btn.Checked && !golBupdate_btn.Checked && !golOupdate_btn.Checked && !golABupdate_btn.Checked)
            {
                errorProvider10.SetError(groupBox1, "Pilih Jenis Kelamin");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider10.SetError(groupBox1, null);
                update_btn.Enabled = true;
            }
        }

        private void divisiupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (divisiupdate_txt.SelectedIndex == -1)
            {
                errorProvider11.SetError(divisiupdate_txt, "Pilih Divisi");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider11.SetError(divisiupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void jabatanupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (jabatanupdate_txt.SelectedIndex == -1)
            {
                errorProvider12.SetError(jabatanupdate_txt, "Pilih Jabatan");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider12.SetError(jabatanupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void noktpupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(noktpupdate_txt.Text))
            {
                errorProvider13.SetError(noktpupdate_txt, "Silahkan Masukkan Nomor KTP");
                update_btn.Enabled = false;
            }
            else if (noktpupdate_txt.Text.Length < 12 || noktpupdate_txt.Text.Length > 15 || !isAllNumbers.IsMatch(noktpupdate_txt.Text))
            {
                errorProvider13.SetError(noktpupdate_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider13.SetError(noktpupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void nosimupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nosimupdate_txt.Text))
            {
                errorProvider14.SetError(nosimupdate_txt, "Silahkan Masukkan Nomor SIM");
                update_btn.Enabled = false;
            }
            else if (nosimupdate_txt.Text.Length < 12 || nosimupdate_txt.Text.Length > 15 || !isAllNumbers.IsMatch(nosimupdate_txt.Text))
            {
                errorProvider14.SetError(nosimupdate_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider14.SetError(nosimupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void npwpupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(npwpupdate_txt.Text))
            {
                errorProvider15.SetError(npwpupdate_txt, "Silahkan Masukkan Nomor NPWP");
                update_btn.Enabled = false;
            }
            else if (npwpupdate_txt.Text.Length < 12 || npwpupdate_txt.Text.Length > 15 || !isAllNumbers.IsMatch(npwpupdate_txt.Text))
            {
                errorProvider15.SetError(npwpupdate_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider15.SetError(npwpupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void norekupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(norekupdate_txt.Text))
            {
                errorProvider16.SetError(norekupdate_txt, "Silahkan Masukkan Nomor Rekening");
                update_btn.Enabled = false;
            }
            else if (norekupdate_txt.Text.Length < 12 || norekupdate_txt.Text.Length > 15 || !isAllNumbers.IsMatch(norekupdate_txt.Text))
            {
                errorProvider16.SetError(norekupdate_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider16.SetError(norekupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void namarekupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namarekupdate_txt.Text))
            {
                errorProvider17.SetError(namarekupdate_txt, "Silahkan Masukkan Nomor Rekening");
                update_btn.Enabled = false;
            }
            else if (namarekupdate_txt.Text.Length < 3 || namarekupdate_txt.Text.Length > 40 || !isAllLetters.IsMatch(namarekupdate_txt.Text))
            {
                errorProvider17.SetError(namarekupdate_txt, "Hanya Huruf, Minimal 3 Karakter, Maksimal 13 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider17.SetError(namarekupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void namabankupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (namabankupdate_txt.SelectedIndex == -1)
            {
                errorProvider18.SetError(namabankupdate_txt, "Pilih Nama Bank");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider18.SetError(namabankupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void cabangbankupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cabangbankupdate_txt.Text))
            {
                errorProvider19.SetError(cabangbankupdate_txt, "Silahkan Masukkan Alamat Anda");
                update_btn.Enabled = false;
            }
            else if (cabangbankupdate_txt.Text.Length < 5 || cabangbankupdate_txt.Text.Length > 20 || !isAlphaNumeric.IsMatch(cabangbankupdate_txt.Text))
            {
                errorProvider19.SetError(cabangbankupdate_txt, "Minimal 5 Karakter, Maksimal 20 Karakter, Huruf dan Angka");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider19.SetError(cabangbankupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void notelpupdate_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(notelpupdate_txt.Text))
            {
                errorProvider9.SetError(notelpupdate_txt, "Silahkan Masukkan Nomor Telepon");
                update_btn.Enabled = false;
            }
            else if (notelpupdate_txt.Text.Length < 6 || notelpupdate_txt.Text.Length > 13 || !isAllNumbers.IsMatch(notelpupdate_txt.Text))
            {
                errorProvider9.SetError(notelpupdate_txt, "Hanya angka, Minimal 6 Karakter, Maksimal 13 Karakter");
                update_btn.Enabled = false;
            }
            else
            {
                errorProvider9.SetError(notelpupdate_txt, null);
                update_btn.Enabled = true;
            }
        }

        private void connect_mysql()
        {
            try
            {
                koneksi = "Server=localhost;Database=sistem_pegawai;Uid=root;Pwd=;";
                konek = new MySqlConnection(koneksi);
                konek.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                namadepan = namadepanupdate_txt.Text;
                namabelakang = namablkgupdate_txt.Text;
                jeniskelamin = "";
                if (lakilakiupdate_btn.Checked == true)
                {
                    jeniskelamin = lakilakiupdate_btn.Text;
                }
                else if (perempuanupdate_btn.Checked == true)
                {
                    jeniskelamin = perempuanupdate_btn.Text;
                }
                tempatlahir = tempatlahirupdate_btn.Text;
                tanggallahir = tgllahirupdate_txt.Value.ToString("yyyy-MM-dd");
                agama = agamaupdate_txt.Text;
                pendidikan = pendidikanupdate_txt.Text;
                alamat = alamatupdate_txt.Text;
                statusalamat = statusalamatupdate_txt.Text;
                notelp = notelpupdate_txt.Text;
                goldarah = "";
                if (golAupdate_btn.Checked == true)
                {
                    goldarah = golAupdate_btn.Text;
                }
                else if (golBupdate_btn.Checked == true)
                {
                    goldarah = golBupdate_btn.Text;
                }
                else if (golOupdate_btn.Checked == true)
                {
                    goldarah = golOupdate_btn.Text;
                }
                else if (golABupdate_btn.Checked == true)
                {
                    goldarah = golABupdate_btn.Text;
                }
                divisi = divisiupdate_txt.Text;
                jabatan = jabatanupdate_txt.Text;
                tanggalmasuk = tglmasukupdate_txt.Value.ToString("yyyy-MM-dd");
                noktp = noktpupdate_txt.Text;
                nosim = nosimupdate_txt.Text;
                npwp = npwpupdate_txt.Text;
                norek = norekupdate_txt.Text;
                namarek = namarekupdate_txt.Text;
                namabank = namabankupdate_txt.Text;
                cabangbank = cabangbankupdate_txt.Text;

                connect_mysql();
                try
                {
                    sqlquery = konek.CreateCommand();
                    sqlquery.CommandText = "UPDATE pegawai SET NamaDepan = '" + namadepan + "', NamaBelakang = '" + namabelakang + "', JenisKelamin = '" + jeniskelamin + "', TempatLahir = '" + tempatlahir + "', TanggalLahir = '" + tanggallahir + "', Alamat = '" + alamat + "', Status_alamat = '" + statusalamat + "', Agama = '" + agama + "', NoTelp = '" + notelp + "', Pendidikan = '" + pendidikan + "', GolDarah = '" + goldarah + "', TglMasuk = '" + tanggalmasuk + "', NoKTP = '" + noktp + "', NoSIM = '" + nosim + "', No_NPWP = '" + npwp + "', KodeDiv = '" + divisi + "', KodeJabat = '" + jabatan + "', NoRek = '" + norek + "', NamaRek = '" + namarek + "', NamaBank = '" + namabank + "', CabangBank = '" + cabangbank + "' WHERE NIP = '" + NIPupdate + "'";
                    sqlquery.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Diupdate");
                    konek.Close();
                    clearForm();
                    //createNIP();

                }
                catch (Exception T)
                {
                    MessageBox.Show(T.Message);
                }
            }
        }
    }
}
