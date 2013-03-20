using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Filters.Authorizes
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	SimpleAuthorizeAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Filters.Authorizes
     * 文 件 名:	SimpleAuthorizeAttribute
     * 创建时间:	2013/3/20 9:27:02
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	f1ab738d-8aa4-4c96-b991-45d1237ee2ff  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 代码顺序为：OnAuthorization-->AuthorizeCore-->HandleUnauthorizedRequest
    /// 如果AuthorizeCore返回false时，才会走HandleUnauthorizedRequest 方法，并且Request.StausCode会返回401,
    /// 所有，AuthorizeCore==false 时，会跳转到 web.config 中定义的  loginUrl="~/"
    /// 
    /// </summary>
    public class SimpleAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// 验证权限
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool isPass = false;
            
            if (CheckAuthority())
            {
                isPass = true;
            }
            else
            {
                httpContext.Response.StatusCode = 401;//无权限状态码
                isPass = false;
            }

            return isPass;
            //return base.AuthorizeCore(httpContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                if (!CheckAuthority())
                {
                    filterContext.Result = new JsonResult
                    {
                        Data = new { IsSuccess = false, Message = "对不起，您没有访问的权限，请不要越界操作！" },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };
                    return;
                }
            }

            base.HandleUnauthorizedRequest(filterContext);
            if (filterContext.HttpContext.Response.StatusCode == 401)
            {
                filterContext.Result = new RedirectResult("/error/noauthority");
            }

        }

        /// <summary>
        /// AuthorizeAttribute的OnAuthorization方法内部调用了AuthorizeCore方法，
        /// 这个方法是实现验证和授权逻辑的地方，如果这个方法返回true，表示授权成功，如果返回false， 表示授权失败, 
        /// 会给上下文设置一个HttpUnauthorizedResult，这个ActionResult执行的结果是向浏览器返回一个401状态码（未授权）,
        /// 但是返回状态码没什么意思，通常是跳转到一个登录页面，可以重写AuthorizeAttribute的HandleUnauthorizedRequest 
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        /// <summary>
        /// 验证权限
        /// </summary>
        /// <returns></returns>
        private bool CheckAuthority()
        {
            return false;
        }

    }
}