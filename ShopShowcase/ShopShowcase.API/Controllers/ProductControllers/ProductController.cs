using Microsoft.AspNetCore.Mvc;
using ShopShowcase.Data.Entities.ProductEntities;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.ProductServices.Interfaces;
using ShopShowcase.Services.Validators;
using static ShopShowcase.Common.Constants.ConsumeTypes;

namespace ShopShowcase.API.Controllers.ProductControllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [Consumes(DefaultConsumeType)]
    public class ProductController : BaseController<IProductService<ProductFactory, ProductsValidator, ProductDto, ProductDataEntity>, ProductsValidator, ProductFactory, ProductDto, ProductDataEntity>
    {
        public ProductController(IProductService<ProductFactory, ProductsValidator, ProductDto, ProductDataEntity> service) : base(service)
        {
        }
    }
}
