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
    public partial class ScheduleOfMovie : Form,View
    {
        private readonly ScheduleOfMovieController schedulecontroller;
        DateTime selectedDate;
        Movie movie1 = new Movie();
        public ScheduleOfMovie()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            var movieService = new MovieService(); // Tạo đối tượng MovieService
            this.schedulecontroller = new ScheduleOfMovieController(movieService, this);
           

        }
        
        public void LoadData(List<TimeShow> listtimeshow)
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.DataSource = listtimeshow;
            dgvSchedule.Columns["ShowTime"].HeaderText = "START TIME";
            dgvSchedule.Columns["EndTime"].HeaderText = "END TIME";
            dgvSchedule.Columns["IDRoom"].HeaderText = "ROOM CODE";
            dgvSchedule.Columns["NameRoom"].HeaderText = "NAME ROOM";
            
        }

        internal void DisplayMovie(Movie movie)
        {
            movie1 = movie;
            namemovie.Text = movie.nameMovie;
            DisplayScheduleMovie(UserSession.idTheater, DateTime.Today.ToString("yyyy-MM-dd"),movie.idMovie);
        }
        public async void DisplayScheduleMovie(int idTheater, string showdate, int idMovie)
        {
            await schedulecontroller.GetScheduleMovieAsync(idTheater,showdate,idMovie);
        }

        private void icon_back_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void add_schedule_Click(object sender, EventArgs e)
        {
            using (MoviePage form = new MoviePage())
            {
                this.Hide();
                form.DisplayDetailMovie(MovieCustom.movie1);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormClosed += (s, args) =>
                {
                    // Hiển thị lại form cha
                    this.Show();
                };
                form.ShowDialog(); // Hiển thị form như hộp thoại
            }
        }

        public void ClearData()
        {
            dgvSchedule.Columns.Clear();
            dgvSchedule.DataSource = null;
       
            dgvSchedule.Columns.Add("ShowTime", "START TIME");
            dgvSchedule.Columns.Add("EndTime", "END TIME");
            dgvSchedule.Columns.Add("IDRoom", "ROOM CODE");
            dgvSchedule.Columns.Add("NameRoom", "NAME ROOM");
        }

        private void dateNavigator1_SelectionChanged(object sender, EventArgs e)
        {
            DateNavigator dateNavigator = sender as DateNavigator;
            if (dateNavigator != null)
            {
                selectedDate = dateNavigator.SelectionStart;
                DisplayScheduleMovie(UserSession.idTheater, selectedDate.ToString("yyyy-MM-dd"),movie1.idMovie);
            }
           
        }
        public async void GetDataTicket(int idMovie, int idRoom, string showdate)
        {
            await schedulecontroller.GetTicketByMovieAndShowdateAsync(idMovie, idRoom, showdate);
        }
        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {if (e.RowIndex >= 0)
{
    try
    {
        DataGridViewRow row = dgvSchedule.Rows[e.RowIndex];

        string showtime = row.Cells["ShowTime"].Value?.ToString() ?? string.Empty;     
        int idRoom = 0;
                    string showdate = selectedDate.ToString("yyyy-MM-dd") + " " + showtime;
        if (row.Cells["IDRoom"].Value != null && int.TryParse(row.Cells["IDRoom"].Value.ToString(), out idRoom))
                      
        {
  
            GetDataTicket(movie1.idMovie, idRoom, showdate );
        }
        else
        {
            // Xử lý trường hợp không thể chuyển đổi IDRoom sang số nguyên
            MessageBox.Show("Invalid IDRoom value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    catch (Exception ex)
    {
        // Xử lý lỗi
        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        }
        public void DisplayTicket(List<Ticket2> tickets)
        {
            using (TicketCustomer form = new TicketCustomer())
            {
                this.Hide();
                form.LoadData(tickets);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.FormClosed += (s, args) =>
                {
                    // Hiển thị lại form cha
                    this.Show();
                };

                form.ShowDialog(); // Hiển thị form như hộp thoại
            }
        }
    }
}
