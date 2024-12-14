using DevExpress.XtraEditors;
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
using TICKETMOVIE.Service;

namespace TICKETMOVIE
{
    public partial class ListReveneuForm : Form,View
    {
        private readonly AllRevenuControllercs revenuecontroller;
        public ListReveneuForm()
        {
            InitializeComponent();
            var ticketService = new TicketService(); // Tạo đối tượng MovieService
            this.revenuecontroller = new AllRevenuControllercs(ticketService, this);
            DisplayRevenue();
            
        }
        public async void DisplayRevenue()
        {
            await revenuecontroller.GetAllRevenueAsync(UserSession.idTheater);
        }

        public async void DisplayRevenueByShowdate(int idTheater, string showdate)
        {
            await revenuecontroller.GetAllRevenueByShowdateAsync(idTheater, showdate);
        }

        public void LoadData(List<Revenue> listrevenue)
        {
            dgvRevenue.Columns.Clear();
            dgvRevenue.DataSource = listrevenue;
            
            dgvRevenue.Columns["NameMovie"].HeaderText = "NAME MOVIE";
            dgvRevenue.Columns["ShowCount"].HeaderText = "SHOW COUNT";
            dgvRevenue.Columns["TotalRevenue"].HeaderText = "TOTAL REVENUE";
            dgvRevenue.Columns["TotalTickets"].HeaderText = "TOTAL TICKETS";
        }

        public void ClearData()
        {
            dgvRevenue.Columns.Clear();
            dgvRevenue.DataSource = null;

            dgvRevenue.Columns.Add("NameMovie", "NAME MOVIE");
            dgvRevenue.Columns.Add("ShowCount", "SHOW COUNT");
            dgvRevenue.Columns.Add("TotalRevenue", "TOTAL REVENUE");
            dgvRevenue.Columns.Add("TotalTickets", "TOTAL TICKETS");
        }

        private void dateStartDate_EditValueChanged(object sender, EventArgs e)
        {
            DateEdit dateEdit = sender as DateEdit;
            var selectedValue = dateEdit.EditValue;
            
            
            if (selectedValue == null)
            {
                DisplayRevenue();
            }
            else
            {
                DateTime selectedDate = (DateTime)dateEdit.EditValue;
                DisplayRevenueByShowdate(UserSession.idTheater, selectedDate.ToString("yyyy-MM-dd"));

            }

            
            


        }

        private void ListReveneuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
