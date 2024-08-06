using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;

namespace TICKETMOVIE.Controller
{
    class AllScheduleController : BaseController<MovieService, ScheduleForm>
    {
        private readonly MovieResData movieResData;

        public AllScheduleController(MovieService movieService, ScheduleForm schedule)
            : base(movieService, schedule)
        {
            this.SerVice = movieService;
            this.View = schedule;
            movieResData = new MovieResData();
        }

        public async Task GetAllScheduleMovieAsync(int idTheater, string ShowDate)
        {

            try
            {
                
                ResData res = await movieResData.GetResData(SerVice.UrlGetAllScheduleMovie(idTheater, ShowDate));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {
                       
                        List<Schedule> listschedule = new List<Schedule>();
                        listschedule = dbHelper.ConvertToClass<List<Schedule>>(res.data);
                       
                       
                        
                        if (listschedule.Count == 0)
                        {
                            View.ClearData();
                            MessageBox.Show("Danh sách lịch trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            View.LoadData(listschedule);

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
