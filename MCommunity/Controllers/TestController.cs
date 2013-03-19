using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using MCommunity.Extensions;
using MCommunity.Models;
using MCommunity.Repository;

namespace MCommunity.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            int a = 0;
            int b = 10 / a;

            using (var db = new MCommunityContext())
            {
                var count = db.ArticleCategories.Insert(new ArticleCategory { CategoryName = "分类1", SortOrder = 1 });
                var text = db.ArticleCategories.SqlText;
                ViewBag.Count = count;
                ViewBag.Text = text;
            }
            return View();
        }

        public ActionResult GetJson()
        {
            List<ArticleCategory> list;
            using (var db = new MCommunityContext())
            {
                list = db.ArticleCategories.ToList();
            }
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetRss()
        {
            // 添加2个测试用的数据
            RssFeed r1 = new RssFeed { Description = "Test3", Link = "http://localhost/1", Title = "Test1", PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") };
            RssFeed r2 = new RssFeed { Description = "Test4", Link = "http://localhost/2", Title = "Test2", PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") };
            List<RssFeed> rssFeedList = new List<RssFeed>();
            rssFeedList.Add(r1);
            rssFeedList.Add(r2);

            //Response.ContentType = "text/xml";

            return new RssActionResult<RssFeed>("aaa", rssFeedList, (f) =>
            {
                return new XElement("item", new XElement[]{    // 生成一个新的item节点
                    new XElement("title",f.Title),    // 为新的item节点添加子节点
                    new XElement("description",f.Description),
                    new XElement("link",f.Link),
                    new XElement("pubDate",f.PublishDate)
                });
            });

            //return new RssResult(rssFeedList);
        }

        public ActionResult GetXml()
        {
            var list = new List<Person>() { 
                new Person{ Id=1, Name="1"}    ,
                new Person{ Id=2, Name="2"}
            };

            return new XmlResult(list, new Person().GetType());
        }

    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
