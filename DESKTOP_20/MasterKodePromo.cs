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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DESKTOP_20
{
    public partial class MasterKodePromo : Form
    {
        int id;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Utils.conn);
        SqlDataReader rd;
        public MasterKodePromo()
        {
            InitializeComponent();
            loadgrid();

        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            
            numericUpDown1.Value = 1;
            numericUpDown1.Value = 1;
           
        }

        bool val()
        {
            if (textBox1.TextLength < 1 || textBox2.TextLength < 1 )
            {
                MessageBox.Show("Isi semua kolom!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Jumlah terminal yang diisi mininimal 1!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cmd = new SqlCommand("select * from Bandara where Nama = '" + textBox1.Text + "' or KodeIATA = '" + textBox2.Text + "'", con);
                con.Open();
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    MessageBox.Show("Nama / kode telah dipakai!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return false;

                }
                con.Close();
                return true;
            }

        }

        void loadgrid()
        {
            string com = "SELECT TOP (1000) [ID]\r\n      ,[Kode]\r\n      ,[PersentaseDiskon]\r\n      ,[MaksimumDiskon]\r\n      ,[BerlakuSampai]\r\n      ,[Deskripsi]\r\n  FROM [BromoAirlines].[dbo].[KodePromo]";
            dataGridView1.DataSource = Command.getdata(com);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string com = "INSERT INTO [dbo].[KodePromo]\r\n           ([Kode]\r\n           ,[PersentaseDiskon]\r\n           ,[MaksimumDiskon]\r\n           ,[BerlakuSampai]\r\n           ,[Deskripsi])\r\n     VALUES('" + textBox1.Text + "','" + dateTimePicker1.Value + "','" + numericUpDown1.Value + "','" + numericUpDown2.Value + "','"+textBox2.Text+"')";
            string mode = "insert";
            string s = "insert";
            CRUD.crud(com, mode, s);
            
        }

        //void loadcombo()
        //{
        //    string com = "select * from Negara";

        //    comboBox1.DataSource = Command.getdata(com);
        //    comboBox1.ValueMember = "ID";
        //    comboBox1.DisplayMember = "Nama";
        //}
    }
}
