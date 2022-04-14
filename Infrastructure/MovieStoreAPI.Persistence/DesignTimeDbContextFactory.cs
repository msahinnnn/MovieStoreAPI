using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MovieStoreAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MovieStoreAPIDbContext>
    {
        public MovieStoreAPIDbContext CreateDbContext(string[] args)
        {
           


            DbContextOptionsBuilder<MovieStoreAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new MovieStoreAPIDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
