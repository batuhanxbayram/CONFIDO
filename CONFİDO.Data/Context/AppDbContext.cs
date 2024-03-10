using CONFİDO.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CONFİDO.Data.Context
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }

            public DbSet<Organization>? Organizations { get; set; }
         


            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            }
        }
    }

