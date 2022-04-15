using MovieStoreAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Application.Repositories
{
    public interface IMovieWriteRepository :IWriteRepository<Movie>
    {
    }
}
