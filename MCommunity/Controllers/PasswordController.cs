using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;

namespace MCommunity.Controllers
{
    public class PasswordController : Controller
    {
        //
        // GET: /Password/

        public ActionResult Modify()
        {
            return View();
        }

        public ActionResult Forget()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Modify(ChangePasswordModel model)
        {
            //bool flag = true;
            //if (ModelState.IsValid)
            //{
            //    return Json(flag);
            //}
            //else 
            //{
            //    return Json(ModelState.ToList());
            //}

            bool flag = true;
            if (ModelState.IsValid)
            {
                return Json(flag);
            }
            return View(model);
        }

    }
}
