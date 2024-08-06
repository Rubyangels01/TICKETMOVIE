using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICKETMOVIE.Custom
{
    public partial class RoomCustom : UserControl
    {
        public string nameRoom { get; set; }
        public int numberchair { get; set; }
        public string nameMovie { get; set; }
        public string showDate { get; set; }
        public string endTime { get; set; }
        public int numberticket { get; set; }


        public RoomCustom()
        {
            InitializeComponent();
            this.Click += RoomCustom_Click;
            // Đăng ký sự kiện Click cho các control bên trong nếu cần
            foreach (Control control in this.Controls)
            {
                control.Click += RoomCustom_Click;
            }
        }
        private void RoomCustom_Click(object sender, EventArgs e)
        {
            
            Test test = new Test();

            test.Show();
            
        }
        public void UpdateUI()
        {
            // Cập nhật giao diện với thuộc tính
            namephong.Text = nameRoom;
            numberChair.Text = numberchair.ToString() + " Ghế";
            namemovie.Text = nameMovie;
            showdate.Text =dbHelper.convertDate(showDate);
            time.Text = dbHelper.convertDate(endTime); 
            numberTicket.Text = numberticket.ToString() + " Vé";
            
        }

    }
}

