using dotNetcore_for_selfweb.Entity;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore20.DAL.DbContext
{
    public class DotNetCoreDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DotNetCoreDbContext(DbContextOptions<DotNetCoreDbContext> options) : base(options)
        {
        }
        public DbSet<UserInfoEntity> UserExtend { get; set; }
    }
}
