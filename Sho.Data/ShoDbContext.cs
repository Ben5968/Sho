using Microsoft.EntityFrameworkCore;
using Sho.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sho.Data
{
    public class ShoDbContext : DbContext
    {
        public ShoDbContext(DbContextOptions<ShoDbContext> contextOptions)
               : base(contextOptions)
        {
        }
        public ShoDbContext()
        {
        }

        public DbSet<Alliance> Alliances { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAlliance> UserAlliances { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserName> UserNames { get; set; }
    }  
}
