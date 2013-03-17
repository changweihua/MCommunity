using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MCommunity.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	User
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Models
     * 文 件 名:	User
     * 创建时间:	2013/1/25 22:11:39
     * 作    者:	常伟华 Changweihua
	 * 版    权:	User说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	c2c47c22-84aa-4afd-bb96-c592fe756e46  
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
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public int Sex { get; set; }
        public int ProvinceId { get; set; }
        public int CityId { get; set; }
        public DateTime JoinTime { get; set; }
        public string SelfDescription { get; set; }
        public int ProfessionalId { get; set; }
        public int IndustryId { get; set; }
        public int WorkYearId { get; set; }
    }

    public class ChangePasswordModel
    {
        public int Id { get; set; }
        [Display(Name = "原密码")]
        [Required(ErrorMessage = "{0}必须填写")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Display(Name = "新密码")]
        [Required(ErrorMessage = "{0}必须填写")]
        [DataType(DataType.Password)]
        [StringLength(15, MinimumLength=8, ErrorMessage="{0} 在 {1}和{2}之间")]
        public string NewPassword { get; set; }
        [Display(Name = "确认新密码")]
        [Required(ErrorMessage = "{0}必须填写")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ReNewPassword { get; set; }
    }

}