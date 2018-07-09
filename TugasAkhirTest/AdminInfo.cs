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
    public partial class AdminInfo : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        public AdminInfo()
        {
            InitializeComponent();
            DisplayData();
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) as jumlah from pegawai where flag = 1";
            cmd.Connection = con;
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label4.Text = dr["jumlah"].ToString();
            }
            con.Close();

        }
        private void DisplayData()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employeeinfo where flag = 1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Refresh();
            con.Close();
        }
        private void AdminInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from employeeinfo where nip like '%" + search_txt.Text + "%'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Refresh();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = dataGridView1.SelectedCells[0].RowIndex;
            int nip = Convert.ToInt32(dataGridView1.Rows[id].Cells[0].Value.ToString());
            int test = dataGridView1.CurrentCell.RowIndex;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update pegawai set flag = 0 where nip = '" + nip + "'";
            cmd.ExecuteNonQuery();
            dataGridView1.Rows.RemoveAt(test);
            MessageBox.Show("Data berhasil dihapus");
            con.Close();
            DisplayData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
