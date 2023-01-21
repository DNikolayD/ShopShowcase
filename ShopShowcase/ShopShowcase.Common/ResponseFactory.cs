using System;

namespace ShopShowcase.Common
{
    public abstract class ResponseFactory : BaseFactory<BaseResponse>
    {
        public static BaseResponse InitialiseEntity()
        {
            return Activator.CreateInstance<BaseResponse>();
        }
    }
}
