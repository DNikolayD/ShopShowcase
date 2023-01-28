using ShopShowcase.Common.Requests;
using ShopShowcase.Common.Responses;
using ShopShowcase.Services.Services.InjectionTypes;
using System.Threading.Tasks;

namespace ShopShowcase.Services.Services.BaseService
{
    public interface IBaseService<TFactory, TValidator, TClass, TData> : IService
    {
        public Task<BaseResponse> AddAsync(BaseRequest request);

        public BaseResponse Remove(BaseRequest request);

        public BaseResponse Update(BaseRequest request);

        public BaseResponse Get(BaseRequest request);

        public BaseResponse GetMany(BaseRequest request);

        public BaseResponse GetSorted(BaseRequest request);

        public BaseResponse GetFiltered(BaseRequest request);
    }
}
