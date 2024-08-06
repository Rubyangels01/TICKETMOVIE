using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Controller;
using TICKETMOVIE.Custom;
using TICKETMOVIE.Model;
using TICKETMOVIE.Service;

namespace TICKETMOVIE
{
    public partial class RoomShow : Form,View
    {
        private readonly RoomShowingController roomshowingcontroller;
        public RoomShow()
        {
            InitializeComponent();
            var ticketService = new TicketService(); // Tạo đối tượng MovieService
            this.roomshowingcontroller = new RoomShowingController(ticketService, this);
            DisplayRoom();

            searchControl1.TextChanged += searchControl1_Click;
        }
        /*
        public void DisplayListRoom()
        {
            for(int i = 0; i < 10; i++)
            {
                RoomCustom roomCustom = new RoomCustom();
                flowpanelroomlist.Controls.Add(roomCustom);
            }    
           
        }*/

        private List<RoomCustom> movieControls = new List<RoomCustom>();

        

        public void LoadData(List<Rooms> listrooms)
        {
            movieControls = listrooms.Select(room => new RoomCustom
            {
                nameRoom = room.NameRoom,
                numberchair = room.numberChair,
                nameMovie = room.NameMovie,
                showDate = room.ShowDate,
                endTime = room.EndTime,
                numberticket = room.TicketsSold
            }).ToList();
            foreach (var control in movieControls)
            {
                control.UpdateUI();
                flowpanelroomlist.Controls.Add(control);
            }
        }


        internal void ClearData()
        {
            flowpanelroomlist.Controls.Clear();
        }
        public async void DisplayRoom()
        {
            await roomshowingcontroller.GetAllRoomShowingAsync(UserSession.idTheater);
        }

        private void searchControl1_Click(object sender, EventArgs e)
        {
            string searchText = searchControl1.Text.ToLower();
            flowpanelroomlist.Controls.Clear();

            var filteredControls = movieControls
                .Where(mc => mc.nameRoom.ToLower().Contains(searchText))
                .ToList();

            foreach (var control in filteredControls)
            {
                flowpanelroomlist.Controls.Add(control);
            }
        }
    }
}
