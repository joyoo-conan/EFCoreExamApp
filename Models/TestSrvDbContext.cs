using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExamApp.Models
{
    public class TestSrvDbContext : DbContext
    {
        //DbSet으로 TestSrvDB Table 정의
        public DbSet<TAccountMst> Accounts { get; set; }

        public DbSet<TAccountRoleDtl> AccountRoleDtl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Models.GVar.GetDBConstr() /*Connection String*/);
        }
    }
}
