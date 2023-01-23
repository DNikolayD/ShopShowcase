using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.ProductServices.Interfaces;

namespace ShopShowcase.Services.Services.ProductServices.Implementations
{
    public class CategoriesService : BaseService<CategoryFactory, CategoriesDto>, ICategoriesService
    {
        public CategoriesService(IBaseRepository repository, CategoryFactory factory, ILogger<BaseService<CategoryFactory, CategoriesDto>> logger) :
            base(repository, factory, logger)
        {
        }

    }
}
