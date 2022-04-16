using MovieStoreAPI.Domain.Entities.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreAPI.Domain.Entities
{
    public class Movie : BaseEntity
    {
        public string MovieName { get; set; }
        public float Duration { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
