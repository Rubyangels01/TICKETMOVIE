using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETMOVIE.Model
{
    public class Revenue
    {
        public string NameMovie { get; set; }
        public string ShowCount { get; set; }
        public string TotalRevenue { get; set; }
        public string TotalTickets { get; set; }
       public Revenue(string showcount, string totalrevenue,string totalticket)
        {
            this.ShowCount = showcount;
            this.TotalRevenue = totalrevenue;
            this.TotalTickets = totalticket;
        }
    }
}
