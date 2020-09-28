using Domain.Repository.Brand;
using Infraestructure.Persistence;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository.Brand
{
    public class BrandRepository : Repository<Domain.Entities.Brand, ApplicationDbContext>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
