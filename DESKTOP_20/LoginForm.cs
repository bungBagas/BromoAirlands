using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP_20
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(Utils.conn);
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from akun where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if(reader.HasRows)
            {
                new AdminMainForm().Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Cek kembali username dan password!!","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
