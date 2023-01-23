using Microsoft.AspNetCore.Identity;
using ShopShowcase.Data.Entities.BaseEntities;
using ShopShowcase.Data.Entities.ShoppingCartEntities;
using System;

namespace ShopShowcase.Data.Entities
{
    public class UserDataEntity : IdentityUser, IBaseDataEntity<string>
    {
        public bool IsDeletable { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsModified { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public string RoleId { get; set; }

        public IdentityRole Role { get; set; }

        public string ShoppingCartId { get; set; }

        public ShoppingCartDataEntity ShoppingCartDataEntity { get; set; }
    }
}
