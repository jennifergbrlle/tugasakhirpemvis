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
            acceptbtn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(acceptbtn);
        }
        public void data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cuti.NIP, namapegawai, namadiv, namajabat, tanggal_mulai, tanggal_selesai, keperluan from employeeinfo,cuti where employeeinfo.nip = cuti.nip and status is null";
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
                cmd.CommandText = "update cuti set status = '"+status+"' where nip = '"+nip+"'";
                cmd.Connection = con;
                if(cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Cuti disetujui");
                    MySqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update pegawai set JatahCuti = JatahCuti - '"+waktucuti+"' where nip = '"+nip+"'";
                    cmd.Connection = con;
                    MySqlDataReader dr = cmd2.ExecuteReader();
                    int test = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(test);
                }
                con.Close();
            }
        }
    }
}
