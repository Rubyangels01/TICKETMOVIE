using System;
using System.Net.Http;
using System.Text;

namespace TICKETMOVIE
{
    public class MovieService : IMovieService
    {
        

        public MovieService()
        { 
           
        }
        public string UrlGetMovieById(int id)
        {
            return $"movie/{id}";
        }
        public string UrlGetRoomNotScheduleByMovie(int idTheater,int idMovie,String showDate)
        {
            return $"rooms/theater/{idTheater}/movie?idMovie={idMovie}&showDate={showDate}";
        }
        public string UrlGetScheduleHour(int idMovie, string startTime, int numberOfShowtime)
        {
            string url = $"movie/{idMovie}/schedules";
            url += $"?startTime={startTime}&numberOfShowtimes={numberOfShowtime}";

            return url;
        }

        public string UrlGetRoomNotHaveSchedule(int idTheater, string starttime, int duration)
        {
            string url = $"rooms/theater/{idTheater}/movie";
            url += $"?StartTime={starttime}&Duration={duration}";

            return url;
        }

        public (string url, StringContent content) UrlPostDetailMovieTemp(int idmovie, int idroom, string showdate, string listtimeshow)
        {
            string url = "movie/schedule/temp";
            var content = new StringContent(
                $"{{ \"idmovie\": {idmovie}, \"idroom\": {idroom}, \"showdate\": \"{showdate}\", \"listtimeshow\": \"{listtimeshow}\" }}",
                Encoding.UTF8,
                "application/json");
            return (url, content);
        }

        public (string url, StringContent content) UrlPostSchedule(int idmovie, int idroom, string showdate, int idManager)
        {
            string url = "schedule/theater";
            var content = new StringContent(
                $"{{ \"IDMovie\": {idmovie}, \"IDRoom\": {idroom}, \"ShowDate\": \"{showdate}\", \"IDManager\": {idManager} }}",
                Encoding.UTF8,
                "application/json");
            return (url, content);
        }
        public String UrlPostDetailMovie()
        {
            return "movie/schedule";
        }
        public String UrlDeleteTemp()
        {
            return "temp";
        }

        public String UrlDeleteTemp(int id)
        {
            return $"movie/{id}";
        }
        public  String UrlGetListMovie()
        {
            return "listmovie";
        }
        public String UrlGetListMovieUpcoming()
        {
            return "listmovie/upcoming";
        }
       
        public string UrlGetAllScheduleMovie(int idTheater, string showdate)
        {
            string url = $"schedule/theater/{idTheater}";
            url += $"?ShowDate={showdate}";

            return url;
        }
        public string UrlGetScheduleOfMovie(int idTheater, string showdate, int idMovie)
        {
            string url = $"showtime/theater/{idTheater}";
            url += $"?ShowDate={showdate}&IDMovie={idMovie}";

            return url;
        }
        public string UrlGetAllRevenueOfMovie(int idMovie)
        {
            return $"revenue/movie/{idMovie}";
        }

        public string UrlGetTicketByMovieAndShowdate(int idMovie, int idRoom, string showdate)
        {
            string url = $"movie/{idMovie}/room/{idRoom}";
            url += $"?showdate={showdate}";

            return url;
        }
        
        public string UrlGetAllTheater()
        {
            return "theaters";


        }
      
        public string UrlGetMoviesByTheater(int idTheater)
        {
            return $"theater/{idTheater}";


        }






    }
}
