using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Controllers
{
    public class ArticleCategoryController : Controller
    {
        private IRepository<ArticleCategory> articleCategoryRepository;

        public ArticleCategoryController()
        {
            articleCategoryRepository = new ArticleCategoryRepository(new MCommunityContext());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetJson()
        {
            var articleCategoryies = articleCategoryRepository.List();
            return Json(new { categories = articleCategoryies }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult New(ArticleCategory category)
        {
            var flag = true;
            return Json(flag);
        }

    }
}
