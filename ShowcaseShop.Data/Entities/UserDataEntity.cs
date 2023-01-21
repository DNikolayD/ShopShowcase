using Microsoft.AspNetCore.Identity;
using ShowcaseProjectShop.Data.Entities.ShoppingCartDataEntities;

namespace ShowcaseProjectShop.Data.Entities
{
    public class UserDataEntity : IdentityUser
    {

        public ShoppingCartDataEntity ShoppingCart { get; set; }

        public string ShoppingCartId { get; set; } = default!; 

        public string RoleId { get; set; } = default!;

        public IdentityRole Role { get; set; }
    }
}
