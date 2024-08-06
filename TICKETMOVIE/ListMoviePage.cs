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
    public partial class ListMoviePage : Form,View
    {
        private readonly ListMovieController listmovieController;
        private List<MovieCustom> movieControls = new List<MovieCustom>();
        public ListMoviePage()
        {
            InitializeComponent();
            var movieService = new MovieService(); // Tạo đối tượng MovieService
            this.listmovieController = new ListMovieController(movieService, this);
            DisplayStatus();
            searchControl1.TextChanged += searchControl1_Click;
        }
        
        public async void GetListMovie()
        {
            await listmovieController.GetListMovieAsync();
        }
        public async void GetListMovieUpcoming()
        {
            await listmovieController.GetListMovieUpcomingAsync();
        }
        public void Load_ListMovie(List<Movie> listmovie)
        {
            panel_displaylistmovie.Controls.Clear();
            foreach(var movie in listmovie)
            {
                MovieCustom movieCustom = new MovieCustom(movie);
                movieControls.Add(movieCustom);
                panel_displaylistmovie.Controls.Add(movieCustom);
            }    
            
        }
        private void DisplayStatus()
        {
            // Tạo Dictionary với kiểu khóa là int và kiểu giá trị là string
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Đang chiếu");
            status.Add(2, "Sắp chiếu");

            // Chuyển đổi Dictionary thành danh sách KeyValuePair
            var bindingList = new BindingList<KeyValuePair<int, string>>(status.ToList());

            // Cài đặt DataSource cho ComboBox
            cb_status.DataSource = bindingList;
            cb_status.DisplayMember = "Value"; // Hiển thị giá trị
            cb_status.ValueMember = "Key"; // Giá trị của ComboBox là khóa
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)cb_status.SelectedItem;
                int selectedKey = selectedItem.Key;
                if(selectedKey == 1)
                {
                    GetListMovie();
                }  
                else
                {
                    GetListMovieUpcoming();
                }    

            }
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchControl1_Click(object sender, EventArgs e)
        {
            string searchText = searchControl1.Text.ToLower();
            panel_displaylistmovie.Controls.Clear();

            var filteredControls = movieControls
                .Where(mc => mc.namemovie.ToLower().Contains(searchText))
                .ToList();

            foreach (var control in filteredControls)
            {
                panel_displaylistmovie.Controls.Add(control);
            }
        }
    }
}
