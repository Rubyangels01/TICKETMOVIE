    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
using TICKETMOVIE.Custom;
using TICKETMOVIE.Model;

namespace TICKETMOVIE
{
    public partial class MovieCustom : UserControl
    {
        private RevenuePage revenuePage;
        private HomePage homePage;
        public static Movie movie1;
        public string namemovie { get; set; }
        private string imgurl;
        private string showdate;

        public MovieCustom(Movie movie)
        {
            InitializeComponent();
           
            revenuePage = new RevenuePage();
            DisplayMovie(movie);
            movie1 = movie;
        }
        public void Display()
        {
            
        }

        public void DisplayMovie(Movie movie)
        {
            String path = movie.image;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    img_movie.ImageLocation = path;
                    img_movie.SizeMode = PictureBoxSizeMode.StretchImage;
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
            namemovie = movie.getNameMovie();
            this.Controls.Add(img_movie);
            // Đặt các thuộc tính cho txtnamemovie
            // Đặt các thuộc tính cho txtnamemovie
            // Đặt các thuộc tính cho txtnamemovie
            txtnamemovie.Text = movie.getNameMovie();
            txtnamemovie.AutoSize = false;
            txtnamemovie.TextAlign = ContentAlignment.MiddleCenter;
            txtnamemovie.Width = 200;
            txtnamemovie.Height = 50;
            txtnamemovie.MaximumSize = new Size(200, 0);
            txtnamemovie.AutoSize = true;
            txtnamemovie.Font = new Font(txtnamemovie.Font.FontFamily, 12);

            // Đặt vị trí cho txtnamemovie
            txtnamemovie.Location = new Point((this.Width - txtnamemovie.Width) / 2, txtnamemovie.Location.Y);

            
           

            btn_XemRevenue.Tag = movie;
           
            btnxem.Tag = movie;
            

            this.Controls.Add(txtnamemovie);
            this.Controls.Add(btnxem);
        }

        private void btnxem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Movie movie = btn.Tag as Movie;
                if (movie != null)
                {
                    using (FormDetailMovie form = new FormDetailMovie())
                    {
                        form.DisplayMovie(movie);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        
                        form.ShowDialog(); // Hiển thị form như hộp thoại
                    }
                }
            }
        }


        private void btn_XemRevenue_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Movie movie = btn.Tag as Movie;
                if (movie != null)
                {
                    movie1 = movie;
                    using (ScheduleOfMovie form = new ScheduleOfMovie())
                    {
                        form.DisplayMovie(movie);
                        form.StartPosition = FormStartPosition.CenterScreen;

                        form.ShowDialog(); // Hiển thị form như hộp thoại
                    }
                }
            }
        }

        public void LoadRevenue()
        {
            // Cập nhật nội dung của revenuePage nếu cần
        }
    }
}

