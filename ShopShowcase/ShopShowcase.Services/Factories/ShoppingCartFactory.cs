using ShopShowcase.Common.Factories;
using ShopShowcase.Services.Dtos.ShoppingCartDtos;
using ShopShowcase.Services.Validators;

namespace ShopShowcase.Services.Factories
{
    public class ShoppingCartFactory : BaseFactory<ShoppingCartValidator, ShoppingCartDto>
    {
    }
}
