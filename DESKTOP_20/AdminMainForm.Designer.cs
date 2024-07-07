namespace DESKTOP_20
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.Button();
            this.sidebarlayout = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidebarpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bandaraselect = new System.Windows.Forms.Button();
            this.maskapaiselect = new System.Windows.Forms.Button();
            this.bandaraunselect = new System.Windows.Forms.Button();
            this.maskapaiunselect = new System.Windows.Forms.Button();
            this.jadwalselect = new System.Windows.Forms.Button();
            this.jadwalunselect = new System.Windows.Forms.Button();
            this.ubahselect = new System.Windows.Forms.Button();
            this.ubahunselect = new System.Windows.Forms.Button();
            this.kodeselect = new System.Windows.Forms.Button();
            this.kodeunselect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sidebarpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(61)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sidebar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dashboard";
            // 
            // sidebar
            // 
            this.sidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sidebar.Image = global::DESKTOP_20.Properties.Resources.menu_alt_72;
            this.sidebar.Location = new System.Drawing.Point(17, 20);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(44, 38);
            this.sidebar.TabIndex = 2;
            this.sidebar.UseVisualStyleBackColor = true;
            this.sidebar.Click += new System.EventHandler(this.sidebar_Click);
            // 
            // sidebarlayout
            // 
            this.sidebarlayout.Interval = 20;
            this.sidebarlayout.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.sidebarpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 528);
            this.panel2.TabIndex = 2;
            // 
            // sidebarpanel
            // 
            this.sidebarpanel.Controls.Add(this.button1);
            this.sidebarpanel.Controls.Add(this.bandaraselect);
            this.sidebarpanel.Controls.Add(this.maskapaiselect);
            this.sidebarpanel.Controls.Add(this.bandaraunselect);
            this.sidebarpanel.Controls.Add(this.maskapaiunselect);
            this.sidebarpanel.Controls.Add(this.jadwalselect);
            this.sidebarpanel.Controls.Add(this.jadwalunselect);
            this.sidebarpanel.Controls.Add(this.ubahselect);
            this.sidebarpanel.Controls.Add(this.ubahunselect);
            this.sidebarpanel.Controls.Add(this.kodeselect);
            this.sidebarpanel.Controls.Add(this.kodeunselect);
            this.sidebarpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarpanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarpanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidebarpanel.MaximumSize = new System.Drawing.Size(220, 542);
            this.sidebarpanel.MinimumSize = new System.Drawing.Size(61, 542);
            this.sidebarpanel.Name = "sidebarpanel";
            this.sidebarpanel.Size = new System.Drawing.Size(220, 542);
            this.sidebarpanel.TabIndex = 12;
            this.sidebarpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarpanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::DESKTOP_20.Properties.Resources.log_out_alt_72;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "       Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bandaraselect
            // 
            this.bandaraselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bandaraselect.Image = global::DESKTOP_20.Properties.Resources.map_selected_72;
            this.bandaraselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bandaraselect.Location = new System.Drawing.Point(2, 6);
            this.bandaraselect.Margin = new System.Windows.Forms.Padding(2);
            this.bandaraselect.Name = "bandaraselect";
            this.bandaraselect.Size = new System.Drawing.Size(213, 55);
            this.bandaraselect.TabIndex = 2;
            this.bandaraselect.Text = "    Master Bandara";
            this.bandaraselect.UseVisualStyleBackColor = true;
            this.bandaraselect.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskapaiselect
            // 
            this.maskapaiselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maskapaiselect.Image = global::DESKTOP_20.Properties.Resources.plane_take_off_solid_72;
            this.maskapaiselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maskapaiselect.Location = new System.Drawing.Point(2, 67);
            this.maskapaiselect.Margin = new System.Windows.Forms.Padding(2);
            this.maskapaiselect.Name = "maskapaiselect";
            this.maskapaiselect.Size = new System.Drawing.Size(213, 55);
            this.maskapaiselect.TabIndex = 3;
            this.maskapaiselect.Text = "    Master Maskapai";
            this.maskapaiselect.UseVisualStyleBackColor = true;
            this.maskapaiselect.Click += new System.EventHandler(this.maskapaiselect_Click);
            // 
            // bandaraunselect
            // 
            this.bandaraunselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bandaraunselect.Image = global::DESKTOP_20.Properties.Resources.map_unselected_72;
            this.bandaraunselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bandaraunselect.Location = new System.Drawing.Point(2, 6);
            this.bandaraunselect.Margin = new System.Windows.Forms.Padding(2);
            this.bandaraunselect.Name = "bandaraunselect";
            this.bandaraunselect.Size = new System.Drawing.Size(213, 55);
            this.bandaraunselect.TabIndex = 7;
            this.bandaraunselect.Text = "    Master Bandara";
            this.bandaraunselect.UseVisualStyleBackColor = true;
            this.bandaraunselect.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskapaiunselect
            // 
            this.maskapaiunselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maskapaiunselect.Image = global::DESKTOP_20.Properties.Resources.plane_take_off_unselected_72;
            this.maskapaiunselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maskapaiunselect.Location = new System.Drawing.Point(2, 67);
            this.maskapaiunselect.Margin = new System.Windows.Forms.Padding(2);
            this.maskapaiunselect.Name = "maskapaiunselect";
            this.maskapaiunselect.Size = new System.Drawing.Size(213, 55);
            this.maskapaiunselect.TabIndex = 8;
            this.maskapaiunselect.Text = "    Master Maskapai";
            this.maskapaiunselect.UseVisualStyleBackColor = true;
            this.maskapaiunselect.Click += new System.EventHandler(this.maskapaiunselect_Click);
            // 
            // jadwalselect
            // 
            this.jadwalselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jadwalselect.Image = global::DESKTOP_20.Properties.Resources.calendar_selected_72;
            this.jadwalselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jadwalselect.Location = new System.Drawing.Point(2, 127);
            this.jadwalselect.Margin = new System.Windows.Forms.Padding(2);
            this.jadwalselect.Name = "jadwalselect";
            this.jadwalselect.Size = new System.Drawing.Size(213, 55);
            this.jadwalselect.TabIndex = 4;
            this.jadwalselect.Text = "               Master Jadwal Penerbangan";
            this.jadwalselect.UseVisualStyleBackColor = true;
            // 
            // jadwalunselect
            // 
            this.jadwalunselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jadwalunselect.Image = global::DESKTOP_20.Properties.Resources.calendar_unselected_72;
            this.jadwalunselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jadwalunselect.Location = new System.Drawing.Point(2, 127);
            this.jadwalunselect.Margin = new System.Windows.Forms.Padding(2);
            this.jadwalunselect.Name = "jadwalunselect";
            this.jadwalunselect.Size = new System.Drawing.Size(213, 55);
            this.jadwalunselect.TabIndex = 9;
            this.jadwalunselect.Text = "               Master Jadwal Penerbangan";
            this.jadwalunselect.UseVisualStyleBackColor = true;
            this.jadwalunselect.Click += new System.EventHandler(this.jadwalunselect_Click);
            // 
            // ubahselect
            // 
            this.ubahselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubahselect.Image = global::DESKTOP_20.Properties.Resources.notepad_selected_72;
            this.ubahselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ubahselect.Location = new System.Drawing.Point(2, 247);
            this.ubahselect.Margin = new System.Windows.Forms.Padding(2);
            this.ubahselect.Name = "ubahselect";
            this.ubahselect.Size = new System.Drawing.Size(213, 55);
            this.ubahselect.TabIndex = 6;
            this.ubahselect.Text = "          Ubah Status Penerbangan";
            this.ubahselect.UseVisualStyleBackColor = true;
            // 
            // ubahunselect
            // 
            this.ubahunselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubahunselect.Image = global::DESKTOP_20.Properties.Resources.notepad_unselected_72;
            this.ubahunselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ubahunselect.Location = new System.Drawing.Point(2, 247);
            this.ubahunselect.Margin = new System.Windows.Forms.Padding(2);
            this.ubahunselect.Name = "ubahunselect";
            this.ubahunselect.Size = new System.Drawing.Size(213, 55);
            this.ubahunselect.TabIndex = 11;
            this.ubahunselect.Text = "          Ubah Status Penerbangan";
            this.ubahunselect.UseVisualStyleBackColor = true;
            this.ubahunselect.Click += new System.EventHandler(this.ubahunselect_Click);
            // 
            // kodeselect
            // 
            this.kodeselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kodeselect.Image = global::DESKTOP_20.Properties.Resources.purchase_tag_alt_selected_72;
            this.kodeselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kodeselect.Location = new System.Drawing.Point(2, 187);
            this.kodeselect.Margin = new System.Windows.Forms.Padding(2);
            this.kodeselect.Name = "kodeselect";
            this.kodeselect.Size = new System.Drawing.Size(213, 55);
            this.kodeselect.TabIndex = 5;
            this.kodeselect.Text = "    Master Kode Promo";
            this.kodeselect.UseVisualStyleBackColor = true;
            // 
            // kodeunselect
            // 
            this.kodeunselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kodeunselect.Image = global::DESKTOP_20.Properties.Resources.purchase_tag_alt_unselected_72;
            this.kodeunselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kodeunselect.Location = new System.Drawing.Point(2, 187);
            this.kodeunselect.Margin = new System.Windows.Forms.Padding(2);
            this.kodeunselect.Name = "kodeunselect";
            this.kodeunselect.Size = new System.Drawing.Size(213, 55);
            this.kodeunselect.TabIndex = 10;
            this.kodeunselect.Text = "    Master Kode Promo";
            this.kodeunselect.UseVisualStyleBackColor = true;
            this.kodeunselect.Click += new System.EventHandler(this.kodeunselect_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sidebarpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sidebar;
        private System.Windows.Forms.Button bandaraselect;
        private System.Windows.Forms.Button maskapaiselect;
        private System.Windows.Forms.Button jadwalselect;
        private System.Windows.Forms.Button kodeselect;
        private System.Windows.Forms.Button ubahselect;
        private System.Windows.Forms.Timer sidebarlayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidebarpanel;
        private System.Windows.Forms.Button bandaraunselect;
        private System.Windows.Forms.Button maskapaiunselect;
        private System.Windows.Forms.Button jadwalunselect;
        private System.Windows.Forms.Button ubahunselect;
        private System.Windows.Forms.Button kodeunselect;
        private System.Windows.Forms.Button button1;
    }
}