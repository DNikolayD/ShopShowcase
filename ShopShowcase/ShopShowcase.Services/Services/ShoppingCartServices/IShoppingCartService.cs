using ShopShowcase.Services.Services.BaseService;
using ShopShowcase.Services.Services.InjectionTypes;

namespace ShopShowcase.Services.Services.ShoppingCartServices
{
    public interface IShoppingCartService<TFactory, TValidator, TClass, TData> : IBaseService<TFactory, TValidator, TClass, TData>, IService
    {
    }
}
