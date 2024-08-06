using DevExpress.XtraScheduler;
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
using TICKETMOVIE.Model;

namespace TICKETMOVIE
{
    public partial class ScheduleForm : Form, View
    {
        private readonly AllScheduleController schedulecontroller;
        public ScheduleForm()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            var movieService = new MovieService(); // Tạo đối tượng MovieService
            this.schedulecontroller = new AllScheduleController(movieService, this);
            DisplaySchedule(UserSession.idTheater, DateTime.Today.ToString("yyyy-MM-dd"));
        }
        public async void DisplaySchedule(int idTheater, string showdate)
        {
            await schedulecontroller.GetAllScheduleMovieAsync(idTheater, showdate);
        }
        
        public void LoadData(List<Schedule> listschedule)
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.DataSource = listschedule;
            dgvSchedule.Columns["Showtime"].HeaderText = "SHOW TIME";
            dgvSchedule.Columns["NameMovie"].HeaderText = "NAME MOVIE";
            dgvSchedule.Columns["NameRoom"].HeaderText = "NAME ROOM";
            dgvSchedule.Columns["Time"].HeaderText = "TIME";
        }
        public void ClearData()
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.DataSource = null;
            dgvSchedule.Columns.Add("Showtime", "SHOW TIME");
            dgvSchedule.Columns.Add("NameMovie", "NAME MOVIE");
            dgvSchedule.Columns.Add("NameRoom", "NAME ROOM");
            dgvSchedule.Columns.Add("Time", "TIME");
        }

        private void dateNavigator1_SelectionChanged(object sender, EventArgs e)
        {
            DateNavigator dateNavigator = sender as DateNavigator;
            if (dateNavigator != null)
            {
                DateTime selectedDate = dateNavigator.SelectionStart;
                DisplaySchedule(UserSession.idTheater, selectedDate.ToString("yyyy-MM-dd"));
            }
        }
    }
}
