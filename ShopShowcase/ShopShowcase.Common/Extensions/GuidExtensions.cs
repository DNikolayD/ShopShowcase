using ShopShowcase.Common.Handlers.Generics;
using System;

namespace ShopShowcase.Common.Extensions
{
    public static class GuidExtensions
    {
        public static TKey InitialiseId<TKey>(this Guid id)
        {
            return id.ToString().MapTo<TKey>();
        }
    }
}
