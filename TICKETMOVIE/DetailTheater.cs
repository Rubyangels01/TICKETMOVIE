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
using TICKETMOVIE.Custom.Admin;
using TICKETMOVIE.Model;

namespace TICKETMOVIE
{
    public partial class DetailTheater : Form,View
    {
        private readonly DetailTheaterController detailtheaterController;
        public DetailTheater()
        {
           
            InitializeComponent();
            var movieService = new MovieService();
            detailtheaterController = new DetailTheaterController(movieService, this);        
        }
        public void DisplayInfor(Theaters theaters)
        {
            tvnameMovie.Text = theaters.nameTheater;
            tvAddress.Text = theaters.address;
        }
        public async void GetListMovie(int idTheater)
        {
            await detailtheaterController.GetListMovieByTheatersAsync(idTheater);
        }

        public void Load_ListMovie(List<Movie> listMovie)
        {
            flowpanelmovie.Controls.Clear();
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
                flowpanelmovie.Controls.Add(movieCustom);
            }
        }
    }
}
