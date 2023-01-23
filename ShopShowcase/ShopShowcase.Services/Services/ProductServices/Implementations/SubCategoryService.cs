using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.ProductServices.Interfaces;

namespace ShopShowcase.Services.Services.ProductServices.Implementations
{
    public class SubCategoryService : BaseService<SubCategoryFactory, SubCategoryDto>, ISubCategoryService
    {
        public SubCategoryService(IBaseRepository repository, SubCategoryFactory factory, ILogger<BaseService<SubCategoryFactory, SubCategoryDto>> logger) : base(repository, factory, logger)
        {
        }
    }
}
