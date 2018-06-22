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
    public partial class AdminCuti : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        public AdminCuti()
        {
            InitializeComponent();
           
        }

        private void AdminCuti_Load(object sender, EventArgs e)
        {
            data();

            //accept button
            DataGridViewButtonColumn acceptbtn = new DataGridViewButtonColumn();
            acceptbtn.Name = "Accept";
            acceptbtn.Text = "Accept";
            acceptbtn.UseColumnTextForButtonValue = false;

            dataGridView1.Columns.Add(acceptbtn);
        }
        public void data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cuti.NIP, namapegawai, namadiv, namajabat, tanggal_mulai, tanggal_selesai, keperluan from employeeinfo,cuti where employeeinfo.nip = cuti.nip";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Refresh();
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ini kalo accept button dipencet
            if(e.ColumnIndex == 7)
            {
                DateTime mulai = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                DateTime akhir = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                int nip = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                TimeSpan ts = (akhir - mulai);
                int waktucuti = ts.Days;
                string status = "disetujui";
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update cuti set status = '"+status+"' where nip = '"+nip+"'"; //masukin ke db status disetujui abis pencet accepbutton
                cmd.Connection = con;
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cuti disetujui");
                    //kalo berhasil, dia akan kurangin jatahcuti, disini yg masih salah
                    MySqlCommand cmd2 = new MySqlCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update pegawai set jatahcuti = (jatahcuti-'" + waktucuti + "') where nip = '"+nip+"'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("asd");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
