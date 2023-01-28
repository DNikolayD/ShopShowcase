using ShopShowcase.Common.Requests;
using ShopShowcase.Common.Responses;
using ShopShowcase.Services.Services.InjectionTypes;
using System.Threading.Tasks;

namespace ShopShowcase.Services.Services.UserServices
{
    public interface IUserService : IService
    {
        public Task<BaseResponse> AddAsync(BaseRequest request);

        public Task<BaseResponse> RemoveAsync(BaseRequest request);

        public Task<BaseResponse> UpdateAsync(BaseRequest request);

        public Task<BaseResponse> GetAsync(BaseRequest request);

    }
}
