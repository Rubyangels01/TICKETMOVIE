using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TICKETMOVIE.Model;

namespace TICKETMOVIE.Ui.Admin
{
    public partial class HomeAdmin : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public HomeAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Maximized;
            ShowFormInPanel(new ListMovieAdmin());
        }
        public void ShowFormInPanel(Form formToShow)
        {
            panel_main.Controls.Clear();
            formToShow.TopLevel = false;
            formToShow.FormBorderStyle = FormBorderStyle.None;
            formToShow.Dock = DockStyle.Fill;
            panel_main.Tag = formToShow;
            panel_main.Controls.Add(formToShow);
            formToShow.Show();
        }

        private void btn_Addmovie_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new AddMoviePage());
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            UserSession.idUser = 0;
            using (Logincs form = new Logincs())
            {
                this.Hide();
                form.StartPosition = FormStartPosition.CenterScreen;
                form.WindowState = FormWindowState.Maximized;


                form.ShowDialog(); // Hiển thị form như hộp thoại
                this.Close();
            }

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new TheaterForm());
        }

        private void btn_theaterofmovie_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new RevenueMovieAllTheater());
        }

        private void btn_listmovie_Click(object sender, EventArgs e)
        {
           
            ShowFormInPanel(new ListMovieAdmin());
        }

        private void btn_revenueoftheater_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new TheaterForm());
        }

        private void btn_addaccount_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new AddAccount());
        }

        private void pagePromotion_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ListPromotion());
        }

        private void addpromotionpage_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new AddPromotion());
        }
    }
}
