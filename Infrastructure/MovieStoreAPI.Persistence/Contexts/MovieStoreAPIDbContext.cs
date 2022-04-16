using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MovieStoreAPI.Domain.Entities;
using MovieStoreAPI.Domain.Entities.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Persistence.Contexts
{
    public class MovieStoreAPIDbContext : DbContext
    {

        public MovieStoreAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            var datas = ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {

                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDateTime = DateTime.UtcNow,
                };

            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
