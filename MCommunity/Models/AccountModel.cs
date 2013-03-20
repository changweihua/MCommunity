using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NLite.Data;

namespace MCommunity.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	UserModel
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Models
     * 文 件 名:	UserModel
     * 创建时间:	2013/3/18 9:05:10
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	3b8c80fb-c16c-48c5-b2d3-3e3599f0f355  
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
    [Table(Name="tbAccount")]
    public class Account
    {
        [Id(Name = "AccountId", IsDbGenerated = true)]
        public int AccountId { get; set; }
        [Column(Name = "AccountName")]
        public string AccountName { get; set; }
        [Column(Name = "Email")]
        public string Email { get; set; }
        [Column(Name = "Password")]
        public string Password { get; set; }
        [Column(Name = "NickName")]
        public string NickName { get; set; }
        [Column(Name = "Gender")]
        public string Gender { get; set; }
        [Column(Name = "Address")]
        public string Address { get; set; }
        [Column(Name = "ProvinceId")]
        public int ProvinceId { get; set; }
        [Column(Name = "CityId")]
        public int CityId { get; set; }
        [Column(Name = "JoinDate")]
        public string JoinDate { get; set; }
        [Column(Name = "Signature")]
        public string Signature { get; set; }
        [Column(Name = "OccupationId")]
        public int OccupationId { get; set; }
        [Column(Name = "IndustryId")]
        public int IndustryId { get; set; }
        [Column(Name = "WorkYearId")]
        public int WorkYearId { get; set; }
        [Column(Name = "Portraint")]
        public string Portraint { get; set; }
    }

    /// <summary>
    /// 注册模型
    /// </summary>
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RePassword { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        [Required]
        public string CheckCode { get; set; }
    }

    /// <summary>
    /// 登录模型 
    /// </summary>
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string CheckCode { get; set; }
        public bool IsRemember { get; set; }
    }

}