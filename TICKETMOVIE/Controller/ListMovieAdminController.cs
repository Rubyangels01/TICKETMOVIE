using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;
using TICKETMOVIE.Ui.Admin;

namespace TICKETMOVIE.Controller
{
    public class ListMovieAdminController : BaseController<MovieService, ListMovieAdmin>
    {
        private readonly MovieResData movieResData;

        public ListMovieAdminController(MovieService movieService, ListMovieAdmin page)
            : base(movieService, page)
        {
            this.SerVice = movieService;
            this.View = page;
            movieResData = new MovieResData();
        }

        public async Task GetListMovieAsync()
        {

            try
            {

                ResData res = await movieResData.GetResData(SerVice.UrlGetListMovie());

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {
                        List<Movie> listmovie = new List<Movie>();
                        listmovie = dbHelper.ConvertToClass<List<Movie>>(res.data);

                        if (listmovie == null)
                        {
                            MessageBox.Show("Danh sách phim trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {

                            View.Load_ListMovie(listmovie);
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
