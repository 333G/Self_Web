using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dotNetcore_for_selfweb.Models
{
    public class dotNetcore_for_selfwebContext : DbContext
    {
        public dotNetcore_for_selfwebContext (DbContextOptions<dotNetcore_for_selfwebContext> options)
            : base(options)
        {
        }

        public DbSet<dotNetcore_for_selfweb.Models.UserInfoModel> UserInfoModel { get; set; }
    }
}
