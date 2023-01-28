using ShopShowcase.Common.Requests;
using ShopShowcase.Common.Validators;
using System.Collections.Generic;

namespace ShopShowcase.Common.Factories
{
    public class RequestFactory : BaseFactory<BaseRequestValidator, BaseRequest>
    {
        public BaseRequest InitialiseEntity(string origin)
        {
            var properties = new List<KeyValuePair<string, object>>
            {
                new("Origin", origin)
            };
            return base.InitialiseEntity(properties);
        }
    }
}
