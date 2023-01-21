using System.Collections.Generic;

namespace ShopShowcase.Common
{
    public class RequestFactory : BaseFactory<BaseResponse>
    {
        public BaseResponse InitialiseEntity(string origin)
        {
            var properties = new List<KeyValuePair<string, object>>
            {
                new("Origin", origin)
            };
            return base.InitialiseEntity(properties);
        }
    }
}
