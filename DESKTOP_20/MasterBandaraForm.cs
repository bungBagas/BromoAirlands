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
    public partial class MasterBandaraForm : Form
    {
        int id;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Utils.conn);
        SqlDataReader rd;
        public MasterBandaraForm()
        {
            InitializeComponent();
            loadgrid();
            loadcombo();
           
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ValueMember = null;
            numericUpDown1.Value = 1;
        }

        bool val()
        {
            if (textBox1.TextLength < 1 || textBox2.TextLength < 1 || textBox4.TextLength < 1 || textBox3.TextLength < 1)
            {
                MessageBox.Show("Isi semua kolom!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (numericUpDown1.Value <1)
            {
                MessageBox.Show("Jumlah terminal yang diisi mininimal 1!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cmd = new SqlCommand("select * from Bandara where Nama = '" + textBox1.Text + "' or KodeIATA = '"+textBox2.Text+"'", con);
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

        bool valup()
        {
            if (textBox1.TextLength < 1 || textBox2.TextLength < 1 || textBox4.TextLength < 1 || textBox3.TextLength < 1)
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
            string com = "SELECT dbo.Bandara.ID, dbo.Bandara.Nama, dbo.Bandara.KodeIATA, dbo.Bandara.Kota, dbo.Negara.Nama AS Negara, dbo.Bandara.JumlahTerminal, dbo.Bandara.Alamat, dbo.Bandara.NegaraID\r\nFROM     dbo.Bandara INNER JOIN\r\n                  dbo.Negara ON dbo.Bandara.NegaraID = dbo.Negara.ID order by Bandara.Nama";
            dataGridView1.DataSource = Command.getdata(com);
        }

        void loadcombo()
        {
            string com = "select * from Negara";

            comboBox1.DataSource = Command.getdata(com);
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Nama";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (val())
            {
                string com = "Insert into Bandara values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.SelectedValue + "','" + numericUpDown1.Value + "','" + textBox4.Text + "')";
                string mode = "insert";
                string pesan = "insert";

                CRUD.crud(com, mode, pesan);
                clear();
                loadgrid();


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Selected == true)
            {
                string com = "update Bandara set Nama = '"+textBox1.Text+ "',KodeIATA = '" + textBox2.Text+ "',Kota = '" + textBox3.Text+"',NegaraID = '"+comboBox1.SelectedValue+"',JumlahTerminal = '"+numericUpDown1.Value+"',Alamat = '"+textBox4.Text+ "' where ID = '" + id + "'";
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
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            numericUpDown1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                string com = "delete Bandara where ID = '" + id + "'";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void MasterBandaraForm_Load(object sender, EventArgs e)
        {

        }
    }
}
