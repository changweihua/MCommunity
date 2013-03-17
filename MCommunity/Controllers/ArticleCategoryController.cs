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
        private ArticleCategoryRepository repository;
        //
        // GET: /ArticleCategory/

        public ActionResult Index()
        {
            repository = new ArticleCategoryRepository();
            IQueryable<ArticleCategory> articleCategoryies;
            // repository.Add(new ArticleCategory { SortNumber = 1, CategoryName = "2222" });
            articleCategoryies = repository.List();

            return View(articleCategoryies);
        }

        public ActionResult List()
        {
            repository = new ArticleCategoryRepository();
            IQueryable<ArticleCategory> articleCategoryies;
            articleCategoryies = repository.List();

            return Json(articleCategoryies, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult New(ArticleCategory category)
        {
            repository = new ArticleCategoryRepository();

            bool flag = repository.Add(category);

            return Json(flag);
        }

    }
}
