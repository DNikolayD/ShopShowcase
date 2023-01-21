using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ShowcaseShop.Common
{
    public class BaseValidator
    {
        public IEnumerable<string> Errors { get; } = new HashSet<string>();

        public bool HasErrors => Errors.Any();


        public virtual void Validate(object obj)
        {
            var validators = Assembly.GetAssembly(typeof(BaseValidator))!
                .GetTypes()
                .Where(myType => myType is {IsClass: true} && myType.IsSubclassOf(typeof(BaseValidator)))
                .Select(type => (BaseValidator) Activator.CreateInstance(type)!)
                .Select(dummy => dummy)
                .ToList(); 
            validators.Sort();
            foreach (var type in validators.Select(validator => validator.GetType()))
            {
                type.GetMethods().Where(x => x.Name.Contains("SetRule")).ToList().ForEach(x => x.Invoke(this, new[] { obj }));
            }
        }

    }
}
