using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Areas.Admin.Controllers
{
    public class ProfileController : BaseController
    {
        //
        // GET: /Admin/Profile/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email()
        {
            return View();
        }

        public ActionResult Password()
        {
            return View();
        }

        public ActionResult Portraint()
        {
            return View();
        }

    }
}
