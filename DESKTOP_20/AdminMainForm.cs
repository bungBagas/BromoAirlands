using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESKTOP_20
{
    public partial class AdminMainForm : Form
    {
        bool buttonclick = true;
        public AdminMainForm()
        {
            InitializeComponent();
            bandaraselect.Visible = false;
            maskapaiselect.Visible = false;
            kodeselect.Visible = false;
            jadwalselect.Visible = false;
            ubahselect.Visible = false;
        }

        Form form1 = null;
        void OpenChildFom(Form childform)
        {
            if(form1 != null)
                form1.Close();

            form1 = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel2.Controls.Add(childform);
            childform.Tag = "Admin";
            childform.BackColor = Color.White;
           // childform.TopLevel = false;
            
            childform.BringToFront();
            childform.Show();
        }


        bool expansidebar = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expansidebar)
            {
                sidebarpanel.Width += 10;
                if(sidebarpanel.Width == sidebarpanel.MaximumSize.Width)
                {
                    expansidebar = false;
                    sidebarlayout.Stop();
                }
            }
            else
            {
                sidebarpanel.Width -= 10;
                if (sidebarpanel.Width == sidebarpanel.MinimumSize.Width)
                {
                    expansidebar = true;
                    sidebarlayout.Stop();
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            sidebarlayout.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterBandaraForm mas = new MasterBandaraForm();
          
            if (buttonclick == true)
            {
                
               bandaraselect.Visible = true;
                maskapaiselect.Visible = false;
                jadwalselect.Visible = false;
                kodeselect.Visible = false;
                ubahselect.Visible = false;
                
            }
            else
            {
                bandaraselect.Visible = false;
            }
            
            OpenChildFom(mas);
        }

        private void maskapaiunselect_Click(object sender, EventArgs e)
        {
            MasterMaskapai mas = new MasterMaskapai();

            if (buttonclick == true)
            {

                bandaraselect.Visible = false;
                maskapaiselect.Visible = true;
                jadwalselect.Visible = false;
                kodeselect.Visible = false;
                ubahselect.Visible = false;
            }

            OpenChildFom(mas);
        }

        private void jadwalunselect_Click(object sender, EventArgs e)
        {
            MasterJadwalPenerbangan mas = new MasterJadwalPenerbangan();

            if (buttonclick == true)
            {

                bandaraselect.Visible = false;
                maskapaiselect.Visible = false;
                jadwalselect.Visible = true;
                kodeselect.Visible = false;
                ubahselect.Visible = false;
            }

            OpenChildFom(mas);
        }

        private void kodeunselect_Click(object sender, EventArgs e)
        {
            MasterKodePromo mas = new MasterKodePromo();

            if (buttonclick == true)
            {

                bandaraselect.Visible = false;
                maskapaiselect.Visible = false;
                jadwalselect.Visible = false;
                kodeselect.Visible = true;
                ubahselect.Visible = false;
            }

            OpenChildFom(mas);
        }

        private void ubahunselect_Click(object sender, EventArgs e)
        {
            Ubah_Status_Penerbangan_ mas = new Ubah_Status_Penerbangan_();

            if (buttonclick == true)
            {

                bandaraselect.Visible = false;
                maskapaiselect.Visible = false;
                jadwalselect.Visible = false;
                kodeselect.Visible = false;
                ubahselect.Visible = true;
            }

            OpenChildFom(mas);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin keluar??","Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }

        private void maskapaiselect_Click(object sender, EventArgs e)
        {

        }

        private void sidebarpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
