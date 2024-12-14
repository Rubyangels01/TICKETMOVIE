using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TICKETMOVIE.Model;
using TICKETMOVIE.Ui.Admin;

namespace TICKETMOVIE.Controller
{
   public class AddPromotionController : BaseController<MovieService, AddPromotion>
    {
        private readonly MovieResData movieResData;
        public AddPromotionController(MovieService movieService, AddPromotion addPromotion)
            : base(movieService, addPromotion)
        {
            this.SerVice = movieService;
            this.View = addPromotion;
            movieResData = new MovieResData();
        }
        public async Task AddPromotion(Promotion promotion)
        {
            try
            {
                
                var (url, content) = SerVice.UrlAddPromotion(promotion);
                ResData res = await movieResData.GetResDataWithBody(url, content);

                if (res != null && (res.code == 201 || res.code == 200))
                {
                    MessageBox.Show("Thêm voucher thành công!", "Thông báo", MessageBoxButtons.OK);
                    View.DeleteFill();
                }
                else
                {
                    MessageBox.Show(res.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
