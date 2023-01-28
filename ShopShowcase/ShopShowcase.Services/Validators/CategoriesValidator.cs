using ShopShowcase.Common.Handlers.Specific;
using ShopShowcase.Common.Validators;
using ShopShowcase.Services.Dtos.ProductDtos;
using static ShopShowcase.Common.Constants.ConditionTypes;
using static ShopShowcase.Common.Constants.ValidationConstraints.CategoriesConstraints;

namespace ShopShowcase.Services.Validators
{
    public class CategoriesValidator : BaseValidator<CategoriesDto>
    {
        public void SetRuleForName(CategoriesDto categories)
        {
            switch (categories.CategoryName.Length)
            {
                case > NameMaxLength:
                    {
                        var condition = ErrorHandler.CreateCondition(true, BeShorter, NameMaxLength.ToString());
                        var error = ErrorHandler.CreateError(condition, nameof(CategoriesDto), "Name");
                        Errors.Add(error);
                        break;
                    }
                case < NameMinLength:
                    {
                        var condition = ErrorHandler.CreateCondition(true, BeLonger, NameMinLength.ToString());
                        var error = ErrorHandler.CreateError(condition, nameof(CategoriesDto), "Name");
                        Errors.Add(error);
                        break;
                    }
            }
        }

        public void SetRuleForDescription(CategoriesDto categories)
        {
            switch (categories.CategoryDescription.Length)
            {
                case > NameMaxLength:
                    {
                        var condition = ErrorHandler.CreateCondition(true, BeShorter, DescriptionMaxLength.ToString());
                        var error = ErrorHandler.CreateError(condition, nameof(CategoriesDto), "Description");
                        Errors.Add(error);
                        break;
                    }
                case < NameMinLength:
                    {
                        var condition = ErrorHandler.CreateCondition(true, BeLonger, DescriptionMinLength.ToString());
                        var error = ErrorHandler.CreateError(condition, nameof(CategoriesDto), "Description");
                        Errors.Add(error);
                        break;
                    }
            }
        }
    }
}
