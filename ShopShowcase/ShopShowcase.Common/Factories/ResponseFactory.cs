using ShopShowcase.Common.Responses;
using ShopShowcase.Common.Validators;
using System;

namespace ShopShowcase.Common.Factories
{
    public class ResponseFactory : BaseFactory<BaseResponseValidator, BaseResponse>
    {
        public static BaseResponse InitialiseEntity()
        {
            return Activator.CreateInstance<BaseResponse>();
        }
    }
}
