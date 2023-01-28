using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Entities.ShoppingCartEntities;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ShoppingCartDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Validators;

namespace ShopShowcase.Services.Services.ShoppingCartServices
{
    public class ShoppingCartService : BaseService<ShoppingCartFactory, ShoppingCartValidator, ShoppingCartDto, ShoppingCartDataEntity>, IShoppingCartService<ShoppingCartFactory, ShoppingCartValidator, ShoppingCartDto, ShoppingCartDataEntity>
    {
        protected ShoppingCartService(IBaseRepository<ShoppingCartDataEntity> repository, ShoppingCartFactory factory, ILogger<BaseService<ShoppingCartFactory, ShoppingCartValidator, ShoppingCartDto, ShoppingCartDataEntity>> logger) : base(repository, factory, logger)
        {
        }
    }
}
