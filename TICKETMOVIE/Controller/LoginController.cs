using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;
using TICKETMOVIE.Service;

namespace TICKETMOVIE.Controller
{
    
     public class LoginController : BaseController<UserService, Logincs>
    {
        private readonly MovieResData movieResData;
        
        public LoginController(UserService service, Logincs activity)
        : base(service, activity)
        {
            this.SerVice = service;
            this.View = activity;
            movieResData = new MovieResData();
        }
        

        public async Task LoginAsync(string email, string password)
        {
      
            try
            {
               
                var (url, content) = SerVice.UrlLogin(email, password);
                
                ResData res = await movieResData.GetResDataWithBodyUser(url, content);
               

                if (res == null)
                {
                    
                    MessageBox.Show("Lỗi hệ thống,vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    
                    if (res.code == 201 || res.code == 200)
                    {
                        
                        Managers user = dbHelper.ConvertToClass<Managers>(res.data);
                        
                        UserSession.idUser = user.IDManager;
                        if (user.Email.Contains("admin"))
                        {
                            View.IntentHomeAdmin();
                        }
                        else
                        {
                            View.getTheater(email);
                           

                        }

                    }
                    else
                    {
                        MessageBox.Show(res.message,"Thông báo",MessageBoxButtons.OK);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async Task GetTheaterAsync(string email)
        {

            try
            {
                
                ResData res = await movieResData.GetResDataUser(SerVice.UrlGetTheaterByUser(email));


                if (res == null)
                {
                    MessageBox.Show("Lỗi hệ thống,vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (res.code == 201 || res.code == 200)
                    {

                        List<Theaters> theaters = dbHelper.ConvertToClass<List<Theaters>>(res.data);

                        UserSession.idTheater = theaters[0].idTheater;
                        
                        View.IntentHome();

                    }
                    else
                    {
                        MessageBox.Show(res.message, "Thông báo", MessageBoxButtons.OK);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
