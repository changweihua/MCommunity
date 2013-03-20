using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Controllers
{
    public class AccountController : Controller
    {
        private AccountRepository accountRepository;
        IRepository<Province> provinceRepository;

        public AccountController()
        {
            accountRepository = new AccountRepository(new MCommunityContext());
            provinceRepository = new ProvinceRepository(new MCommunityContext());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(LoginModel model)
        {
            var flag = TryUpdateModel(model);
            NLog.LogManager.GetCurrentClassLogger().Debug(model.IsRemember);
            if (flag)
            {
                if (HttpContext.Session["VerificationCode"] == null || string.Compare(model.CheckCode, HttpContext.Session["VerificationCode"].ToString(), true) != 0)
                {
                    ModelState.AddModelError("CheckCode", "验证码错误");
                    return View(model);
                }
                else
                {
                    //model.Password = CLib.CSecurity.MD5Helper.GetMD5StringLowerCase(model.Password);
                    if (accountRepository.CheckLogin(model))
                    {
                        //记住我，自动登录
                        if (model.IsRemember)
                        {
                            Response.Cookies["IsRemember"].Value = "true";
                            Response.Cookies.Add(new HttpCookie("Email", model.Email));
                            //Response.Cookies["Email"].HttpOnly = true;
                            //Response.Cookies["Password"].Value= model.Password;
                            //Response.Cookies["Password"].HttpOnly = true;
                        }
                        else
                        {
                            Response.Cookies["IsRemember"].Expires = DateTime.Now.AddDays(-1);
                            Response.Cookies["Email"].Expires = DateTime.Now.AddDays(-1);
                        }
                        Session["User"] = model;
                        return RedirectToAction("Index", "Blog");
                    }
                    else
                    {
                        ModelState.AddModelError("Email", "邮箱不存在或者错误");
                        ModelState.AddModelError("Password", "密码可能错误");
                        return View(model);
                    }
                }
            }

            return View(model);
        }


        public ActionResult LogOut()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult OnLine()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult OffLine()
        {
            return PartialView();
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

    }
}
