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

namespace TICKETMOVIE
{
    public partial class TicketCustomer : Form
    {
        public TicketCustomer()
        {
            InitializeComponent();
        }
        public void LoadData(List<Ticket2> listtimeshow)
        {
            dgvTicket.Columns.Clear();
            dgvTicket.DataSource = listtimeshow;
            dgvTicket.Columns["IDTicket"].HeaderText = "CODE TICKET";
            dgvTicket.Columns["Fullname"].HeaderText = "NAME CUSTOMER";
            dgvTicket.Columns["NameChair"].HeaderText = "NAME CHAIR";
            dgvTicket.Columns["Total"].HeaderText = "TOTAL";
            dgvTicket.Columns["Payment"].HeaderText = "PAYMENT";
            dgvTicket.Columns["ShowDate"].HeaderText = "SHOWDATE";
            int numberOfRows = dgvTicket.Rows.Count;
            
            numberticket.Text = "Tổng số vé: " + numberOfRows.ToString();

            List<string> columnData = new List<string>();
            int Sum = 0;
            foreach (DataGridViewRow row in dgvTicket.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    
                    Sum = Sum + Int32.Parse(row.Cells["Total"].Value.ToString());
                }
            }
            numberRevenue.Text = "Tổng doanh thu: " + Sum.ToString("N0");

            
            

        }
    }
}
