using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Areas.Admin.Controllers
{
    public class ArticleCategoryController : BaseController
    {

        private ArticleCategoryRepository articleCategoryRepository;

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
            var articleCategoryies = articleCategoryRepository.List().Select(c => new { id = c.CategoryId, name = c.CategoryName, order = c.SortOrder });
            return Json(new { categories = articleCategoryies }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Create(ArticleCategory category)
        {
            var flag = true;
            articleCategoryRepository.Add(category);
            return Json(new { success = flag });
        }

        [HttpPost]
        public ActionResult Delete(int categoryId)
        {
            var flag = true;
            articleCategoryRepository.Delete(categoryId);
            return Json(new { success = flag, msg = "删除成功" });
        }

    }
}
