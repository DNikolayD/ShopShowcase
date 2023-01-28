using ShopShowcase.Common.Validators;
using System;
using System.Collections.Generic;

namespace ShopShowcase.Common.Factories
{
    public class BaseFactory<TValidator, TClass> where TClass : class where TValidator : BaseValidator<TClass>
    {
        public virtual TValidator Validator { get; set; } = Activator.CreateInstance<TValidator>();

        protected virtual TClass InitialiseEntity(List<KeyValuePair<string, object>> properties)
        {
            var type = typeof(TClass);
            var result = Activator.CreateInstance(type);
            properties.ForEach(x => result?.GetType().GetProperty(x.Key)?.SetValue(result, x.Value));
            return result as TClass;
        }
    }
}
