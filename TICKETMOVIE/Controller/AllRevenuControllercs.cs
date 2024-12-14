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
    class AllRevenuControllercs : BaseController<TicketService, ListReveneuForm>
    {
        private readonly MovieResData movieResData;

        public AllRevenuControllercs(TicketService ticketService, ListReveneuForm reveneuForm)
            : base(ticketService, reveneuForm)
        {
            this.SerVice = ticketService;
            this.View = reveneuForm;
            movieResData = new MovieResData();
        }

        public async Task GetAllRevenueAsync(int idTheater)
        {

            try
            {

                ResData res = await movieResData.GetResDataTicket(SerVice.UrlGetAllRevenue(idTheater));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {

                        List<Revenue> listrevenue = new List<Revenue>();
                        listrevenue = dbHelper.ConvertToClass<List<Revenue>>(res.data);



                        if (listrevenue.Count == 0)
                        {
                            View.ClearData();
                            MessageBox.Show("Danh sách doanh thu trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            View.LoadData(listrevenue);

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
        public async Task GetAllRevenueByShowdateAsync(int idTheater, string showdate)
        {

            try
            {

                ResData res = await movieResData.GetResDataTicket(SerVice.UrlGetAllRevenueByDate(idTheater, showdate));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {

                        List<Revenue> listrevenue = new List<Revenue>();
                        listrevenue = dbHelper.ConvertToClass<List<Revenue>>(res.data);



                        if (listrevenue.Count == 0)
                        {
                            View.ClearData();
                            MessageBox.Show("Danh sách doanh thu trống", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            
                            View.LoadData(listrevenue);

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
