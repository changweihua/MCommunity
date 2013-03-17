using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Controllers
{
    public class CommonController : Controller
    {
        //
        // GET: /Common/

        /// <summary>
        /// 验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult VerificationCode()
        {
            CLib.CImage.VerificationCode vc = new CLib.CImage.VerificationCode();
            string code = vc.CreateVerifyCode();
            //存储验证码
            Session["VerificationCode"] = code.ToUpper();
            //输出验证码
            vc.CreateImageCode(code).Save(Response.OutputStream, ImageFormat.Gif);
            return null;
        }


        public ActionResult CheckVerificationCode(string inputCode)
        {
            string code = Session["VerificationCode"] == null ? "" : Session["VerificationCode"].ToString();
            //输出验证码
            var flag = string.Compare(code, inputCode, true) == 0 ? true : false;

            return Json(flag);
        }

    }
}
