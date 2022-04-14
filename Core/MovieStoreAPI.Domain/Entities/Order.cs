using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStoreAPI.Domain.Entities.Cammon;

namespace MovieStoreAPI.Domain.Entities
{
    public class Order : BaseEntity
    {

        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Movie> Movies { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
