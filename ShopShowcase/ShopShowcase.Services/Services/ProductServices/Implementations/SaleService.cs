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
    public class SaleService : BaseService<SaleFactory, SalesValidator, SaleDto, SaleDataEntity>, ISaleService<SaleFactory, SalesValidator, SaleDto, SaleDataEntity>
    {
        protected SaleService(IBaseRepository<SaleDataEntity> repository, SaleFactory factory, ILogger<BaseService<SaleFactory, SalesValidator, SaleDto, SaleDataEntity>> logger) : base(repository, factory, logger)
        {
        }
    }
}
