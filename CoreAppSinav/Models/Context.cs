using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAppSinav.Models
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-38F6FLL\MSSQLSERVER2014; Database = NETCORE;Trusted_Connection=True;MultipleActiveResultSets=true");
        }



        public DbSet<Departmanlar> GorevDepartmans { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
