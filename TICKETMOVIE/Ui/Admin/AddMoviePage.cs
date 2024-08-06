using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICKETMOVIE.Ui.Admin
{
    public partial class AddMoviePage : Form
    {
        int selectedKey = 0;
        public AddMoviePage()
        {
            InitializeComponent();
            Setdatalanguage();
            SetdataTypeMovie();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Setdatalanguage()
        {
            cblanguage.Items.Add("Vietsub");
            cblanguage.Items.Add("English");
            cblanguage.Items.Add("ThaiLand");
            cblanguage.Items.Add("Korea");
            
          
        }

        public void SetdataTypeMovie()
        {
            
            Dictionary<int, string> status = new Dictionary<int, string>();
            status.Add(1, "Tâm Lý");
            status.Add(2, "Hài Hước");
            status.Add(3, "Hành Động");
            status.Add(4, "Kinh Dị");
            status.Add(5, "Phiêu Lưu");
            status.Add(7, "Hình Sự");
            status.Add(8, "Tình Cảm");
            
            var bindingList = new BindingList<KeyValuePair<int, string>>(status.ToList());
            cbtype.DataSource = bindingList;
            cbtype.DisplayMember = "Value"; 
            cbtype.ValueMember = "Key"; // Giá trị của ComboBox là khóa
        }
        String img_path = "";

        private void btn_Chooseimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    imgmovie.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    img_path = openFileDialog.FileName;
                }
            }
        }
        int status = 1;

        public async Task UploadMovieAsync()
        {
            var url = "http://192.168.1.8:3002/movies/movie"; // Thay đổi thành URL của API

            using (var form = new MultipartFormDataContent())
            {
                // Thêm các dữ liệu khác vào form
                form.Add(new StringContent(txtnamemovie.Text.ToString()), "namemovie");
                form.Add(new StringContent(txttime.Text.ToString()), "time");
                form.Add(new StringContent(txtdescription.Text.ToString()), "description");
                form.Add(new StringContent(dbHelper.ConvertDate(datereleaseddate.Text,"yyyy-MM-dd")), "releaseddate");
                form.Add(new StringContent(cblanguage.Text), "language");
                form.Add(new StringContent(txtcast.Text), "cast");
                form.Add(new StringContent(txtprice.Text), "price");
                form.Add(new StringContent(status.ToString()), "status");
                form.Add(new StringContent(selectedKey.ToString()), "idType");

                // Thêm ảnh vào form
                var imageContent = new ByteArrayContent(System.IO.File.ReadAllBytes(img_path));
                imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg"); // Hoặc loại MIME phù hợp với ảnh của bạn
                form.Add(imageContent, "image", System.IO.Path.GetFileName(img_path));

                // Gửi yêu cầu POST
                using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, form);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Tạo phim thành công!","Thông báo",MessageBoxButtons.OK);
                        using (HomeAdmin form1 = new HomeAdmin())
                        {
                           
                            form1.StartPosition = FormStartPosition.CenterScreen;

                            form1.ShowDialog(); // Hiển thị form như hộp thoại
                        }
                    }
                else
                {
                        MessageBox.Show("Tạo phim thất bại, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK);

                    }
            }
            }
        }

        private async void btnAddMovie_Click(object sender, EventArgs e)
        {
          await  UploadMovieAsync();
        }

        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtype.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)cbtype.SelectedItem;
                   selectedKey = selectedItem.Key;
               

            }
        }
    }
}
