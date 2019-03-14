using Portal.Models;
using System.Collections.Generic;
using System.Linq;

namespace Portal.Models
{
    public class EFAnimalRepository : IAnimalRepository
    {
        private ApplicationDbContext context;
        public EFAnimalRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Animal> Animals => context.Animals;
    }
}