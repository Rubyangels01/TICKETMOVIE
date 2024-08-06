using System;
using System.Drawing;
using System.Windows.Forms;
using TICKETMOVIE.Model;
using TICKETMOVIE.Ui.Admin;

namespace TICKETMOVIE.Custom.Admin
{
    public partial class MovieCustomAdmin : UserControl
    {
        public string Path { get; set; }
        public string Name { get; set; }
        public string Released { get; set; }
        public int IdMovie { get; set; }
        public Movie movie1 { get; set; }

        public MovieCustomAdmin()
        {
            InitializeComponent();
            this.Click += MovieCustomAdmin_Click;
        }

        public void UpdateUI()
        {
            try
            {
                if (!string.IsNullOrEmpty(Path))
                {
                    img_movie.ImageLocation = Path;
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
            namemovie.Text = Name;
            releaseddate.Text = Released;
            
        }

        private void MovieCustomAdmin_Click(object sender, EventArgs e)
        {
            

            var parentForm = this.FindForm() as RevenueMovieAllTheater;
            if (parentForm != null)
            {
                parentForm.DisplayRevenue(IdMovie);
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {                                        
                if (movie1 != null)
                {
                    using (FormDetailMovie form = new FormDetailMovie())
                    {
                        form.DisplayMovie(movie1);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.ShowDialog();
                    }
                }
            
        }
    }
}
