using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Filters;

namespace MCommunity.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [UserTrackerLog] 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

    }
}
