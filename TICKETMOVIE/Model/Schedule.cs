using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETMOVIE.Model
{
   public class Schedule
    {
       
        public string ShowTime  { get; set; }
        public string NameMovie { get; set; }
        public string NameRoom { get; set; }
        public int Time { get; set; }
      
        public Schedule()
        { }
        
    }
}
