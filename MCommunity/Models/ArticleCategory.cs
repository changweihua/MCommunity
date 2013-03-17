using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLite.Data;

namespace MCommunity.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	ArticleCategory
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Models
     * 文 件 名:	ArticleCategory
     * 创建时间:	2013/1/23 16:50:47
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleCategory说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	8eea0d9a-33dd-45cb-9c34-2fb918d01b98  
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
    /// 
    [Table(Name = "tbArticleCategory")]
    public class ArticleCategory
    {
        [Id(IsDbGenerated = true)]
        public int CategoryId { get; set; }
        [Column(Name = "CategoryName")]
        public string CategoryName { get; set; }
        [Column(Name = "SortOrder")]
        public int SortOrder { get; set; }
    }
}