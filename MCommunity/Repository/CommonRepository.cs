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
     * 类 名 称:	CommonRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	CommonRepository
     * 创建时间:	2013/3/18 10:22:45
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	bdaead5a-e471-4812-a5f6-07e2d735d2fa  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    public class OccupationRepository : RepositoryBase<Occupation>
    {
        /// <summary>
        /// 岗位
        /// </summary>
        /// <returns></returns>
        public IQueryable<Occupation> List()
        {
            IQueryable<Occupation> occupations = null;
            using (var db = new MCommunityContext())
            {
                occupations = db.Occupations;
            }

            return occupations;
        }
    }

    public class ProvinceRepository : RepositoryBase<Province>
    {
        /// <summary>
        /// 岗位
        /// </summary>
        /// <returns></returns>
        public IQueryable<Province> List()
        {
            IQueryable<Province> provinces = null;
            using (var db = new MCommunityContext())
            {
                provinces = db.Provinces;
            }

            return provinces;
        }
    }

    public class IndustryRepository : RepositoryBase<Industry>
    {
        /// <summary>
        /// 岗位
        /// </summary>
        /// <returns></returns>
        public IQueryable<Industry> List()
        {
            IQueryable<Industry> industries = null;
            using (var db = new MCommunityContext())
            {
                industries = db.Industries;
            }

            return industries;
        }
    }

    public class WorkYearRepository : RepositoryBase<WorkYear>
    {
        /// <summary>
        /// 岗位
        /// </summary>
        /// <returns></returns>
        public IQueryable<WorkYear> List()
        {
            IQueryable<WorkYear> workYears = null;
            using (var db = new MCommunityContext())
            {
                workYears = db.WorkYears;
            }

            return workYears;
        }
    }

    public class CommonRepository
    {
        public static IQueryable<Province> Provinces
        {
            get
            {
                return new ProvinceRepository().List();
            }
        }
    }


}