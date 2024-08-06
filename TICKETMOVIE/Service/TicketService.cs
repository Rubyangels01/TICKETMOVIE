using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETMOVIE.Service
{
    public class TicketService : IMovieService
    {
        public TicketService()
        {

        }
        public String UrlGetNumberTicketAndRevenue(int idMovie)
        {
            return $"ticket/{idMovie}";
        }
        public string UrlGetRevenue(int idTheater, int idMovie)
        {
            return $"revenue/movie/{idMovie}/theater/{idTheater}";
        }
        public string UrlGetAllRevenue(int idTheater)
        {
            return $"revenue/theater/{idTheater}";
        }

        public string UrlGetAllRevenueByDate(int idTheater, string showdate)
        {
            string url = $"revenue/theater/{idTheater}/showdate";
            url += $"?ShowDate={showdate}";
            return url;
        }

        public string UrlGetAllRoomCurrentShowing(int idTheater)
        {
            return $"room/showing/theater/{idTheater}";
        }
        



    }
}
