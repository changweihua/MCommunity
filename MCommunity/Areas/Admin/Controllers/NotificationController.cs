using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Areas.Admin.Controllers
{
    public class NotificationController : BaseController
    {
        //
        // GET: /Admin/Notification/

        public ActionResult Index()
        {
            return View();
        }

    }
}
