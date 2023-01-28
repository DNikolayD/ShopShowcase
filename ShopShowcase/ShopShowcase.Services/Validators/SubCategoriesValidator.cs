using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopShowcase.Common.Validators;
using ShopShowcase.Services.Dtos.ProductDtos;
using static ShopShowcase.Common.Handlers.Specific.ErrorHandler;
using static ShopShowcase.Common.Constants.ValidationConstraints.SubCategoriesConstraints;
using static ShopShowcase.Common.Constants.ConditionTypes;


namespace ShopShowcase.Services.Validators
{
    public class SubCategoriesValidator : BaseValidator<SubCategoryDto>
    {
        public void SetRuleForName(SubCategoryDto subCategory)
        {
            switch (subCategory.CategoryName.Length)
            {
                case > NameMaxLength:
                {
                    var condition = CreateCondition(true, BeShorter, NameMaxLength.ToString());
                    var error = CreateError(condition, nameof(SubCategoryDto), "Name");
                    Errors.Add(error);
                    break;
                }
                case < NameMinLength:
                {
                    var condition = CreateCondition(true, BeLonger, NameMinLength.ToString());
                    var error = CreateError(condition, nameof(SubCategoryDto), "Name");
                    Errors.Add(error);
                    break;
                }
            }
        }
    }
}
