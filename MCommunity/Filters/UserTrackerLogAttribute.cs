using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Filters
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	UserTrackerLogAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Filters
     * 文 件 名:	UserTrackerLogAttribute
     * 创建时间:	2013/3/19 14:04:37
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	c4eb20eb-84df-4cbf-ad7f-77ae3be6b4ae  
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
    /// 使用日志记录一个访问的UserName、Controller、Action、时间戳。
    /// </summary>
    public class UserTrackerLogAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            string controllerName = actionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = actionDescriptor.ActionName;
            string userName = filterContext.HttpContext.User.Identity.Name.ToString();
            DateTime timeStamp = filterContext.HttpContext.Timestamp;
            string routeId = string.Empty;
            if (filterContext.RouteData.Values["id"] != null)
            {
                routeId = filterContext.RouteData.Values["id"].ToString();
            }
            StringBuilder message = new StringBuilder();
            message.Append("UserName=");
            message.Append(userName + "|");
            message.Append("Controller=");
            message.Append(controllerName + "|");
            message.Append("Action=");
            message.Append(actionName + "|");
            message.Append("TimeStamp=");
            message.Append(timeStamp.ToString() + "|");
            if (!string.IsNullOrEmpty(routeId))
            {
                message.Append("RouteId=");
                message.Append(routeId);
            }
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info(message.ToString());
            base.OnActionExecuted(filterContext);
        } 
    }
}