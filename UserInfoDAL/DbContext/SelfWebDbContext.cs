using dotNetcore_for_selfweb.Entity;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore20.DAL.DbContext
{
    public class DotNetCoreDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("server=127.0.0.1;database=mydb;uid=root;pwd=defaultpassword;");
        //}
        public DotNetCoreDbContext()
        {
            //    DbContextOptionsBuilder dbContextOptionsBuilder = new DbContextOptionsBuilder();
            //    //dbContextOptionsBuilder.UseMySQL("server=127.0.0.1;database=mydb;uid=root;pwd=defaultpassword;");
            //    OnConfiguring(dbContextOptionsBuilder);
        }

        public DotNetCoreDbContext(DbContextOptions<DotNetCoreDbContext> options) : base(options)
        {
        }

        public DbSet<UserInfoEntity> Userinfo { get; set; }
    }
}