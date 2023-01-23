using ShopShowcase.Data.Entities.BaseEntities;
using ShopShowcase.Data.Entities.ProductEntities;
using System.Collections.Generic;

namespace ShopShowcase.Data.Entities.ShoppingCartEntities
{
    public class ShoppingCartDataEntity : BaseDataEntity<string>
    {
        public ShoppingCartDataEntity()
        {
            Products = new List<ProductDataEntity>();
        }

        public List<ProductDataEntity> Products { get; set; }
    }
}
