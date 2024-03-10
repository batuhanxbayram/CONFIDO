using CONFİDO.Data.Repositories;
using CONFİDO.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONFİDO.Data.Extensions
{
    public static class DataLayerExtension
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContextPool<Context.AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));

            services.AddScoped<IUnitOfWork,UnitOfWork>();


            return services;
        }
    }
}
