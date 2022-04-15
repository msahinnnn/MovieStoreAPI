using MovieStoreAPI.Application.Repositories;
using MovieStoreAPI.Domain.Entities;
using MovieStoreAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Persistence.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(MovieStoreAPIDbContext context) : base(context)
        {
        }
    }
}
