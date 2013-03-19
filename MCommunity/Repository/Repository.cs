using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLite.Data;

namespace MCommunity.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	Repository
     * 机器名称:	LUMIA800
     * 命名空间:	MCommunity.Repository
     * 文 件 名:	Repository
     * 创建时间:	2013/3/19 9:11:01
     * 作    者:	常伟华 Changweihua
	 * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	a855d8b9-1e6d-4687-b3d0-811357c11732  
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
    /// 2．下面我们实现一个泛型的类来具体实现上面的接口的方法。
    /// </summary>
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }
       
        public void Add(T entity)
        {
            using (context)
            {
                context.Set<T>().Insert(entity);
            }
            
        }

        public void Delete(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public IEnumerable<T> List()
        {
            using (context)
            {
                return context.Set<T>().ToList();
            }
        }

        public IEnumerable<T> Find(Func<T, bool> exp)
        {
            return context.Set<T>().Where(exp).ToList();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }
    }
}