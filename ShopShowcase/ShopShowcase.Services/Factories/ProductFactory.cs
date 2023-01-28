using ShopShowcase.Common.Factories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Validators;

namespace ShopShowcase.Services.Factories
{
    public class ProductFactory : BaseFactory<ProductsValidator ,ProductDto>
    {
    }
}
