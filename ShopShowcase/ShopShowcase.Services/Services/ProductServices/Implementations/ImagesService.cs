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
    public class ImagesService : BaseService<ImagesFactory, ImagesValidator, ImageDto, ImageDataEntity>, IImagesService<ImagesFactory, ImagesValidator, ImageDto, ImageDataEntity>
    {
        protected ImagesService(IBaseRepository<ImageDataEntity> repository, ImagesFactory factory, ILogger<BaseService<ImagesFactory, ImagesValidator, ImageDto, ImageDataEntity>> logger) : base(repository, factory, logger)
        {
        }
    }
}
