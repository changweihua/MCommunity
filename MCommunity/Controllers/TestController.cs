using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            using (var db = new MCommunityContext())
            {
                var count = db.ArticleCategories.Insert(new ArticleCategory { CategoryName = "分类1", SortOrder = 1 });
                var text = db.ArticleCategories.SqlText;
                ViewBag.Count = count;
                ViewBag.Text = text;
            }
            return View();
        }

        public ActionResult GetJson()
        {
            List<ArticleCategory> list;
            using (var db = new MCommunityContext())
            {
                list = db.ArticleCategories.ToList();
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

    }
}
