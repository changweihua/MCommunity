﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Areas.Admin.Controllers
{
    public class VisitsController : BaseController
    {
        //
        // GET: /Admin/Visits/

        public ActionResult Index()
        {
            return View();
        }

    }
}
