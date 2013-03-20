using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Filters.Authorizes;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Areas.Admin.Controllers
{
    public class ArticleController : BaseController
    {
        private ArticleRepository articleRepository;
        private ArticleCategoryRepository articleCategoryRepository;
        private ArticleTypeRepository articleTypeRepository;

        public ArticleController()
        {
            articleRepository = new ArticleRepository(new MCommunityContext());
            articleCategoryRepository = new ArticleCategoryRepository(new MCommunityContext());
            articleTypeRepository = new ArticleTypeRepository(new MCommunityContext());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Draft()
        {
            return View();
        }

        public ActionResult ListDraft()
        {
            var list = articleRepository.ListDraft().Select(d => new { 
                id = d.ArticleId,
                title = d.Title  ,
                category = d.Category.CategoryName,
                createDate = d.CreateDate
            });
            return Json(new { count = list.Count(), drafts = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(articleCategoryRepository.List(), "CategoryId", "CategoryName");
            ViewBag.Types = articleTypeRepository.List();// new SelectList(articleTypeRepository.List(), "TypeId", "TypeName");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CreateModel model)
        {
            var flag = TryUpdateModel(model);
            if (flag)
            {
                articleRepository.Add(new Article
                {
                    CategoryId = model.CategoryId,
                    AuthorId = 1,
                    Content = model.Content,
                    CreateDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),
                    PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"),
                    IsDraft = model.IsDraft,
                    Title = model.Title,
                    IsAllowComment = model.IsAllowComment,
                    IsPublic = model.IsPublic,
                    IsTop = model.IsTop,
                    Summary = "摘要",
                    Tag = "标签",
                    TypeId = model.TypeId
                });
                return Json(new { msg = "添加成功了哟" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { msg = "为啥子这样子呢" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Manage()
        {
            return View();
        }

    }
}
