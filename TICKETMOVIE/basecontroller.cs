
using System;

namespace TICKETMOVIE
{
    public abstract class BaseController<S, V>
        where S : IMovieService
        where V : View
    {
        protected S SerVice { get; set; }
        protected V View { get; set; }

        protected BaseController(S service, V view)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service));
            if (view == null)
                throw new ArgumentNullException(nameof(view));
        }

        // Các phương thức chung cho controller
    }
}
