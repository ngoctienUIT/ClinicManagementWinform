using System;
using System.Windows.Forms;
using ClinicManagement.View;

namespace ClinicManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(NhoTaiKhoan);
            pictureBox1.Controls.Add(QuenMatKhau);
            pictureBox1.Controls.Add(button_DangNhap);

        }

        private void QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DatLaiMatKhau datLaiMatKhau = new DatLaiMatKhau();
            this.Visible = false;
            datLaiMatKhau.ShowDialog();
            this.Close();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Visible = false;
            home.ShowDialog();
            this.Close();
        }
    }
}
