using ShopShowcase.Common.Handlers.Specific;
using ShopShowcase.Common.Validators;
using ShopShowcase.Services.Dtos.ProductDtos;
using static ShopShowcase.Common.Constants.ConditionTypes;
using static ShopShowcase.Common.Constants.ValidationConstraints.ProductsConstraints;
using static ShopShowcase.Common.Handlers.Specific.ErrorHandler;

namespace ShopShowcase.Services.Validators
{
    public class ProductsValidator : BaseValidator<ProductDto>
    {
        public void SetRuleForName(ProductDto productDto)
        {
            switch (productDto.ProductName.Length)
            {
                case > NameMaxLength:
                    {
                        var condition = CreateCondition(true, BeShorter, NameMaxLength.ToString());
                        var error = CreateError(condition, nameof(ProductDto), "Name");
                        Errors.Add(error);
                        break;
                    }
                case < NameMinLength:
                    {
                        var condition = CreateCondition(true, BeLonger, NameMinLength.ToString());
                        var error = CreateError(condition, nameof(ProductDto), "Name");
                        Errors.Add(error);
                        break;
                    }
            }
        }

        public void SetRuleForDescription(ProductDto productDto)
        {
            switch (productDto.Description.Length)
            {
                case > DescriptionMaxLength:
                    {
                        var condition = CreateCondition(true, BeShorter, DescriptionMaxLength.ToString());
                        var error = CreateError(condition, nameof(ProductDto), "Description");
                        Errors.Add(error);
                        break;
                    }
                case < DescriptionMinLength:
                    {
                        var condition = CreateCondition(true, BeLonger, DescriptionMinLength.ToString());
                        var error = CreateError(condition, nameof(ProductDto), "Description");
                        Errors.Add(error);
                        break;
                    }
            }
        }

        public void SetRuleForPrice(ProductDto productDto)
        {
            if (productDto.Price < PriceMinValue)
            {
                var condition = CreateCondition(false, BeBigger, PriceMinValue.ToString());
                var error = CreateError(condition, nameof(ProductDto), "Price");
                Errors.Add(error);
            }
        }

        public void SetRuleForNumberInStock(ProductDto productDto)
        {
            if (productDto.NumberInStock < NumberInStockMinValue)
            {
                var condition = CreateCondition(false, BeBigger, NumberInStockMinValue.ToString());
                var error = CreateError(condition, nameof(ProductDto), "NumberInStock");
                Errors.Add(error);
            }
        }

        public void SetRuleForColor(ProductDto productDto)
        {
            switch (productDto.Color.Length)
            {
                case > ColorMaxLength:
                {
                    var condition = CreateCondition(true, BeShorter, ColorMaxLength.ToString());
                    var error = CreateError(condition, nameof(ProductDto), "Color");
                    Errors.Add(error);
                    break;
                }
                case < ColorMinLength:
                {
                    var condition = CreateCondition(true, BeLonger, ColorMinLength.ToString());
                    var error = CreateError(condition, nameof(ProductDto), "Color");
                    Errors.Add(error);
                    break;
                }
            }
        }
    }
}
