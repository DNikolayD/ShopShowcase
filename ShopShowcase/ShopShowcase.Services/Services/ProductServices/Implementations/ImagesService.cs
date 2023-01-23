using Microsoft.Extensions.Logging;
using ShopShowcase.Data.Repositories.BaseRepositories;
using ShopShowcase.Services.Dtos.ProductDtos;
using ShopShowcase.Services.Factories;
using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.ProductServices.Interfaces;

namespace ShopShowcase.Services.Services.ProductServices.Implementations
{
    public class ImagesService : BaseService<ImagesFactory, ImageDto>, IImagesService
    {
        public ImagesService(IBaseRepository repository, ImagesFactory factory, ILogger<BaseService<ImagesFactory, ImageDto>> logger) : base(repository, factory, logger)
        {
        }
    }
}
