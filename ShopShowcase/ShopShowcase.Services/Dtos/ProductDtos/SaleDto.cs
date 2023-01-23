using ShopShowcase.Services.Dtos.Base;

namespace ShopShowcase.Services.Dtos.ProductDtos
{
    public class SaleDto : BaseDto<string>
    {
        public int Percentage { get; set; }
    }
}
