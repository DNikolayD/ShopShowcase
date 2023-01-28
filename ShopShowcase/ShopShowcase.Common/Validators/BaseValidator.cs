using System.Collections.Generic;
using System.Linq;
using static ShopShowcase.Common.Constants.ExecuteMethods;

namespace ShopShowcase.Common.Validators
{
    public class BaseValidator<TClass> where TClass : class
    {
        public List<string> Errors { get; } = new();

        public bool HasErrors => Errors.Any();


        public virtual void Validate(TClass obj)
        {
            GetType().GetMethods().Where(x => x.Name.Contains(ExecuteValidationMethodsRule)).ToList().ForEach(x => x.Invoke(this, new[] { obj }));

        }

    }
}
