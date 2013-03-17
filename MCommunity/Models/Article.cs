﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCommunity.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	Article
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Models
     * 文 件 名:	Article
     * 创建时间:	2013/1/25 21:11:10
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Article说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	f56abfae-de10-4481-84a1-419ba57fcd7c  
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
    public class Article
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 文章摘要
        /// </summary>
        public string Summary { get; set; }
        /// <summary>
        /// 作者编号
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// 评论
        /// </summary>
        public int RemarkId { get; set; }
        /// <summary>
        /// 文章所属类别
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 是否精华
        /// </summary>
        public int IsEssence { get; set; }
        /// <summary>
        /// 是否推荐
        /// </summary>
        public int IsRecommand { get; set; }
        /// <summary>
        /// 博客地址
        /// </summary>
        public string LinkUrl { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime PublishTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// 博客描述
        /// </summary>
        public string BlogDescription { get; set; }
    }
}