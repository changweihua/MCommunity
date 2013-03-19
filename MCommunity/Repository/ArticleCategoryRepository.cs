using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCommunity.Models;
using NLite.Data;

namespace MCommunity.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	ArticleCategoryRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	ArticleCategoryRepository
     * 创建时间:	2013/1/23 16:58:51
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleCategoryRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	e944eae9-98de-464f-ae17-8ed2b32e4dd9  
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
    public class ArticleCategoryRepository : Repository<ArticleCategory>, IArticleCategoryRepository
    {
        public ArticleCategoryRepository(DbContext db)
            : base(db)
        { }

        public bool Delete(int categoryId)
        {
            using (context)
            {
                return context.Set<ArticleCategory>().Delete(_ => _.CategoryId == categoryId) == 1 ? true : false;
            }
        }
        
    }
}