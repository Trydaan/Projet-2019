using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AboMag.Models;

namespace AboMag.Models
{
    public class AboMagContext : DbContext
    {
        public AboMagContext (DbContextOptions<AboMagContext> options)
            : base(options)
        {
        }

        public DbSet<AboMag.Models.User> User { get; set; }

        public DbSet<AboMag.Models.Publication> Publication { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql(System.Configuration.GetConnectionString("AboMagContext"));
    }
}
