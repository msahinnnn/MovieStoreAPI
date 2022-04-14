using Microsoft.EntityFrameworkCore;
using MovieStoreAPI.Domain.Entities;
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

        /
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
