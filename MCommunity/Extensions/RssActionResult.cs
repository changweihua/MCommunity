using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MCommunity.Extensions
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	RssActionResult
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Extensions
     * 文 件 名:	RssActionResult
     * 创建时间:	2013/3/19 13:00:46
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	c87929f8-5a2e-44cc-b97d-aa91f8f3b936  
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
    /// 摘要
    /// </summary>
    public abstract class RssActionResult : ActionResult
    {
    }

    public class RssActionResult<T> : RssActionResult
    {
        public RssActionResult(string title, IEnumerable<T> data, Func<T, XElement> formatter)
        {

            Title = title;
            DataItems = data;
            Formatter = formatter;
        }

        public IEnumerable<T> DataItems { get; set; }
        public Func<T, XElement> Formatter { get; set; }
        public string Title { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {

            HttpResponseBase response = context.HttpContext.Response;

            // set the content type of the response 
            response.ContentType = "application/rss+xml";
            // get the RSS content 
            string rss = GenerateXML(response.ContentEncoding.WebName);
            // write the content to the client 
            response.Write(rss);
        }

        private string GenerateXML(string encoding)
        {

            XDocument rss = new XDocument(new XDeclaration("1.0", encoding, "yes"),
               new XElement("rss", new XAttribute("version", "2.0"),
                   new XElement("channel", new XElement("title", Title),
                       DataItems.Select(e => Formatter(e)))));

            return rss.ToString();
        }
    }

}