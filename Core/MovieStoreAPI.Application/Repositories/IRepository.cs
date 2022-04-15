using Microsoft.EntityFrameworkCore;
using MovieStoreAPI.Domain.Entities.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {

        DbSet<T> Table {get; }   


    }
}
