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
using TICKETMOVIE.Custom;
using TICKETMOVIE.Model;
using TICKETMOVIE.Service;

namespace TICKETMOVIE
{
    public partial class RevenuePage : Form,View
    {
        Movie movie1 = new Movie();
        RevenueController revenueController;
        public RevenuePage()
        {
            InitializeComponent();
            var ticketService = new TicketService(); // Tạo đối tượng MovieService
            this.revenueController = new RevenueController(ticketService, this);
            


        }
        
        
        public async void LoadRevenuOfMovie()
        {

            await revenueController.GetRevenueAsync(movie1.idMovie,UserSession.idTheater);
        }
        public void LoadRevenue(Revenue revenue)
        {
            if (revenue != null)
            {
                // Định dạng TotalRevenue với dấu phân cách hàng nghìn
                txtdoanso.Text = string.Format("{0:N0} VND", revenue.TotalRevenue);

                // Chuyển đổi TotalTickets và ShowCount sang chuỗi
                txtnumberticket.Text = revenue.TotalTickets.ToString();
                txtshowcasing.Text = revenue.ShowCount.ToString();
            }
            else
            {
                // Nếu revenue là null, có thể hiển thị thông báo hoặc đặt giá trị mặc định
                txtdoanso.Text = "0 VND";
                txtnumberticket.Text = "0";
                txtshowcasing.Text = "0";
            }
        }


        internal void DisplayMovie(Movie movie)
        {
            namemovie.Text = movie.nameMovie;
            time.Text = movie.time.ToString();
            movie1 = movie;
            LoadRevenuOfMovie();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            using (FormDetailMovie form = new FormDetailMovie())
            {
                this.Hide();
                form.DisplayMovie(FormDetailMovie.movie1);
                form.StartPosition = FormStartPosition.CenterScreen;

                form.FormClosed += (s, args) =>
                {
                    // Hiển thị lại form cha
                    this.Show();
                };
                form.ShowDialog(); // Hiển thị form như hộp thoại
            }
        }

        private void icon_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
