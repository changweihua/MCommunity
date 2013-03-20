using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult NotFound()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NoAuthority()
        {
            return View();
        }

    }
}
