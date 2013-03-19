using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace MCommunity.Extensions
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	XmlResult
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Extensions
     * 文 件 名:	XmlResult
     * 创建时间:	2013/3/19 13:25:20
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	9a9f6346-d2e2-45f1-8198-a4150d244042  
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
    public class XmlResult : ActionResult
    {
        // 可被序列化的内容
        private object dataToXml { get; set; }
        private Type type;

        // 构造器
        public XmlResult(object data, Type t)
        {
            dataToXml = data;
            type = t;
        }

        // 主要是重写这个方法
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;

            // 设置 HTTP Header 的 ContentType
            response.ContentType = "application/xml";

            if (dataToXml != null)
            {
                // 序列化 Data 并写入 Response
                XmlSerializer serializer = new XmlSerializer(type);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (XmlTextWriter writer = new XmlTextWriter(ms, Encoding.UTF8))
                    {
                        writer.Formatting = Formatting.Indented;
                        XmlSerializerNamespaces n = new XmlSerializerNamespaces();
                        n.Add("MonoBook", "http://www.cmono.net");
                        serializer.Serialize(writer, dataToXml, n);
                        response.Write(System.Text.Encoding.UTF8.GetString(ms.ToArray()));
                    }
                }


            }
        }
    }
}