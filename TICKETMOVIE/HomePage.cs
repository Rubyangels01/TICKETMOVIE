using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TICKETMOVIE.Model;

namespace TICKETMOVIE
{
    public partial class HomePage : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Maximized;// Đặt trạng thái của form thành toàn màn hình
            ShowFormInPanel(new ListMoviePage());                                             // Loại bỏ đường viền của form nếu cần thiết
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ListMoviePage());
        }

        public void ShowFormInPanel(Form formToShow)
        {
            panel_main.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panel_main.Tag = formToShow;
            panel_main.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void control_showtime_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ScheduleForm());
        }

        private void accorRevenue_Click(object sender, EventArgs e)
        {
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Bạn có thể thêm mã khởi tạo nếu cần
        }

        private void control_account_Click(object sender, EventArgs e)
        {
            UserSession.idUser = 0;
            using (Logincs form = new Logincs())
            {
                this.Hide();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.WindowState = FormWindowState.Maximized;
                form.ShowDialog(); // Hiển thị form như hộp thoại
                this.Close();
            }
        }

        private void control_ticket_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new RoomShow());

        }

        private void controlroom_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ListReveneuForm());
        }
    }
}
