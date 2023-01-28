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
    public class SaleController : BaseController<ISaleService<SaleFactory, SalesValidator, SaleDto, SaleDataEntity>, SalesValidator, SaleFactory, SaleDto, SaleDataEntity>
    {
        public SaleController(ISaleService<SaleFactory, SalesValidator, SaleDto, SaleDataEntity> service) : base(service)
        {
        }
    }
}
