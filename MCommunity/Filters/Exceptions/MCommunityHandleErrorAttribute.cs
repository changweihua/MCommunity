using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Filters.Exceptions
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	MCommunityErrorhandleAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Filters.Exceptions
     * 文 件 名:	MCommunityErrorhandleAttribute
     * 创建时间:	2013/3/19 9:49:31
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	ce87e64f-5498-4eec-86d6-83f7e10310b8  
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
    /// 注意：HandleErrorAttribute只处理500系列错误，所以404错误需要另外单独处理
    /// 只能处理异常，如果出现类似404等错误，则无效
    /// 处理404使用customerError节点
    /// <customErrors mode="On" defaultRedirect=""><error redirect="~/Error/NotFound"  statusCode="404" /></customErrors>
    /// </summary>
    public class MCommunityHandleErrorAttribute : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //是否企启用自定义异常处理机制
            NLog.LogManager.GetCurrentClassLogger().Info(filterContext.HttpContext.IsCustomErrorEnabled);
            //if (filterContext.HttpContext.IsCustomErrorEnabled)
            //{
            //    //标志异常已经被处理，不加，则会继续执行，交给系统默认的异常处理机制
            //    filterContext.ExceptionHandled = true;
            //    //记录异常信息
            //    NLog.LogManager.GetCurrentClassLogger().Error(filterContext.Exception.Message);
            //}

            //标志异常已经被处理，不加，则会继续执行，交给系统默认的异常处理机制
            filterContext.ExceptionHandled = true;
            //记录异常信息
            NLog.LogManager.GetCurrentClassLogger().Error(filterContext.Exception.Message);
            base.OnException(filterContext);

            //OVERRIDE THE 500 ERROR ，使得页面继续执行下去，但是该Action不会执行 
            //filterContext.HttpContext.Response.StatusCode = 200;
            filterContext.HttpContext.Response.Redirect("/error");

        }

        private static void RaiseErrorSignal(Exception e)
        {
            var context = HttpContext.Current;
            // using.Elmah.ErrorSignal.FromContext(context).Raise(e, context);
        } 

    }
}