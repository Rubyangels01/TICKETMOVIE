using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Controller;
using TICKETMOVIE.Service;
using TICKETMOVIE.Ui.Admin;

namespace TICKETMOVIE
{
    public partial class Logincs : Form, View
    {
        private readonly LoginController loginController;

        public Logincs()
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            var userService = new UserService(); // Tạo đối tượng UserService
            this.loginController = new LoginController(userService, this);
            InitializeComponent();
        }

        private async void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Email hoặc Password trống!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                await loginController.LoginAsync(txtemail.Text, txtpassword.Text);
            }
        }

        public void IntentHome()
        {
            using (HomePage form = new HomePage())
            {
                this.Hide();
                form.ShowDialog();
                form.FormClosed += (s, args) => this.Close();
                // Hiển thị form như hộp thoại
            }
              // Đóng form Login sau khi HomePage đóng
        }

        public void IntentHomeAdmin()
        {
            HomeAdmin home = new HomeAdmin();
            this.Hide();  // Ẩn form Login
            home.Show();  // Hiển thị form HomeAdmin
            home.FormClosed += (s, args) => this.Close();  // Đóng form Login sau khi HomeAdmin đóng
        }
        public async void getTheater(string email)
        {
            await loginController.GetTheaterAsync(email);
        }
    }
}
