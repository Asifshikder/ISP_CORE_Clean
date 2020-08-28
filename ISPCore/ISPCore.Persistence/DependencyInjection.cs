using ISPCore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ISPCore.Persistence
{
    public static class DependencyInjection
    { 

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DBContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("ISPDatabase")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            //services.AddScoped<IHrmsDbContext>(provider => provider.GetService<HrmsDbContext>());

            return services;
        }
    }
}
