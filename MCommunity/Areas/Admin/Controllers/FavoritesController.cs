using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Areas.Admin.Controllers
{
    public class FavoritesController : BaseController
    {
        //
        // GET: /Admin/Favorites/

        public ActionResult Index()
        {
            return View();
        }

    }
}
