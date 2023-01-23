using ShopShowcase.Common;
using ShopShowcase.Services.Services.InjectionTypes;
using System.Threading.Tasks;

namespace ShopShowcase.Services.Services.BaseService
{
    public interface IBaseService : IScopedService
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
