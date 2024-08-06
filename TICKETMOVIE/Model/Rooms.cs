using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETMOVIE.Model
{
    public class Rooms
    {
       public int IDRoom { get; set; }
       public string NameRoom { get; set; }
       public int IDTheater { get; set; }
        public int numberChair { get; set; }
        public int idMovie { get; set; }
        public string NameMovie { get; set; }
        public string ShowDate { get; set; }
        public string EndTime { get; set; }
        public int TicketsSold { get; set; }


    }
}
