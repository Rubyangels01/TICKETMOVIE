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

namespace TICKETMOVIE.Ui.Admin
{
    public partial class AddPromotion : Form,View
        
    {
        private readonly AddPromotionController controller;
        String name = "";
        String percent = "";
        String amount = "";
        String description = "";
        String startdate = "";
        String enddate = "";
        public AddPromotion()
        {
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            var movieService = new MovieService(); // Tạo đối tượng MovieService
            this.controller = new AddPromotionController(movieService, this);
            InitializeComponent();
        }
        private void GetInput()
        {
            name = txtName.Text.ToString();
            description = txtdescription.Text.ToString();
            percent = txtpercent.Text.ToString();
            amount = txtamount.Text.ToString();
            startdate = dtstartdate.Text.ToString();
            enddate = dtexprise.Text.ToString();
        }

        private void AddPromotion_Load(object sender, EventArgs e)
        {

        }

        public bool CHeckDate(string dateAString, string dateBString, string format = "dd/MM/yyyy")
        {
            try
            {
                DateTime today = DateTime.Today;
                DateTime dateA = DateTime.ParseExact(dateAString, format, null);
                DateTime dateB = DateTime.ParseExact(dateBString, format, null);

                if (dateA >= today && dateB > dateA)
                {
                    return true;
                }
                return false;

            }
            catch (FormatException)
            {
                // Xử lý lỗi nếu chuỗi không đúng định dạng
                Console.WriteLine("Chuỗi ngày không đúng định dạng: " + format);
                return false;
            }
        }
        public async void AddVoucher()
        {
           
           
                    
                
              
                    MessageBox.Show("Ngày đặt lịch chiếu không hợp lệ!");
                
           


        }
        public void DeleteFill()
        {
            txtName.Text = "";
            txtpercent.Text = "";
            txtdescription.Text = "";
            txtamount.Text = "";
            
        }

        private async void btn_AddPromotion_Click(object sender, EventArgs e)
        {
            GetInput();
           
            if (!name.Equals("") && !amount.Equals("") && !percent.Equals("") && !description.Equals(""))
            {
                if (CHeckDate(dtstartdate.Text.ToString(), dtexprise.Text.ToString(), "dd/MM/yyyy"))
                {

                    Promotion promotion = new Promotion(name, Int32.Parse(percent), amount, description, startdate, enddate);
                    MessageBox.Show(promotion.namePromotion);
                    await controller.AddPromotion(promotion);
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng ngày hiện tại và ngày kết thúc phải lớn hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK);
                }    
            }
            else
            {
                MessageBox.Show("Các trường không được để trống!", "Thông báo", MessageBoxButtons.OK);
            }    
            
        }

        private void txtpercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
