﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCommunity.Models;
using NLite.Data;

namespace MCommunity.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	WorkYearRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	WorkYearRepository
     * 创建时间:	2013/3/19 16:14:26
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	839e7eeb-fce2-4a1b-b465-3988e04182d4  
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
    public class WorkYearRepository   : Repository<WorkYear>, IWorkYearRepository
    {
        public WorkYearRepository(DbContext db)
            : base(db)
        { }
        
    }
}