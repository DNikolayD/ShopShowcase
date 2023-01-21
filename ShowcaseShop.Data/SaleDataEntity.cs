using ShowcaseProjectShop.Data.Entities.BaseDataEntities;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseProjectShop.Data.Entities.ProductDataEntities
{
    public class SaleDataEntity : BaseDataEntity<string>
    {
        public int Percentage { get; set; }
    }
}
