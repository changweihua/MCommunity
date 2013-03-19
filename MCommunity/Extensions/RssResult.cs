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
     * 类 名 称:	RssFeedResult
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Extensions
     * 文 件 名:	RssFeedResult
     * 创建时间:	2013/3/19 12:25:01
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	8378332f-c0f0-47ff-9472-ff5895dc3f6a  
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
    public class RssResult : ActionResult
    {
        private List<RssFeed> feeds;

        public RssResult(List<RssFeed> list)
        {
            feeds = list;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/rss+xml";    // 设置HTTP头中的ContentType

            XElement channel = new XElement("channel");    // channel节点
            channel.Add(new XElement[]{
                new XElement("title","Test"),    // channel标题
                new XElement("link","http://localhost"),    // 页面链接
                new XElement("description","Test RSS")    // channel描述
            });
            
            foreach (var feed in feeds)    // 对rssFeed集合中的每个元素进行处理
            {
                XElement item = new XElement("item", new XElement[]{    // 生成一个新的item节点
                    new XElement("title",feed.Title),    // 为新的item节点添加子节点
                    new XElement("description",feed.Description),
                    new XElement("link",feed.Link),
                    new XElement("pubDate",feed.PublishDate)
                });
                channel.Add(item);    // 将新的item节点添加到channel中
            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),    // XML文档声明
                new XElement("rss",    // 根节点
                new XAttribute("version", "2.0"),    // rss节点的属性
                new XElement(channel)    // rss的子节点channel
            ));

            response.Write(doc.ToString());    // 将XML数据写入response中

        }

    }
    public class RssFeed
    {
        public string Description { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
    }

}