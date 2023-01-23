using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.ProductServices.Interfaces;

namespace ShopShowcase.Services.Services.ProductServices.Implementations
{
    public class ProductService : BaseService<ProductFactory, ProductDto>, IProductService
    {
        public ProductService(IBaseRepository repository, ProductFactory factory, ILogger<BaseService<ProductFactory, ProductDto>> logger) : base(repository, factory, logger)
        {
        }
    }
}
