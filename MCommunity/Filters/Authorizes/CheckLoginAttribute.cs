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
     * 类 名 称:	CheckLoginAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Filters.Authorizes
     * 文 件 名:	CheckLoginAttribute
     * 创建时间:	2013/3/20 9:55:45
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	64b55684-66d9-4f06-b234-6a618689a566  
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
    /// 是否登录
    /// </summary>
    public class CheckLoginAttribute  : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool isLogin = false;
            if (!CheckLogin())
            {
                isLogin = false;
                httpContext.Response.StatusCode = 401;//无权限状态码
            }
            else
            {
                isLogin = true;
            }
            return isLogin;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                if (!CheckLogin())
                {
                    filterContext.Result = new JsonResult
                    {
                        Data = new { IsSuccess = false, Message = "不好意思,登录超时,请重新登录再操作!" },
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };
                    return;
                }
            }

            base.HandleUnauthorizedRequest(filterContext);
            if (filterContext.HttpContext.Response.StatusCode == 401)
            {
                filterContext.Result = new RedirectResult("/account/logon");
            }

        }

        //验证是否登录
        private bool CheckLogin()
        {
            return true;
        }
    }
}