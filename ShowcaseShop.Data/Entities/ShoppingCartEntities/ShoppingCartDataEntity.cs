using ShowcaseProjectShop.Data.Entities.BaseDataEntities;
using ShowcaseProjectShop.Data.Entities.ProductDataEntities;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseProjectShop.Data.Entities.ShoppingCartDataEntities
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
