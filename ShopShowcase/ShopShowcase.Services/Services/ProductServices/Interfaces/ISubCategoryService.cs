using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.InjectionTypes;

namespace ShopShowcase.Services.Services.ProductServices.Interfaces
{
    public interface ISubCategoryService<TFactory, TValidator, TClass, TData> : IBaseService<TFactory, TValidator, TClass, TData>, IService
    {
    }
}
