using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Entities.ProductEntities;
using ShopShowcase.Data.Repositories.BaseRepositories;

namespace ShopShowcase.Data.Repositories.ProductRepositories
{
    public class ProductRepository : BaseRepository<ProductDataEntity>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext, ILogger<BaseRepository<ProductDataEntity>> logger) : 
            base(applicationDbContext, logger)
        {
        }
    }
}
