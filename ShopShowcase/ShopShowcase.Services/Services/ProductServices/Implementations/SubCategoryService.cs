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
    public class SubCategoryService : BaseService<SubCategoryFactory, SubCategoriesValidator, SubCategoryDto, SubCategoryDataEntity>, ISubCategoryService<SubCategoryFactory, SubCategoriesValidator, SubCategoryDto, SubCategoryDataEntity>
    {
        protected SubCategoryService(IBaseRepository<SubCategoryDataEntity> repository, SubCategoryFactory factory, ILogger<BaseService<SubCategoryFactory, SubCategoriesValidator, SubCategoryDto, SubCategoryDataEntity>> logger) : base(repository, factory, logger)
        {
        }
    }
}
