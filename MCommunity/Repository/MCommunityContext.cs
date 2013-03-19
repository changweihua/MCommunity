using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using MCommunity.Models;
using NLite.Data;

namespace MCommunity.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	MCommunityContext
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	MCommunityContext
     * 创建时间:	2013/3/17 17:25:15
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	479a714e-c208-4f80-b630-353cd1df9526  
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
    public class MCommunityContext : DbContext
    {
        //连接字符串名称：基于Config文件中连接字符串的配置
        const string connectionStringName = "MCommunity";

        //构造dbConfiguration 对象
        static DbConfiguration dbConfiguration = DbConfiguration
                .Configure(connectionStringName)
                .AddClass<Article>()
                .AddClass<ArticleCategory>()
                .AddClass<Province>()
                .AddClass<Account>()
                .AddClass<Industry>()
                .AddClass<Occupation>()
                .AddClass<WorkYear>()
                .AddClass<ArticleType>()
                ;
        public MCommunityContext() : base(dbConfiguration) {
        }

        public IDbSet<ArticleCategory> ArticleCategories;

        public IDbSet<Article> Articles;
        public IDbSet<Province> Provinces;
        public IDbSet<Account> Accounts;

        public IDbSet<Industry> Industries;
        public IDbSet<Occupation> Occupations;
        public IDbSet<WorkYear> WorkYears;
        public IDbSet<ArticleType> ArticleTypes;
    }
}