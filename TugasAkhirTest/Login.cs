using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TugasAkhirTest
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; Database=sistem_pegawai; Uid=root; Pwd=;");
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText="select level,nip from user, pegawai where user.username like pegawai.nip and username='"+username_txt.Text+"' and password='"+password_txt.Text+"'";
            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            //i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                if (dt.Rows[0][0].ToString() == "admin")
                {
                    MenuAdmin mnadmin = new MenuAdmin();
                    mnadmin.Show();
                }
                else
                {
                    MenuKaryawan mnkaryawan = new MenuKaryawan();
                    mnkaryawan.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            con.Close();
            
        }
  
        private void password_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                login_btn_Click(this, new EventArgs());
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            username_txt.Select();
        }
    }
}
