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
    public class CategoriesService : BaseService<CategoryFactory, CategoriesValidator, CategoriesDto, CategoriesDataEntity>, ICategoriesService<CategoryFactory, CategoriesValidator, CategoriesDto, CategoriesDataEntity>
    {
        protected CategoriesService(IBaseRepository<CategoriesDataEntity> repository, CategoryFactory factory, ILogger<BaseService<CategoryFactory, CategoriesValidator, CategoriesDto, CategoriesDataEntity>> logger) : base(repository, factory, logger)
        {
        }
    }
}
