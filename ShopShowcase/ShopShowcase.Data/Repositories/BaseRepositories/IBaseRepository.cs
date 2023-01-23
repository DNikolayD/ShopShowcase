using ShopShowcase.Common;
using System.Threading.Tasks;

namespace ShopShowcase.Data.Repositories.BaseRepositories
{
    public interface IBaseRepository
    {
        BaseResponse GetMany(BaseRequest request);

        BaseResponse GetById(BaseRequest request);

        Task<BaseResponse> InsertAsync(BaseRequest request);

        BaseResponse Update(BaseRequest request);

        BaseResponse Delete(BaseRequest request);

        Task<BaseResponse> SaveAsync();

        BaseResponse Filter(BaseRequest request);

        BaseResponse Sort(BaseRequest request);
    }
}
