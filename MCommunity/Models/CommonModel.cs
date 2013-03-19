using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLite.Data;

namespace MCommunity.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	WorkYear
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Models
     * 文 件 名:	WorkYear
     * 创建时间:	2013/3/17 23:50:40
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	5a4d30f0-f7db-4a75-9d07-9a920b8823f1  
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
    [Table(Name = "tbWorkYear")]
    public class WorkYear
    {
        [Id(IsDbGenerated = true, Name = "WorkYearId")]
        public int WorkYearId { get; set; }
        [Column(Name = "WorkYearName")]
        public string WorkYearName { get; set; }
    }

    [Table(Name = "tbIndustry")]
    public class Industry
    {
        [Id(IsDbGenerated = true, Name = "IndustryId")]
        public int IndustryId { get; set; }
        [Column(Name = "IndustryName")]
        public string IndustryName { get; set; }
    }

    [Table(Name = "tbOccupation")]
    public class Occupation
    {
        [Id(IsDbGenerated = true, Name = "OccupationId")]
        public int OccupationId { get; set; }
        [Column(Name = "OccupationName")]
        public string OccupationName { get; set; }
    }

    [Table(Name = "tbProvince")]
    public class Province
    {
        [Id(IsDbGenerated = true, Name = "ProvinceId")]
        public int ProvinceId { get; set; }
        [Column(Name = "ProvinceName")]
        public string ProvinceName { get; set; }
    }

}