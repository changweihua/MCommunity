using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;

namespace MCommunity.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult PasswordReset()
        {
            return View();
        }

        public ActionResult PasswordForget()
        {
            return View();
        }

        public ActionResult PortraintReset()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PortraintReset(int id, FormCollection collection)
        {
            var oldData = new { Id = 1, Portraint = 1 };
            if (TryUpdateModel(oldData, "", collection.AllKeys, new string[] { "ID", "Name" }))
            {
            }

            return View(oldData);
        }

        [HttpPost]
        public ActionResult PasswordForget(User user)
        {
            return View();
        }

        [HttpPost]
        public ActionResult PasswordReset(ChangePasswordModel model)
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
