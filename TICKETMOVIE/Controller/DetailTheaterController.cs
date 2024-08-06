using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;

namespace TICKETMOVIE.Controller
{
    class DetailTheaterController : BaseController<MovieService, DetailTheater>
    {
        private readonly MovieResData movieResData;

        public DetailTheaterController(MovieService movieService, DetailTheater page)
            : base(movieService, page)
        {
            this.SerVice = movieService;
            this.View = page;
            movieResData = new MovieResData();
        }
        public async Task GetListMovieByTheatersAsync(int idTheater)
        {
            try
            {
                ResData res = await movieResData.GetResData(SerVice.UrlGetMoviesByTheater(idTheater));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {
                        List<Movie> listMovie = new List<Movie>();
                        listMovie = dbHelper.ConvertToClass<List<Movie>>(res.data);

                        if (listMovie.Count == 0)
                        {
                            MessageBox.Show("Danh sách rạp trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {

                            View.Load_ListMovie(listMovie);
                        }

                    }
                    else
                    {
                        MessageBox.Show("GET MOVIE FAILD");
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
