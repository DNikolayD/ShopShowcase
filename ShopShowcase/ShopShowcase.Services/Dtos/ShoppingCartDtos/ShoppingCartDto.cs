using ShopShowcase.Services.Dtos.ProductDtos;
using System.Collections.Generic;

namespace ShopShowcase.Services.Dtos.ShoppingCartDtos
{
    public class ShoppingCartDto
    {
        public ShoppingCartDto()
        {
            Products = new List<ProductDto>();
        }

        public List<ProductDto> Products { get; set; }
    }
}
