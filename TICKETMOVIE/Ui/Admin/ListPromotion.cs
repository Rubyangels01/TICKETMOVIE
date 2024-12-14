using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICKETMOVIE.Ui.Admin
{
    public partial class ListPromotion : Form
    {
        public ListPromotion()
        {
            InitializeComponent();
        }

        private void ListPromotion_Load(object sender, EventArgs e)
        {

        }
        public void LoadData()
        {
            dgv_promotion.Columns.Clear();
            dgv_promotion.Columns.Add("Showtime", "Showtime");
            dgv_promotion.Columns.Add("NameMovie", "Name Movie");
            dgv_promotion.Columns.Add("NameRoom", "Name Room");
            dgv_promotion.Columns.Add("Time", "Time");

            // Tạo cột xóa
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.Name = "Delete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Image = Properties.Resources.delete; // Đường dẫn đến icon xóa
            dgv_promotion.Columns.Add(deleteColumn);

            // Tạo cột chỉnh sửa
            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = "Edit";
            editColumn.HeaderText = "Edit";
            editColumn.Image = Properties.Resources.icon_edit; // Đường dẫn đến icon chỉnh sửa
            dgv_promotion.Columns.Add(editColumn);

            
            dgv_promotion.Rows.Add("10:00", "Avatar", "Room 1", "120");
            dgv_promotion.Rows.Add("13:00", "Titanic", "Room 2", "150");

        }
    }
}
