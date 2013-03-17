using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MCommunity.Models;

namespace MCommunity.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	MCommunityContextInitializer
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	MCommunityContextInitializer
     * 创建时间:	2013/1/24 11:44:51
     * 作    者:	常伟华 Changweihua
	 * 版    权:	MCommunityContextInitializer说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	81038796-6f29-4ecb-acfb-7d6a5fa425a3  
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
    //public class MCommunityContextInitializer : DropCreateDatabaseAlways<MCommunityContext>
    public class MCommunityContextInitializer : DropCreateDatabaseIfModelChanges<MCommunityContext>
    {
        protected override void Seed(MCommunityContext context)
        {
            context.ArticleCategories.Add(new ArticleCategory { CategoryName = "分类1", SortOrder = 1 });

            base.Seed(context);
        }
    }
}