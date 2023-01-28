using Microsoft.AspNetCore.Mvc;
using ShopShowcase.Data.Entities.ShoppingCartEntities;
using ShopShowcase.Services.Dtos.ShoppingCartDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.ShoppingCartServices;
using ShopShowcase.Services.Validators;
using static ShopShowcase.Common.Constants.ConsumeTypes;

namespace ShopShowcase.API.Controllers.ShoppingCartControllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Consumes(DefaultConsumeType)]
    public class ShoppingCartController : BaseController<IShoppingCartService<ShoppingCartFactory, ShoppingCartValidator, ShoppingCartDto, ShoppingCartDataEntity>, ShoppingCartValidator, ShoppingCartFactory, ShoppingCartDto, ShoppingCartDataEntity>
    {
        public ShoppingCartController(IShoppingCartService<ShoppingCartFactory, ShoppingCartValidator, ShoppingCartDto, ShoppingCartDataEntity> service) : base(service)
        {
        }
    }
}
