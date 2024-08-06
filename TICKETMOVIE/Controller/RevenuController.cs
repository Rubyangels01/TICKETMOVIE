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
    public class RevenuController : BaseController<MovieService, RevenueMovieAllTheater>
    {
        private readonly MovieResData movieResData;

        public RevenuController(MovieService movieService, RevenueMovieAllTheater page)
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


        public async Task GetRevenueAllMovieAsync(int idMovie)
        {

            try
            {

                ResData res = await movieResData.GetResDataTicket(SerVice.UrlGetAllRevenueOfMovie(idMovie));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {
                        List<Revenue> listrevenue = new List<Revenue>();
                        listrevenue = dbHelper.ConvertToClass<List<Revenue>>(res.data);

                        if (listrevenue == null)
                        {
                            MessageBox.Show("Danh sách phim trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            
                            View.LoadData(listrevenue);
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
