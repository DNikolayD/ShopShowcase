using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.ProductServices.Interfaces;

namespace ShopShowcase.Services.Services.ProductServices.Implementations
{
    public class SaleService : BaseService<SaleFactory, SaleDto>, ISaleService
    {
        public SaleService(IBaseRepository repository, SaleFactory factory, ILogger<BaseService<SaleFactory, SaleDto>> logger) : base(repository, factory, logger)
        {
        }
    }
}
