using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MCommunity.Models;

namespace MCommunity.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	IProvinceRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	IProvinceRepository
     * 创建时间:	2013/3/19 9:12:56
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	0fa236e4-3252-4a40-bc09-2b01cdb4874a  
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
    /// 3.上面我们实现是每个实体公共的操作，但是实际中每个实体都有符合自己业务的逻辑。我们单独定义另外一个接口
    /// </summary>
    interface IProvinceRepository : IRepository<Province>
    {
        IList<Province> GetAllByBookId(int id);
    }
}