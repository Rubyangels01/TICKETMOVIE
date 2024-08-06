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
    public partial class ShowTimeControl : UserControl
    {
        public ShowTimeControl(String txtshowdate,String room,int numberOfShows, String[] showTimes)
        {
            InitializeComponent();
            for (int i = 0; i < numberOfShows; i++)
            {
                if (i >= showTimes.Length) break; // Kiểm tra nếu vượt quá số phần tử trong showTimes

                TextBox lblShowTime = new TextBox
                {
                    Text = $"{showTimes[i]}",
                    AutoSize = true,
                    Margin = new Padding(10), // Khoảng cách giữa các label
                    ReadOnly = true,
                    TextAlign = HorizontalAlignment.Center,
                    Font = new Font("Verina", 10), // Cỡ chữ
                    Padding = new Padding(7, 7, 7, 7) // Khoảng cách bên trong

                };
                showdate.Text = txtshowdate;
                labelroom.Text = "PHÒNG " + room;
                panel_display.Controls.Add(labelroom);
                panel_display.Controls.Add(showdate);
                panel_hourshow.Controls.Add(lblShowTime);
                panel_display.Controls.Add(panel_hourshow);
                if (panel_hourshow is FlowLayoutPanel flowLayoutPanel)
                {
                    flowLayoutPanel.AutoScroll = true;
                    flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                    flowLayoutPanel.WrapContents = false;

                }
            }
            
        }
    }
}
