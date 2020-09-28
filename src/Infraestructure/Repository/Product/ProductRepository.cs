using Domain.Repository.Product;
using Infraestructure.Persistence;
using Infraestructure.Repository.Base;

namespace Infraestructure.Repository.Product
{
    public class ProductRepository : Repository<Domain.Entities.Product, ApplicationDbContext>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
