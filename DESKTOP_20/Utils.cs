using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP_20
{
     class Utils
    {
        public static string conn = "Data Source=LAPTOP-KUCJLI3S\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=BromoAirlands";


        public static bool isnumber(string s)
        {
            if (s.All(char.IsNumber))
            {
                return true;
            }
            return false;
        }
    }


    class CRUD
    {
        public static void crud(String com, String mode, [Optional ] String pesan)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(Utils.conn);
            try
            {
                con.Open();
                switch (mode)
                {
                    case "insert":
                        cmd = new SqlCommand(com, con);
                        cmd.ExecuteNonQuery();
                        switch (pesan)
                        {
                            case "insert":

                        MessageBox.Show("Data berhasil disimpan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                break;
                            case "update":
                                MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;

                        }
                        break;
                    case "delete":
                        DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            cmd = new SqlCommand(com, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        break;


                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }finally
            { con.Close(); }
            

            
        }
    }

    class Command
    {
        public static DataTable getdata(string com)
        {
            SqlConnection con = new SqlConnection(Utils.conn);
            SqlDataAdapter da = new SqlDataAdapter(com,con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void exec(string com)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(Utils.conn);
            cmd = new SqlCommand(com, con);
            con.Open();
            cmd.ExecuteNonQuery();
           con.Close();
        }

    }

    class Encrypt
    {

    }
}
