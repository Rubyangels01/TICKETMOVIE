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

namespace TICKETMOVIE.Custom
{
    public partial class TheaterCustom : UserControl
    {
        public int idTheater { get; set; }
        public string nametheater { get; set; }
        public string address { get; set; }
        public Theaters theaters { get; set; }
        public TheaterCustom()
        {
            InitializeComponent();
        }
        public void DisplayUI()
        {
            nameTheater.Text = nametheater;
            addresstheater.Text = address;
            
        }
        
        private void btn_Xem_Click(object sender, EventArgs e)
        {
             
                if (idTheater != 0)
                {
                    using (DetailTheater form = new DetailTheater())
                    {
                        
                        form.GetListMovie(idTheater);
                        form.StartPosition = FormStartPosition.CenterScreen;

                        form.ShowDialog(); // Hiển thị form như hộp thoại
                    }
                }
            

        }
    }
}
