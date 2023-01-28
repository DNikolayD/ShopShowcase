using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Entities.ProductEntities;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.ProductServices.Interfaces;
using ShopShowcase.Services.Validators;

namespace ShopShowcase.Services.Services.ProductServices.Implementations
{
    public class ProductService : BaseService<ProductFactory, ProductsValidator, ProductDto, ProductDataEntity>, IProductService<ProductFactory, ProductsValidator, ProductDto, ProductDataEntity>
    {
        protected ProductService(IBaseRepository<ProductDataEntity> repository, ProductFactory factory, ILogger<BaseService<ProductFactory, ProductsValidator, ProductDto, ProductDataEntity>> logger) : base(repository, factory, logger)
        {
        }
    }
}
