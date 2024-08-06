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
    class TheaterController : BaseController<MovieService, TheaterForm>
    {
        private readonly MovieResData movieResData;

        public TheaterController(MovieService movieService, TheaterForm page)
            : base(movieService, page)
        {
            this.SerVice = movieService;
            this.View = page;
            movieResData = new MovieResData();
        }

        public async Task GetListTheatersAsync()
        {

            try
            {

                ResData res = await movieResData.GetResData(SerVice.UrlGetAllTheater());

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {
                        List<Theaters> listtheater = new List<Theaters>();
                        listtheater = dbHelper.ConvertToClass<List<Theaters>>(res.data);

                        if (listtheater.Count == 0)
                        {
                            MessageBox.Show("Danh sách rạp trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {

                            View.Load_ListMovie(listtheater);
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
