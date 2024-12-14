using Microsoft.Office.Interop.Excel;
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
using Application = Microsoft.Office.Interop.Excel.Application;

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

        private void btn_export_Click(object sender, EventArgs e)
        {
            Application excelApp = new Application();
            Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];

            // Đặt tiêu đề cho các cột
            for (int i = 0; i < dgvTicket.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgvTicket.Columns[i].HeaderText;
            }

            // Xuất dữ liệu từ DataGridView ra Excel
            for (int i = 0; i < dgvTicket.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTicket.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvTicket.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Lưu và mở file Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Giải phóng tài nguyên
            releaseObject(worksheet);
            releaseObject(workbook);
            releaseObject(excelApp);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
