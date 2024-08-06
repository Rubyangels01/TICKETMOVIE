using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;
using TICKETMOVIE.Service;

namespace TICKETMOVIE.Controller
{
    class RevenueController : BaseController<TicketService,RevenuePage>

    {
        private readonly MovieResData movieResData;
       
        public RevenueController(TicketService ticketService, RevenuePage revenuePage)
            : base(ticketService, revenuePage)
        {
            this.SerVice = ticketService;
            this.View = revenuePage;
            movieResData = new MovieResData();
            
        }
        public async Task GetListMovieAsync()
        {
/*
            try
            {
                

                ResData res = await movieResData.GetResData(SerVice.UrlGetListMovie());

                if (res.code == 200)
                {
                    List<Movie> listmovie = new List<Movie>();
                    listmovie = dbHelper.ConvertToClass<List<Movie>>(res.data);
                    View.GetListMovie(listmovie);
                }
                else
                {
                    MessageBox.Show("GET MOVIE FAILD");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }*/
        }
        public async Task GetRevenueAsync(int idMovie, int idTheater)
        {           
            try
            {

                ResData res = await movieResData.GetResDataTicket(SerVice.UrlGetRevenue(idTheater,idMovie));
                if(res == null)
                {
                    MessageBox.Show("Lỗi hệ thống, vui lòng thử lại sau!");
                } 
                else
                {
                    if (res.code == 200)
                    {
                        Revenue revenue1 = new Revenue("0", "0", "0");
                        List<Revenue> revenue = new List<Revenue>();
                        revenue = dbHelper.ConvertToClass<List<Revenue>>(res.data);
                        if (revenue.Count == 0)
                        {

                            View.LoadRevenue(revenue1);
                        }
                        else
                        {
                            View.LoadRevenue(revenue[0]);
                        }

                    }
                    else
                    {
                        MessageBox.Show("GET MOVIE FAILD");
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
