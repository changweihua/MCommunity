using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Repository;

namespace MCommunity.Controllers
{
    public class BlogController : Controller
    {
        private ArticleRepository articleRepository;

        public BlogController()
        {
            articleRepository = new ArticleRepository(new MCommunityContext());
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetArticle()
        {
            var list = articleRepository.ListArticle().Select(a => new
            {
                title = a.Title,
                summary = a.Summary,
                author = "常伟华",
                category = a.Category.CategoryName,
                type = a.Type.TypeName,
                tag = a.Tag,
                comments = 100,
                score = a.Score ,
                isTop = a.IsTop
            });
            return Json(new { articles = list }, JsonRequestBehavior.AllowGet);
        }

    }
}
