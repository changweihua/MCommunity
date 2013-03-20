using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Controllers
{
    public class GlobalController : Controller
    {
       
        [ChildActionOnly]
        public ActionResult FriendLinks()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult CopyRight()
        {
            return PartialView();
        }

    }
}
