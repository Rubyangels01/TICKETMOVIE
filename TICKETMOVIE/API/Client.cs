using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace TICKETMOVIE
{
    public class Client
    {
         private string PORT = "172.20.10.3";
         protected String urluser { get; set; }
         protected String urlmovie { get; set; }
         protected String urlticket { get; set; }

       public Client()
        {
            this.urluser = "http://"+ PORT +":3000/api/users/";
            this.urlmovie = "http://" + PORT + ":3002/movies/";
            this.urlticket = "http://" + PORT + ":3004/tickets/";
        }
    }
}
