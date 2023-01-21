using System;
using System.Linq;

namespace ShopShowcase.Common
{
    public static class TypeExtensions
    {
        public static bool CheckForGenerics(this Type type)
        {
            return type.GetProperties().Any(x => x.GetType().IsGenericType);
        }

        public static bool CheckForNonGenerics(this Type type)
        {
            return type.GetProperties().Any(x => !x.GetType().IsGenericType);
        }
    }
}
