using ShopShowcase.Data.Entities.BaseEntities;

namespace ShopShowcase.Data.Entities.ProductEntities
{
    public class SaleDataEntity : BaseDataEntity<string>
    {
        public int Percentage { get; set; }
    }
}
