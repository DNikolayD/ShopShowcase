using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopShowcase.Common.Handlers.Generics
{
    public static class Extractor
    {
        private static readonly StringBuilder _stringBuilder = new();

        public static string Extract<T>(this T entity)
        {
            _stringBuilder.AppendLine($"{nameof(T)}:");
            if (typeof(T).IsGenericType && typeof(T) != typeof(ICollection<>))
                typeof(T).GetProperties().Where(x => x.CanRead).ToList().ForEach(x => x.GetValue(entity).Extract());
            else if (typeof(T) != typeof(ICollection<>))
                typeof(T).GetProperties().Where(x => x.CanRead && x.GetValue(entity) != null).ToList().ForEach(x =>
                    _stringBuilder.AppendLine($"{x.Name}: {x.GetValue(entity)}"));
            else
                entity!.MapTo<List<object>>().ForEach(x => x.Extract());

            return _stringBuilder.ToString();
        }
    }
}
