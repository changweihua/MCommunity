using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Admin/Article/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Draft()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Manage()
        {
            return View();
        }

    }
}
