using ShopShowcase.Services.Dtos.Base;
using ShopShowcase.Services.Dtos.ShoppingCartDtos;

namespace ShopShowcase.Services.Dtos
{
    public class UserDto : BaseDto<string>
    {
        public string ShoppingCartId { get; set; }

        public ShoppingCartDto ShoppingCart { get; set; }

        public string RoleId { get; set; }
    }
}
