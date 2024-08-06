using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;

namespace TICKETMOVIE.Controller
{
   public class ScheduleOfMovieController : BaseController<MovieService, ScheduleOfMovie>
    {
        private readonly MovieResData movieResData;

        public ScheduleOfMovieController(MovieService movieService, ScheduleOfMovie schedule)
            : base(movieService, schedule)
        {
            this.SerVice = movieService;
            this.View = schedule;
            movieResData = new MovieResData();
        }

        public async Task GetScheduleMovieAsync(int idTheater, string ShowDate, int idMovie)
        {

            try
            {

                ResData res = await movieResData.GetResData(SerVice.UrlGetScheduleOfMovie(idTheater, ShowDate,idMovie));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {

                        List<TimeShow> listschedule = new List<TimeShow>();
                        listschedule = dbHelper.ConvertToClass<List<TimeShow>>(res.data);



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

        public async Task GetTicketByMovieAndShowdateAsync(int idMovie, int idRoom, string showdate)
        {

            try
            {

                ResData res = await movieResData.GetResDataTicket(SerVice.UrlGetTicketByMovieAndShowdate(idMovie,idRoom,showdate));

                if (res == null)
                {
                    MessageBox.Show("Không có vé nào cho suất chiếu này!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {

                        List<Ticket2> listticket = new List<Ticket2>();
                        listticket = dbHelper.ConvertToClass<List<Ticket2>>(res.data);


                        if (listticket.Count == 0)
                        {
                            
                            MessageBox.Show("Danh sách vé trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            View.DisplayTicket(listticket);

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
