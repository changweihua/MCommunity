using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLite;
using NLite.Data;

namespace MCommunity.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	ArticleModel
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Models
     * 文 件 名:	ArticleModel
     * 创建时间:	2013/3/18 9:05:25
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	2ba13131-79c3-43ac-89b8-082874f8f570  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    [Table(Name="tbArticle")]
    public class Article
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        /// 
        [Id(Name="ArticleId", IsDbGenerated=true)]
        public int ArticleId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        /// 
        [Column(Name = "CategoryId")]
        public int CategoryId { get; set; }
        /// <summary>
        /// 类型编号
        /// </summary>
        /// 
        [Column(Name = "TypeId")]
        public int TypeId { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        /// 
        [Column(Name = "Title")]
        public string Title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        /// 
         [Column(Name = "Content")]
        public string Content { get; set; }
        /// <summary>
        /// 文章摘要
        /// </summary>
        /// 
         [Column(Name = "Summary")]
        public string Summary { get; set; }
        /// <summary>
        /// 作者编号
        /// </summary>
        /// 
        [Column(Name = "AuthorId")]
        public int AuthorId { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        /// 
        [Column(Name = "IsDraft")]
        public int IsDraft { get; set; }
        /// <summary>
        /// 文章所属类别
        /// </summary>
        /// 
        [Column(Name = "IsPublic")]
        public int IsPublic { get; set; }
        /// <summary>
        /// 是否精华
        /// </summary>
        /// 
        [Column(Name = "IsAllowComment")]
        public int IsAllowComment { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        /// 
        [Column(Name = "IsTop")]
        public int IsTop { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        /// 
        [Column(Name = "PublishDate")]
        public string PublishDate { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        /// 
        [Column(Name = "CreateDate")]
        public string CreateDate { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        /// 
        [Column(Name = "Tag")]
        public string Tag { get; set; }
        /// <summary>
        /// 博客描述
        /// </summary>
        /// 
        [Column(Name = "Score")]
        public int Score { get; set; }
        /// <summary>
        /// 博客描述
        /// </summary>
        /// 
        [Column(Name = "ScoreCount")]
        public int ScoreCount { get; set; }
        /// <summary>
        /// 博客描述
        /// </summary>
        /// 
        [Column(Name = "PraiseCount")]
        public int PraiseCount { get; set; }

        [Association(ThisKey = "CategoryId", OtherKey = "CategoryId")]
        public ArticleCategory Category { get; set; }

        [Association(ThisKey = "TypeId", OtherKey = "TypeId")]
        public ArticleType Type { get; set; }

    }

    public class CreateModel
    {
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int IsAllowComment { get; set; }
        public int IsPublic { get; set; }
        public int IsDraft { get; set; }
        public int IsTop { get; set; }
    }

    [Table(Name = "tbArticleCategory")]
    public class ArticleCategory
    {
        [Id(Name = "CategoryId", IsDbGenerated = true)]
        public int CategoryId { get; set; }
        [Column(Name = "CategoryName")]
        public string CategoryName { get; set; }
        [Column(Name = "SortOrder")]
        public int SortOrder { get; set; }
    }

    [Table(Name = "tbArticleType")]
    public class ArticleType
    {
        [Id(Name = "TypeId", IsDbGenerated = true)]
        public int TypeId { get; set; }
        [Column(Name = "TypeName")]
        public string TypeName { get; set; }
    }

    public class ArticleComment
    {
    }

}