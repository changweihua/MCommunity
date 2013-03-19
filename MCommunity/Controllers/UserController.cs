using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Controllers
{
    public class UserController : Controller
    {
        IRepository<Province> provinceRepository;

        public UserController()
        {
            provinceRepository = new ProvinceRepository(new MCommunityContext());
        }

        public ActionResult Register()
        {
            IEnumerable<Province> provinces = null;
            //using (var db = new MCommunityContext())
            //{
            //    provinces = db.Provinces.ToList();
            //    //provinces = db.Provinces.Select(x => new Province { ProvinceId = x.ProvinceId, ProvinceName = x.ProvinceName }).ToList();
            //}
            provinces = provinceRepository.List();
            ViewBag.Provinces = new SelectList(provinces, "ProvinceId", "ProvinceName");
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            //IList<Province> provinces = null;

            //if (HttpContext.Session["VerificationCode"] == null || string.Compare(model.CheckCode, HttpContext.Session["VerificationCode"].ToString(), true) != 0)
            //{
            //    ModelState.AddModelError("CheckCode", "错误");
            //    return View(model);
            //}

            var flag = TryUpdateModel(model);
            if (flag)
            {
                model.CityId = 1;
                using (var db = new MCommunityContext())
                {
                    db.Accounts.Insert(new Account { AccountName = model.AccountName, CityId = model.CityId, ProvinceId = model.ProvinceId, Email = model.Email, JoinDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), Gender = model.Gender, NickName = model.NickName, Password = model.Password });
                }
                return RedirectToAction("Index", "Home");
            }

            var provinces = provinceRepository.List();
            ViewBag.Provinces = new SelectList(provinces, "ProvinceId", "ProvinceName");

            return View(model);
        }


        //public ActionResult PasswordReset()
        //{
        //    return View();
        //}

        //public ActionResult PasswordForget()
        //{
        //    return View();
        //}

        //public ActionResult PortraintReset()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult PortraintReset(int id, FormCollection collection)
        //{
        //    var oldData = new { Id = 1, Portraint = 1 };
        //    if (TryUpdateModel(oldData, "", collection.AllKeys, new string[] { "ID", "Name" }))
        //    {
        //    }

        //    return View(oldData);
        //}

        //[HttpPost]
        //public ActionResult PasswordForget(User user)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult PasswordReset(ChangePasswordModel model)
        //{
        //    //bool flag = true;
        //    //if (ModelState.IsValid)
        //    //{
        //    //    return Json(flag);
        //    //}
        //    //else 
        //    //{
        //    //    return Json(ModelState.ToList());
        //    //}

        //    bool flag = true;
        //    if (ModelState.IsValid)
        //    {
        //        return Json(flag);
        //    }
        //    return View(model);
        //}

    }
}
