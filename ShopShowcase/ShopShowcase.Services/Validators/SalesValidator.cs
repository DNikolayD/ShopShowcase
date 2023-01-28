using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopShowcase.Common.Validators;
using ShopShowcase.Services.Dtos.ProductDtos;
using static ShopShowcase.Common.Constants.ValidationConstraints.SalesConstraints;
using static ShopShowcase.Common.Constants.ConditionTypes;
using static ShopShowcase.Common.Handlers.Specific.ErrorHandler;

namespace ShopShowcase.Services.Validators
{
    public class SalesValidator : BaseValidator<SaleDto>
    {
        public void SetRuleForPercentage(SaleDto saleDto)
        {
            switch (saleDto.Percentage)
            {
                case > PercentageMaxValue:
                {
                    var condition = CreateCondition(false, BeShorter, PercentageMaxValue.ToString());
                    var error = CreateError(condition, nameof(SaleDto), "Percentage");
                    Errors.Add(error);
                    break;
                }
                case < PercentageMinValue:
                {
                    var condition = CreateCondition(false, BeLonger, PercentageMinValue.ToString());
                    var error = CreateError(condition, nameof(SaleDto), "Percentage");
                    Errors.Add(error);
                    break;
                }
            }
        }
    }
}
