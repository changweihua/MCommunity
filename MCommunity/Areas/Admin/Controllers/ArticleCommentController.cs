using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Areas.Admin.Controllers
{
    public class ArticleCommentController : BaseController
    {
        //
        // GET: /Admin/ArticleComment/

        public ActionResult Index()
        {
            return View();
        }

    }
}
