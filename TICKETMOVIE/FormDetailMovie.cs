using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;
using TICKETMOVIE.Ui.Admin;

namespace TICKETMOVIE
{
    public partial class FormDetailMovie : Form
    {
        public static Movie movie1;
        public FormDetailMovie()
        {
            InitializeComponent();
            CheckAdmin();
        }
        public bool CheckAdmin()
        {
            if(UserSession.idUser == 1)
            {              
                btn_Setschedule.Visible = false;
                return true;
            }
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDetailMovie_Load(object sender, EventArgs e)
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
            txtnamemovie.Text = movie.getNameMovie();
            txttime.Text = movie.time + " Phút";
            txtreleaseddate.Text = movie.releasedDate.ToString();
            txtlanguage.Text = movie.language;
            txtcast.Text = movie.cast;
            txtdescription.Text = movie.desciption;
            movie1 = movie;

           
            movie1 = movie;

        }

        private void btn_Setschedule_Click(object sender, EventArgs e)
        {
            MoviePage page = new MoviePage();
            this.Hide();
            page.StartPosition = FormStartPosition.CenterParent;
            page.DisplayDetailMovie(movie1);
            // Hiển thị form con và gán sự kiện FormClosed để hiển thị lại form cha khi form con đóng
            page.FormClosed += (s, args) =>
            {
                // Hiển thị lại form cha
                this.Show();
            };
            page.ShowDialog();
        }

        private void btn_Revenue_Click(object sender, EventArgs e)
        {
            if(CheckAdmin())
            {
                using (RevenueMovieAllTheater form = new RevenueMovieAllTheater())
                {
                    this.Hide();                  
                    form.StartPosition = FormStartPosition.CenterScreen;

                    form.FormClosed += (s, args) =>
                    {
                        // Hiển thị lại form cha
                        this.Show();
                    };
                    form.ShowDialog(); // Hiển thị form như hộp thoại
                }
            } 
            else
            {
                using (RevenuePage form = new RevenuePage())
                {
                    this.Hide();
                    form.DisplayMovie(movie1);
                    form.StartPosition = FormStartPosition.CenterScreen;

                    form.FormClosed += (s, args) =>
                    {
                        
                        this.Show();
                    };
                    form.ShowDialog(); // Hiển thị form như hộp thoại
                }
            }    
            
        }

        private void icon_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
