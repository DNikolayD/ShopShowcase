using System.Collections.Generic;
using ShopShowcase.Data.Entities.BaseEntities;
using ShopShowcase.Data.Entities.ProductEntities;

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
