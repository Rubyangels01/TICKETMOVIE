using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Controller;
using TICKETMOVIE.Custom.Admin;
using TICKETMOVIE.Model;

namespace TICKETMOVIE.Ui.Admin
{
    public partial class RevenueMovieAllTheater : Form, View
    {
        private readonly RevenuController _revenueController;

        public RevenueMovieAllTheater()
        {
            InitializeComponent();
            var movieService = new MovieService();
            _revenueController = new RevenuController(movieService, this);
            SetData();
            GetListMovie();
        }

        private void SetData()
        {
            var status = new Dictionary<int, string>
            {
                { 1, "Đang chiếu" },
                { 2, "Đã chiếu" }
            };

            cb_status.DataSource = new BindingList<KeyValuePair<int, string>>(status.ToList());
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private async void GetListMovie()
        {
            await _revenueController.GetListMovieAsync();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.SelectedItem is KeyValuePair<int, string> selectedItem)
            {
                int selectedKey = selectedItem.Key;
                if (selectedKey == 1)
                {
                    GetListMovie();
                }
                else
                {
                    //GetListMovieUpcoming();
                }
            }
        }

        public void Load_ListMovie(List<Movie> listMovie)
        {
            flowpanel_main.Controls.Clear();
            foreach (var movie in listMovie)
            {
                var movieCustom = new MovieCustomAdmin
                {
                    Path = movie.image,
                    Name = movie.nameMovie,
                    Released = movie.releasedDate.ToString("dd-MM-yyyy"),
                    IdMovie = movie.idMovie
                };
                movieCustom.UpdateUI();
                flowpanel_main.Controls.Add(movieCustom);
            }
        }

        public void LoadData(List<Revenue> listRevenue)
        {
            dgvRevenue.Columns.Clear();
            dgvRevenue.DataSource = listRevenue;
            dgvRevenue.Columns["NameMovie"].HeaderText = "NAME MOVIE";
            dgvRevenue.Columns["ShowCount"].HeaderText = "SHOW COUNT";
            dgvRevenue.Columns["TotalRevenue"].HeaderText = "TOTAL REVENUE";
            dgvRevenue.Columns["TotalTickets"].HeaderText = "TOTAL TICKETS";
        }

        public async void DisplayRevenue(int idMovie)
        {
            await _revenueController.GetRevenueAllMovieAsync(idMovie);
        }
    }
}
