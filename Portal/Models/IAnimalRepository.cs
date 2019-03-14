using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace Portal.Models
{
    public interface IAnimalRepository
    {
       IQueryable<Animal> Animals { get; }
    }
}
