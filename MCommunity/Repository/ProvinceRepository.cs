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
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	ProvinceRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	ProvinceRepository
     * 创建时间:	2013/3/19 9:16:02
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	579fa157-23a2-4060-ae66-3b08f7ad0e61  
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
    /// 4.最后该实体的Repository类实现如下：
    /// </summary>
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        public ProvinceRepository(DbContext db)
            : base(db)
        { }

        public IList<Province> GetAllByBookId(int id)
        {
            return null;
        }

    }
}