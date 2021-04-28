using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcCore;

namespace MvcCore
{
    public class UserContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=PCIN490774;Initial Catalog=test;Integrated Security=True");
            }
        }
        public DbSet<MvcCore.Login> Login { get; set; }
    }
}
