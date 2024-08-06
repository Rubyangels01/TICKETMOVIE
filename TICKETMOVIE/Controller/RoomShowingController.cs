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
    class RoomShowingController : BaseController<TicketService, RoomShow>
    {
        private readonly MovieResData movieResData;

        public RoomShowingController(TicketService ticketService, RoomShow roomshow)
            : base(ticketService, roomshow)
        {
            this.SerVice = ticketService;
            this.View = roomshow;
            movieResData = new MovieResData();
        }
        public async Task GetAllRoomShowingAsync(int idTheater)
        {

            try
            {

                ResData res = await movieResData.GetResDataTicket(SerVice.UrlGetAllRoomCurrentShowing(idTheater));

                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 200)
                    {

                        List<Rooms> listroom = new List<Rooms>();
                        listroom = dbHelper.ConvertToClass<List<Rooms>>(res.data);



                        if (listroom.Count == 0)
                        {
                            View.ClearData();
                            MessageBox.Show("Hiện không có phòng nào được chiếu", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            View.LoadData(listroom);

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
