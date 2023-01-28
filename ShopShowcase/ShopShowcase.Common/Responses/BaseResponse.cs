using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopShowcase.Common.Responses
{
    public class BaseResponse : Carrier
    {
        private List<string> _errors = new();

        public DateTime CreatedOn { get; }

        public static string Origin => default!;

        public bool IsSuccessful { get; private set; }

        public List<string> Errors
        {
            get => _errors;
            set
            {
                IsSuccessful = !value.Any();
                _errors = value;
            }
        }

        public BaseResponse()
        {
            CreatedOn = DateTime.UtcNow;
        }
    }
}
