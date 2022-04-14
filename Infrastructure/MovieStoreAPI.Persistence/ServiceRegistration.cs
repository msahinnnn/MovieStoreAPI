using Microsoft.Extensions.DependencyInjection;
using MovieStoreAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {

            services.AddDbContext<MovieStoreAPIDbContext>(options =>
            options.UseNpgsql(Configuration.ConnectionString));

        }
    }
}
