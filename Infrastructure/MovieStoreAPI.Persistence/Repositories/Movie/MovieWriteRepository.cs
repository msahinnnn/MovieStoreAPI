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
    public class MovieWriteRepository : WriteRepository<Movie>, IMovieWriteRepository
    {
        public MovieWriteRepository(MovieStoreAPIDbContext context) : base(context)
        {
        }
    }
}
