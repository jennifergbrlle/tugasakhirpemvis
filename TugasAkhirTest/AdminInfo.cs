﻿using System;
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
        }
        private void DisplayData()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employeeinfo";
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
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from pegawai where nip = '" + nip + "'";
            cmd.ExecuteNonQuery();
            MySqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from user where username = '" + nip + "'";
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Data berhasil dihapus");
            con.Close();
            DisplayData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
