using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AboMag.Models
{
    public class AboMagContext : DbContext
    {
        public AboMagContext (DbContextOptions<AboMagContext> options)
            : base(options)
        {
        }

        public DbSet<AboMag.Models.User> User { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql(System.Configuration.GetConnectionString("AboMagContext"));
    }
}
