using ShopShowcase.Services.Dtos.Base;

namespace ShopShowcase.Services.Dtos.ProductDtos
{
    public class SubCategoryDto : BaseDto<string>
    {
        public string CategoryName { get; set; } = default!;

        public string CategoryDescription { get; set; } = default!;
    }
}
