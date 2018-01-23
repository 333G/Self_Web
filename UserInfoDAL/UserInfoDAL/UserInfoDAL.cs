using dotNetcore_for_selfweb.Entity;
using DotNetCore20.DAL.DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SelfWeb.DAL.UserInfoDAL
{
    public partial class UserInfoDAL
    {
        DotNetCoreDbContext dotNetCoreDbContext = new DotNetCoreDbContext();
        #region 单例模式
        private static UserInfoDAL instance;
        private static object _lock = new object();
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

            dotNetCoreDbContext.Add(model);
            return dotNetCoreDbContext.SaveChanges();

        }

        public object Delete(UserInfoEntity model)
        {
            //using (var db = new DotNetCoreDbContext())
            //{
            //    db.Remove(model);
            //    return db.SaveChanges();
            //}
            dotNetCoreDbContext.Remove(model);
            return dotNetCoreDbContext.SaveChanges();
        }

        public object Get(string UserId)
        {
            //using (var db = new DotNetCoreDbContext())
            //{
            //    return db.Userinfo.Find(typeof(UserInfoEntity), UserId);
            //}
            return dotNetCoreDbContext.Find(typeof(UserInfoEntity), UserId);
        }

        public object Change(UserInfoEntity model)
        {
            //using (var db = new DotNetCoreDbContext())
            //{
            //    db.Update<UserInfoEntity>(model);
            //    return db.SaveChanges();
            //}
            dotNetCoreDbContext.Update<UserInfoEntity>(model);
            return dotNetCoreDbContext.SaveChanges();
        }
    }
}
