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
    public partial class AddPegawai : UserControl
    {
        public AddPegawai()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        Regex isAllLetters = new Regex(@"^[a-zA-Z]+$");
        Regex isAlphaNumeric = new Regex(@"^[a-zA-Z0-9/. -]+$");
        Regex isAllNumbers = new Regex(@"^\d+$");
        String namadepan, namabelakang, jeniskelamin, tempatlahir,
            tanggallahir, agama, pendidikan, alamat, statusalamat, notelp, goldarah,
            divisi, jabatan, tanggalmasuk, noktp, nosim, npwp, norek, namarek, namabank, cabangbank;
        private String koneksi;
        MySqlConnection konek;
        MySqlCommand sqlquery;

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
        private void createNIP()
        {
            Random rnd = new Random();
            int nip1 = rnd.Next(100, 1000);
            nip = nip1 + 1000;

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT NIP FROM pegawai WHERE NIP = '" + nip + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                nip1 = rnd.Next(100, 1000);
                nip = nip1 + 1000;
            }
            else
            {
                nipadd_txt.Text = nip.ToString();
            }
        }
        private void clearForm()
        {
            namadepanadd_txt.Text = null;
            namabelakangadd_txt.Text = null;
            lakilakiadd_btn.Checked = false;
            perempuanadd_btn.Checked = false;
            tempatlahiradd_btn.SelectedIndex = -1;
            agamaadd_txt.SelectedIndex = -1;
            pendidikanadd_txt.SelectedIndex = -1;
            alamatadd_txt.Text = null;
            statusalamatadd_txt.SelectedIndex = -1;
            notelpadd_txt.Text = null;
            golAadd_btn.Checked = false;
            golBadd_btn.Checked = false;
            golOadd_btn.Checked = false;
            golABadd_btn.Checked = false;
            divisiadd_txt.SelectedIndex = -1;
            jabatanadd_txt.SelectedIndex = -1;
            noktpadd_txt.Text = null;
            nosimadd_txt.Text = null;
            npwpadd_txt.Text = null;
            norekadd_txt.Text = null;
            namarekadd_txt.Text = null;
            namabankadd_txt.SelectedIndex = -1;
            cabangbankadd_txt.Text = null;
        }
        private void noktpadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(noktpadd_txt.Text))
            {
                errorProvider13.SetError(noktpadd_txt, "Silahkan Masukkan Nomor KTP");
                simpanadd_btn.Enabled = false;
            }
            else if (noktpadd_txt.Text.Length < 12 || noktpadd_txt.Text.Length > 15 || !isAllNumbers.IsMatch(noktpadd_txt.Text))
            {
                errorProvider13.SetError(noktpadd_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider13.SetError(noktpadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void nosimadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nosimadd_txt.Text))
            {
                errorProvider14.SetError(nosimadd_txt, "Silahkan Masukkan Nomor SIM");
                simpanadd_btn.Enabled = false;
            }
            else if (nosimadd_txt.Text.Length < 12 || nosimadd_txt.Text.Length > 15 || !isAllNumbers.IsMatch(nosimadd_txt.Text))
            {
                errorProvider14.SetError(nosimadd_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider14.SetError(nosimadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void npwpadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(npwpadd_txt.Text))
            {
                errorProvider15.SetError(npwpadd_txt, "Silahkan Masukkan Nomor NPWP");
                simpanadd_btn.Enabled = false;
            }
            else if (npwpadd_txt.Text.Length < 12 || npwpadd_txt.Text.Length > 15 || !isAllNumbers.IsMatch(npwpadd_txt.Text))
            {
                errorProvider15.SetError(npwpadd_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider15.SetError(npwpadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void norekadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(norekadd_txt.Text))
            {
                errorProvider16.SetError(norekadd_txt, "Silahkan Masukkan Nomor Rekening");
                simpanadd_btn.Enabled = false;
            }
            else if (norekadd_txt.Text.Length < 12 || norekadd_txt.Text.Length > 15 || !isAllNumbers.IsMatch(norekadd_txt.Text))
            {
                errorProvider16.SetError(norekadd_txt, "Hanya angka, Minimal 12 Karakter, Maksimal 15 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider16.SetError(norekadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void namabankadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (namabankadd_txt.SelectedIndex == -1)
            {
                errorProvider17.SetError(namabankadd_txt, "Pilih Nama Bank");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider17.SetError(namabankadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void cabangbankadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cabangbankadd_txt.Text))
            {
                errorProvider18.SetError(cabangbankadd_txt, "Silahkan Masukkan Alamat Anda");
                simpanadd_btn.Enabled = false;
            }
            else if (cabangbankadd_txt.Text.Length < 5 || cabangbankadd_txt.Text.Length > 20 || !isAlphaNumeric.IsMatch(cabangbankadd_txt.Text))
            {
                errorProvider18.SetError(cabangbankadd_txt, "Minimal 5 Karakter, Maksimal 20 Karakter, Huruf dan Angka");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider18.SetError(cabangbankadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void bataladd_btn_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void nipadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nipadd_txt.Text))
            {
                errorProvider19.SetError(nipadd_txt, "Silahkan Keluar dan Masuk Aplikasi");
                simpanadd_btn.Enabled = false;
            }
            else if (nipadd_txt.Text.Length == 5|| !isAllNumbers.IsMatch(nipadd_txt.Text))
            {
                errorProvider19.SetError(nipadd_txt, "Hanya angka, 4 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider19.SetError(nipadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void namarekadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namarekadd_txt.Text))
            {
                errorProvider20.SetError(namarekadd_txt, "Silahkan Masukkan Nomor Rekening");
                simpanadd_btn.Enabled = false;
            }
            else if (namarekadd_txt.Text.Length < 3 || namarekadd_txt.Text.Length > 40 || !isAllLetters.IsMatch(notelpadd_txt.Text))
            {
                errorProvider20.SetError(namarekadd_txt, "Hanya Huruf, Minimal 6 Karakter, Maksimal 13 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider20.SetError(namarekadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void jabatanadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (jabatanadd_txt.SelectedIndex == -1)
            {
                errorProvider12.SetError(jabatanadd_txt, "Pilih Jabatan");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider12.SetError(jabatanadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void divisiadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (divisiadd_txt.SelectedIndex == -1)
            {
                errorProvider11.SetError(divisiadd_txt, "Pilih Divisi");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider11.SetError(divisiadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void golABadd_btn_Validating(object sender, CancelEventArgs e)
        {
            if(!golAadd_btn.Checked && !golBadd_btn.Checked && !golOadd_btn.Checked && !golABadd_btn.Checked)
            {
                errorProvider10.SetError(groupBox2, "Pilih Jenis Kelamin");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider10.SetError(golABadd_btn, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void notelpadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(notelpadd_txt.Text))
            {
                errorProvider9.SetError(notelpadd_txt, "Silahkan Masukkan Nomor Telepon");
                simpanadd_btn.Enabled = false;
            }
            else if (notelpadd_txt.Text.Length < 6 || notelpadd_txt.Text.Length > 13 || !isAllNumbers.IsMatch(notelpadd_txt.Text))
            {
                errorProvider9.SetError(notelpadd_txt, "Hanya angka, Minimal 6 Karakter, Maksimal 13 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider9.SetError(notelpadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void statusalamatadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (statusalamatadd_txt.SelectedIndex == -1)
            {
                errorProvider8.SetError(statusalamatadd_txt, "Pilih Status Alamat");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider8.SetError(statusalamatadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void alamatadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(alamatadd_txt.Text))
            {
                errorProvider7.SetError(alamatadd_txt, "Silahkan Masukkan Alamat Anda");
                simpanadd_btn.Enabled = false;
            }
            else if (alamatadd_txt.Text.Length < 10 || alamatadd_txt.Text.Length > 50 || !isAlphaNumeric.IsMatch(alamatadd_txt.Text))
            {
                errorProvider7.SetError(alamatadd_txt, "Minimal 10 Karakter, Maksimal 50 Karakter, Huruf dan /-.");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider7.SetError(alamatadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void pendidikanadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (pendidikanadd_txt.SelectedIndex == -1)
            {
                errorProvider6.SetError(pendidikanadd_txt, "Pilih Pendidikan");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider6.SetError(pendidikanadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void agamaadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (agamaadd_txt.SelectedIndex == -1)
            {
                errorProvider5.SetError(agamaadd_txt, "Pilih Agama");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider5.SetError(agamaadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void perempuanadd_btn_Validating(object sender, CancelEventArgs e)
        {
            if (!lakilakiadd_btn.Checked && !perempuanadd_btn.Checked)
            {
                errorProvider3.SetError(perempuanadd_btn, "Pilih Jenis Kelamin");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider3.SetError(perempuanadd_btn, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private void tempatlahiradd_btn_Validating(object sender, CancelEventArgs e)
        {
            if(tempatlahiradd_btn.SelectedIndex == -1)
            {
                errorProvider4.SetError(tempatlahiradd_btn, "Pilih Tempat Lahir");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider4.SetError(tempatlahiradd_btn, null);
                simpanadd_btn.Enabled = true;
            }
        }
        
        private void namabelakangadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namabelakangadd_txt.Text))
            {
                errorProvider2.SetError(namabelakangadd_txt, "Silahkan Masukkan Nama Belakang Anda");
                simpanadd_btn.Enabled = false;
            }
            else if (namabelakangadd_txt.Text.Length < 3 || namabelakangadd_txt.Text.Length > 20 || !isAllLetters.IsMatch(namabelakangadd_txt.Text))
            {
                errorProvider2.SetError(namabelakangadd_txt, "Hanya huruf, Minimal 3 Karakter, Maksimal 20 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider2.SetError(namabelakangadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }


        private void namadepanadd_txt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(namadepanadd_txt.Text))
            {
                errorProvider1.SetError(namadepanadd_txt, "Silahkan Masukkan Nama Depan Anda");
                simpanadd_btn.Enabled = false;
            }
            else if (namadepanadd_txt.Text.Length < 3 || namadepanadd_txt.Text.Length > 20 || !isAllLetters.IsMatch(namadepanadd_txt.Text))
            {
                errorProvider1.SetError(namadepanadd_txt, "Hanya huruf, Minimal 3 Karakter, Maksimal 20 Karakter");
                simpanadd_btn.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(namadepanadd_txt, null);
                simpanadd_btn.Enabled = true;
            }
        }

        private int nip;
        private void AddPegawai_Load(object sender, EventArgs e)
        {
            createNIP();
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
                    jabatanadd_txt.Items.Add(reader.GetString("KodeJabat"));
                }
            }
            catch(Exception ex)
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
                    divisiadd_txt.Items.Add(reader.GetString("KodeDiv"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpanadd_btn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                namadepan = namadepanadd_txt.Text;
                namabelakang = namabelakangadd_txt.Text;
                jeniskelamin = "";
                if (lakilakiadd_btn.Checked == true)
                {
                    jeniskelamin = lakilakiadd_btn.Text;
                }
                else if (perempuanadd_btn.Checked == true)
                {
                    jeniskelamin = perempuanadd_btn.Text;
                }
                tempatlahir = tempatlahiradd_btn.Text;
                tanggallahir = tgllahiradd_date.Value.ToString("dd-mm-yyyy");
                agama = agamaadd_txt.Text;
                pendidikan = pendidikanadd_txt.Text;
                alamat = alamatadd_txt.Text;
                statusalamat = statusalamatadd_txt.Text;
                notelp = notelpadd_txt.Text;
                goldarah = "";
                if (golAadd_btn.Checked == true)
                {
                    goldarah = golAadd_btn.Text;
                }
                else if (golBadd_btn.Checked == true)
                {
                    goldarah = golBadd_btn.Text;
                }
                else if (golOadd_btn.Checked == true)
                {
                    goldarah = golOadd_btn.Text;
                }
                else if (golABadd_btn.Checked == true)
                {
                    goldarah = golABadd_btn.Text;
                }
                divisi = divisiadd_txt.Text;
                jabatan = jabatanadd_txt.Text;
                tanggalmasuk = tglmasukadd_txt.Value.ToString("dd-mm-yyyy");
                noktp = noktpadd_txt.Text;
                nosim = nosimadd_txt.Text;
                npwp = npwpadd_txt.Text;
                norek = norekadd_txt.Text;
                namarek = namarekadd_txt.Text;
                namabank = namabankadd_txt.Text;
                cabangbank = cabangbankadd_txt.Text;

                connect_mysql();
                try
                {
                    sqlquery = konek.CreateCommand();
                    sqlquery.CommandText = "INSERT INTO pegawai(NamaDepan, NamaBelakang, JenisKelamin, TempatLahir, TanggalLahir, Alamat, Status_alamat, Agama, NoTelp, Pendidikan, GolDarah, NIP, TglMasuk, NoKTP, NoSIM, No_NPWP, KodeDiv, KodeJabat, NoRek, NamaRek, NamaBank, CabangBank)" +
                        "VALUES('" + namadepan + "','" + namabelakang + "','" + jeniskelamin + "','" + tempatlahir + "','" + tanggallahir + "','" + alamat + "','" + statusalamat + "','" + agama + "','" + notelp + "','" + pendidikan + "','" + goldarah + "','" + nip + "','" + tanggalmasuk + "','" + noktp + "','" + nosim + "','" + npwp + "','" + divisi + "','" + jabatan + "','" + norek + "','"+namarek+"','" + namabank + "','" + cabangbank + "')";
                    sqlquery.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil isimpan");
                    konek.Close();
                    clearForm();
                    createNIP();
                    
                }
                catch (Exception T)
                {
                    MessageBox.Show(T.Message);
                }
            }
        }
    }
}
