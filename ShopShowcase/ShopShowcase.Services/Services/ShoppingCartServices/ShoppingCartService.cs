using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ShoppingCartDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;

namespace ShopShowcase.Services.Services.ShoppingCartServices
{
    public class ShoppingCartService : BaseService<ShoppingCartFactory, ShoppingCartDto>
    {
        public ShoppingCartService(IBaseRepository repository, ShoppingCartFactory factory, ILogger<BaseService<ShoppingCartFactory, ShoppingCartDto>> logger) : base(repository, factory, logger)
        {
        }
    }
}
