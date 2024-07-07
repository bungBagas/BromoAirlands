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
    public partial class DaftarAkun : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(Utils.conn);
        SqlDataReader rd;

        public DaftarAkun()
        {
            InitializeComponent();
        }

        void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        bool val()
        {
            if (textBox1.TextLength < 1 || textBox2.TextLength < 1 || dateTimePicker1.Value ==DateTime.Now || textBox4.TextLength < 1 || textBox5.TextLength < 1)
            {
                MessageBox.Show("Isi semua kolom!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Utils.isnumber(textBox4.Text))
            {
                MessageBox.Show("Harus berisi angka !!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox4.TextLength <10 || textBox4.TextLength > 15)
            {
                MessageBox.Show("Harus berjumlah 10-15 digit!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(textBox5.TextLength < 8)
            {
                MessageBox.Show("Minimal  8 character!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(dateTimePicker1.Value == DateTime.Now)
            {
                MessageBox.Show("Masukan dengan benar", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                cmd = new SqlCommand("select * from Akun where Username = '" + textBox1.Text + "'", con);
                con.Open();
                rd = cmd.ExecuteReader();
                rd.Read();
                if(rd.HasRows)
                {
                    MessageBox.Show("Username telah dipakai!!", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return false;
                   
                }
                con.Close();
                return true;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string admin = "True";
            if (val())
            {
                //string com = "insert into Akun(Username,Nama,TanggalLahir,NomorTelepon,Password,MerupakanAdmin) values('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value+ "','" + textBox4.Text + "','" + textBox5.Text + "','"+admin+"')";
                //string mode = "insert";
                //string pesan = "insert";
                //CRUD.crud(com, mode, pesan);
                
                cmd = new SqlCommand("insert into Akun(Username,Nama,TanggalLahir,NomorTelepon,Password,MerupakanAdmin) values('" + textBox1.Text + "','" + textBox2.Text + "',@date,'" + textBox4.Text + "','" + textBox5.Text + "','" + admin + "')", con);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Customer().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }finally { con.Close(); }
               
                

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar?","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void DaftarAkun_Load(object sender, EventArgs e)
        {

        }
    }
}
