using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Controllers
{
    /// <summary>
    /// 全局Controller的基类
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// 重写方法，实现自定义的异常处理和结果页面的重定向
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            base.OnException(filterContext);
        }

    }
}
