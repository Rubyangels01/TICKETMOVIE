using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace TICKETMOVIE.Model
{
   public class Movie
    {
        public int idMovie { get; set; }
        public String image { get; set; }
        public String nameMovie { get; set; }
        public int time { get; set; }
        public String desciption { get; set; }
        public DateTime releasedDate { get; set; }
        public String language { get; set; }
        public String cast { get; set; }
        public String priceMovie { get; set; }
        public int status { get; set; }
        public string TotalTickets { get; set; }
        public String getNameMovie()
        {
            return nameMovie;
        }

        public static Movie ConvertToMovie(object data)
        {
            if (data != null)
            {
                // Serialize đối tượng data sang JSON string
                string jsonData = JsonConvert.SerializeObject(data);

                // Deserialize JSON string thành đối tượng Movie
                Movie movie = JsonConvert.DeserializeObject<Movie>(jsonData);

                return movie;
            }
            return null;
        }
    }
}
