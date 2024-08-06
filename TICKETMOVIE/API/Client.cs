using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TICKETMOVIE
{
    public class Client
    {
         
         protected String urluser { get; set; }
         protected String urlmovie { get; set; }
         protected String urlticket { get; set; }

       public Client()
        {
            this.urluser = "http://192.168.1.8:3000/api/users/";
            this.urlmovie = "http://192.168.1.8:3002/movies/";
            this.urlticket = "http://192.168.1.8:3004/tickets/";
        }





    }
}
