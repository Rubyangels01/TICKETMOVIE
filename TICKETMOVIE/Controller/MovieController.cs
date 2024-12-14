
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;

namespace TICKETMOVIE
{
   
    public class MovieController : BaseController<MovieService, MoviePage>
    {
        public static int idMovie = 0;
        private readonly MovieResData movieResData;

        public MovieController(MovieService movieService, MoviePage moviePage)
            : base(movieService, moviePage)
        {
            this.SerVice = movieService;
            this.View = moviePage;
            movieResData = new MovieResData();
        }
        
        public async Task GetMovieByIdAsync(int id)
        {
            Movie movie = null;
            try
            {
                
                ResData res = await movieResData.GetResData(SerVice.UrlGetMovieById(id));
                
                if (res.code == 200)
                {
                    
                    movie = Movie.ConvertToMovie(res.data);
                    idMovie = movie.idMovie;
                    View.DisplayDetailMovie(movie);
                    //View.DisplayView(movie);
                }
                else
                {
                    MessageBox.Show("GET MOVIE FAILD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task GetRoomNotScheduleByMovieAsync(int idTheater, string Starttime, int duration)
        {
            List<Rooms> listroom = new List<Rooms>();
            try
            {

                ResData res = await movieResData.GetResData(SerVice.UrlGetRoomNotHaveSchedule(idTheater,Starttime,duration));
                if (res.code == 200)
                {

                    listroom = dbHelper.ConvertToClass<List<Rooms>>(res.data);
                    View.LoadRoomNotHaveShedule(listroom);
                    //View.DisplayDetailMovie(movie);
                    //View.DisplayView(movie);
                }
                else
                {
                    MessageBox.Show("GET ROOM FAILD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task GetHourSheduleOfMovieAsync(string startTime, int idMovie, int numberOfShowtime)
        {
            
            try
            {
                ResData res = await movieResData.GetResData(SerVice.UrlGetScheduleHour(idMovie,startTime,numberOfShowtime));

                
                
                if (res.code == 200)
                {
                    String[] hour = new String[numberOfShowtime];
                    hour = dbHelper.ConvertToClass<String[]>(res.data);
                    //View.GetHourOfMovie(hour);
                    
                }
                else
                {
                    MessageBox.Show("GET HOUR FAILD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task SaveScheduleOfMovieINTEMPAsync(int idmovie, int idroom, String showdate, String listtimeshow)
        {
            try
            {
                

                // Gọi API để lưu lịch chiếu
                (string url, StringContent content) = SerVice.UrlPostDetailMovieTemp(idmovie, idroom, showdate, listtimeshow);
                ResData res = await movieResData.GetResDataWithBody(url, content);

                // Xử lý kết quả trả về từ API
                if (res.code == 201)
                {
                    MessageBox.Show("Tạo lịch chiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show(res.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task CreateDetailMovie(int idMovie, int idRoom, int manager, string showdate)
        {
            try
            {
                // Gọi phương thức để tạo lịch chiếu
                var (url, content) = SerVice.UrlPostSchedule(idMovie, idRoom, showdate, manager);
                ResData res = await movieResData.GetResDataWithBody(url, content);

                // Kiểm tra mã trạng thái trả về
                if (res != null && (res.code == 201 || res.code == 200))
                {
                    MessageBox.Show("Thêm lịch chiếu phim thành công!", "Thông báo", MessageBoxButtons.OK);
                    View.DeleteFill();
                   
                }
                else
                {
                    MessageBox.Show(res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task DeleteTemp()
        {
            try
            {

                ResData res = await movieResData.DeleteResData(SerVice.UrlDeleteTemp());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
    

}
