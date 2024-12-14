using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETMOVIE.Model
{
    public class Promotion
    {
        public String namePromotion { get; set; }
        public int percentSell { get; set; }
        public String totalBill { get; set; }
        public String description { get; set; }
        public String startDate { get; set; }
        public String endDate { get; set; }
        public Promotion(String namePromotion, int percentSell, String totalBill, String description, String startDate, String endDate)
        {
            this.namePromotion = namePromotion;
            this.percentSell = percentSell;
            this.totalBill = totalBill;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
        }
    }
}
