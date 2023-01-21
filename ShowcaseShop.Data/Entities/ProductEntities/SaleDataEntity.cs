using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseShop.Data.Entities.ProductEntities
{
    public class SaleDataEntity : BaseDataEntity<string>
    {
        public int Percentage { get; set; }
    }
}
