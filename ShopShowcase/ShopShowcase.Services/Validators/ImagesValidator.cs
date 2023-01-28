using ShopShowcase.Common;
using ShopShowcase.Common.Handlers.Specific;
using ShopShowcase.Common.Validators;
using ShopShowcase.Services.Dtos.ProductDtos;
using System;
using System.Linq;
using System.Text;
using static ShopShowcase.Common.Constants.ConditionTypes;
using static ShopShowcase.Common.Constants.ValidationConstraints.ImageConstraints;

namespace ShopShowcase.Services.Validators
{
    public class ImagesValidator : BaseValidator<ImageDto>
    {
        public void SetRuleForName(ImageDto imageDto)
        {
            switch (imageDto.Name.Length)
            {
                case > NameMaxLength:
                    {
                        var condition = ErrorHandler.CreateCondition(true, BeShorter, NameMaxLength.ToString());
                        var error = ErrorHandler.CreateError(condition, nameof(ImageDto), "Name");
                        Errors.Add(error);
                        break;
                    }
                case < NameMinLength:
                    {
                        var condition = ErrorHandler.CreateCondition(true, BeLonger, NameMinLength.ToString());
                        var error = ErrorHandler.CreateError(condition, nameof(ImageDto), "Name");
                        Errors.Add(error);
                        break;
                    }
            }
        }

        public void SetRuleForExtenstion(ImageDto imageDto)
        {
            if (!Enum.GetNames<ImageTypes>().Contains(imageDto.Extenstion))
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.AppendLine("This extenstion type is not allowed the allowed once are: ");
                foreach (var imageType in Enum.GetNames<ImageTypes>())
                {
                    stringBuilder.Append($"{imageType}, ");
                }

                var error = stringBuilder.Remove(stringBuilder.Length - 2, 2).ToString();
                Errors.Add(error);
            }
        }
    }
}
