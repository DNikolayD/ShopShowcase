using Microsoft.AspNetCore.Mvc;
using ShopShowcase.Data.Entities.ProductEntities;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.ProductServices.Interfaces;
using ShopShowcase.Services.Validators;
using static ShopShowcase.Common.Constants.ConsumeTypes;

namespace ShopShowcase.API.Controllers.ProductControllers
{
    [Consumes(DefaultConsumeType)]
    [ApiController]
    [Route("[controller]/[action]")]
    public class CategoryController : BaseController<
        ICategoriesService<CategoryFactory, CategoriesValidator, CategoriesDto, CategoriesDataEntity>,
        CategoriesValidator, CategoryFactory, CategoriesDto, CategoriesDataEntity>
    {
        public CategoryController(ICategoriesService<CategoryFactory, CategoriesValidator, CategoriesDto, CategoriesDataEntity> service) : base(service)
        {
        }
    }
}
