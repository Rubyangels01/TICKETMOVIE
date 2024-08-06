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

namespace TICKETMOVIE.Ui.Admin
{
    public partial class TheaterForm : Form,View
    {
        private readonly TheaterController theaterController;
        public TheaterForm()
        {
            InitializeComponent();
            var movieService = new MovieService();
            theaterController = new TheaterController(movieService, this);
            GetListTheater();
        }
        

        private async void GetListTheater()
        {
            await theaterController.GetListTheatersAsync();
        }

        public void Load_ListMovie(List<Theaters> listTheater)
        {
            flowpaneltheater.Controls.Clear();
            foreach (var theater in listTheater)
            {
                var theaterCustom = new TheaterCustom
                {
                    nametheater = theater.nameTheater,
                    address = theater.address,
                    idTheater = theater.idTheater

                };
                theaterCustom.DisplayUI();
                flowpaneltheater.Controls.Add(theaterCustom);
            }
        }
    }
}
