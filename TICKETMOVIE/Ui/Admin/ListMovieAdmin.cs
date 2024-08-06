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

namespace TICKETMOVIE.Ui.Admin
{
    public partial class ListMovieAdmin : Form,View
    {
        private readonly ListMovieAdminController listmovieController;
        public ListMovieAdmin()
        {
            InitializeComponent();
            var movieService = new MovieService();
            listmovieController = new ListMovieAdminController(movieService, this);
             GetListMovie();
        }
        private async void GetListMovie()
        {
            await listmovieController.GetListMovieAsync();
        }

        public void Load_ListMovie(List<Movie> listMovie)
        {
            flowpanellistmovie.Controls.Clear();
            foreach (var movie in listMovie)
            {
                var movieCustom = new MovieCustomAdmin
                {
                    Path = movie.image,
                    Name = movie.nameMovie,
                    Released = movie.releasedDate.ToString("dd-MM-yyyy"),
                    IdMovie = movie.idMovie,
                    movie1 = movie
                };
                movieCustom.UpdateUI();

                flowpanellistmovie.Controls.Add(movieCustom);
            }
        }
    }
}
