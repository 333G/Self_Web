using dotNetcore_for_selfweb.Entity;
using DotNetCore20.DAL.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SelfWeb.DAL.UserInfoDAL
{
    public partial class UserInfoDAL : DbContext
    {
        #region 单例模式
        private static UserInfoDAL instance;
        private static object _lock = new object();

        private UserInfoDAL()
        {
        }

        public static UserInfoDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new UserInfoDAL();
                        }
                    }
                }
                return instance;
            }
        }
        #endregion 单例模式
        public object Create(UserInfoEntity model)
        {
            Add(model);
            return SaveChanges();
        }

        public object Delete(UserInfoEntity model)
        {
            Remove(model);
            return SaveChanges();
        }

        public object Get(string UserId)
        {

            return this.Find(typeof(UserInfoEntity), UserId);
        }

        public object Change(UserInfoEntity model)
        {
            this.Update<UserInfoEntity>(model);
            return SaveChanges();
        }
    }
}
