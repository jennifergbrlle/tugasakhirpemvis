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
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employeeinfo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AdminInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
