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
    public partial class MasterMaskapai : Form
    {
        int id;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Utils.conn);
        SqlDataReader rd;
        public MasterMaskapai()
        {
            InitializeComponent();
            loadgrid();
            
        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
          
            numericUpDown1.Value = 0;
        }

        bool val()
        {
            if (textBox1.TextLength < 1 || textBox2.TextLength < 1 ||  textBox3.TextLength < 1|| numericUpDown1.Value <1)
            {
                MessageBox.Show("Isi semua kolom!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Jumlah kru yang diisi mininimal 1!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cmd = new SqlCommand("select * from Maskapai where Nama = '" + textBox1.Text + "' ", con);
                con.Open();
                rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    MessageBox.Show("Nama telah dipakai!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return false;

                }
                con.Close();
                return true;
            }

        }

        void loadgrid()
        {
            string com = "SELECT  * from Maskapai order by Nama asc";
            dataGridView1.DataSource = Command.getdata(com);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (val())
            {
                string com = "Insert into Maskapai values('" + textBox1.Text + "','" + textBox2.Text + "','" + numericUpDown1.Value + "',,'" + textBox3.Text + "')";
                string mode = "insert";
                string pesan = "insert";

                CRUD.crud(com, mode, pesan);
                clear();
                loadgrid();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                string com = "update Maskapai set Nama = '" + textBox1.Text + "',Perusahaan = '" + textBox2.Text + "',JumlahKru = '" + numericUpDown1.Value + "',Deskripsi = '" + textBox3.Text + " where ID = '" + id + "'";
                string mode = "insert";
                string pesan = "update";

                CRUD.crud(com, mode, pesan);
                clear();
                loadgrid();
            }
            else
            {
                MessageBox.Show("Pilih data dahulu", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                string com = "delete Maskapai where ID = '" + id + "'";
                string mode = "delete";
                CRUD.crud(com, mode);
                clear();
                loadgrid();
            }
            else
            {
                MessageBox.Show("Pilih data dahulu", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
    
}
