using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Controller;
using TICKETMOVIE.Custom;
using TICKETMOVIE.Model;

namespace TICKETMOVIE
{
    public partial class MoviePage : Form,View
    {
        
        private readonly MovieController movieController;
        List<string[]> listhour = new List<string[]>();
        string selectedhour; string selectedMinute;
        
        Movie movie1;
        public MoviePage()
        {
            InitializeComponent();
            
          
            
            var movieService = new MovieService(); // Tạo đối tượng MovieService
            this.movieController = new MovieController(movieService, this);
           
        }
        
        private void setdataHour()
        {
            var hours = new string[24];
            for (int i = 0; i < 24; i++)
            {
                hours[i] = i.ToString("D2"); // Ví dụ: "00:00", "01:00", ..., "23:00"
            }

            // Cập nhật ComboBox
            cb_hour.Items.Clear();
            cb_hour.Items.AddRange(hours);
        }
        public void setdataMinute()
        {
            var minutes = new string[60];
            for (int i = 0; i < 60; i++)
            {
                minutes[i] = i.ToString("D2"); // Ví dụ: "00", "01", ..., "59"
            }

            // Cập nhật ComboBox
            cb_minute.Items.Clear();
            cb_minute.Items.AddRange(minutes);
        }

        

        private async void LoadDetailMovie()
        {
            try
            {

                 await movieController.GetMovieByIdAsync(2);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadImageFromFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    DisplayImage(filePath);
                }
            }
        }
        public void DisplayDetailMovie(Movie movie)
        {
            String path = movie.image;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    img_picture.ImageLocation = path;
                    img_picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Đường dẫn ảnh trống.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
            }
            nameMovie.Text = movie.nameMovie;
            time.Text = movie.time.ToString() + " Phút";
            releasedtime.Text = movie.releasedDate.ToString();
            description.Text = movie.desciption;
            language.Text = movie.language;
            cast.Text = movie.cast;
            movie1 = movie;
        }
        private void DisplayImage(string filePath)
        {
            
        }
        /*
        private void GenerateLabels()
        {
            panel_hourshow.Controls.Clear(); // Xóa các điều khiển cũ

            int numberOfShows = int.Parse(txtnumbershow.Text);
            DateTime showDate = DateTime.Parse(edshowdate.Text);
            string[] showTimes = { "10:30", "11:45", "12:55" ,"16:15"};

            for (int i = 0; i < numberOfShows; i++)
            {
                if (i >= showTimes.Length) break; // Kiểm tra nếu vượt quá số phần tử trong showTimes

                TextBox lblShowTime = new TextBox
                {
                    Text = $"{showTimes[i]}",
                    AutoSize = true,
                    Margin = new Padding(10), // Khoảng cách giữa các label
                    Enabled = false,
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Verina", 10), // Cỡ chữ
                    Padding = new Padding(7, 7, 7, 7) // Khoảng cách bên trong
                    
                };

                // Thêm label vào panel
                panel_hourshow.Controls.Add(lblShowTime);
            }

            // Sử dụng FlowLayoutPanel để bố trí các label
            if (panel_hourshow is FlowLayoutPanel flowLayoutPanel)
            {
                flowLayoutPanel.AutoScroll = true;
                flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                flowLayoutPanel.WrapContents = false;
                
            }
            panel_displayschedule.Visible = true;
        }
        */

        private void btncreateschedule_Click(object sender, EventArgs e)
        {
            CreateDetailMovie();
        }
        private void DisplayShowTimes(Dictionary<DateTime, List<string>> showTimesByDate)
        {
            //panel_main_schedule.Controls.Clear();

            foreach (var dateTimePair in showTimesByDate)
            {
               // DateShowControl dateShowControl = new DateShowControl(dateTimePair.Value.Count, edshowdate.Text, dateTimePair.Value.ToArray());
               // panel_main_schedule.Controls.Add(dateShowControl);
            }
        }

        
        String showdate = "";
        
        
        public void LoadRoomNotHaveShedule(List<Rooms> rooms)
        {
            
            cb_room.DataSource = rooms;
            cb_room.DisplayMember = "NameRoom";
            cb_room.ValueMember = "IDRoom";
        }

        
        public async void SaveSchedulesOfMovieInTEMP(int idMovie, int idRoom, string showDate, string listtimeshow)
        {
            //await movieController.SaveScheduleOfMovieINTEMPAsync(idMovie, idRoom, showDate, listtimeshow);
            
        }
        private void edshowdate_EditValueChanged(object sender, EventArgs e)
        {        
            showdate = edshowdate.Text.ToString();
            cb_hour.Enabled = true;
            
            setdataHour();
            //GetRoomNotHaveSchedule();
        }
       
        
        public void DeleteFill()
        {
            cb_room.Text = "";
           
        }
        public async void CreateDetailMovie()
        {
            string time = selectedhour + ":" + selectedMinute;
            string date = dbHelper.ConvertDate(showdate, "yyyy-MM-dd") + " " + time;
            int value =(int) cb_room.SelectedValue;
            if(dbHelper.CheckDate(date))
            {
                await movieController.CreateDetailMovie(movie1.idMovie, (int)cb_room.SelectedValue, 2, date);
            } 
            else
            {
                MessageBox.Show("Ngày đặt lịch chiếu không hợp lệ!");
            }    
            
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            CreateDetailMovie();
        }
        

        private void icon_reload_Click(object sender, EventArgs e)
        {
            DeleteFill();
        }

        private void cb_room_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_hour_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedhour = cb_hour.SelectedItem as string;

            cb_minute.Enabled = true;
            setdataMinute();
        }

        private void cb_minute_SelectedIndexChanged(object sender, EventArgs e)
        {
             selectedMinute = cb_minute.SelectedItem as string;
            cb_room.Enabled = true;
            getRoomNotschedule();
        }
        
        public async void getRoomNotschedule()
        {
            string time = selectedhour + ":" + selectedMinute;
            string date = dbHelper.ConvertDate(showdate, "yyyy-MM-dd") + " " + time;
           
            await movieController.GetRoomNotScheduleByMovieAsync(1,date,movie1.time);
        }
    }
}
