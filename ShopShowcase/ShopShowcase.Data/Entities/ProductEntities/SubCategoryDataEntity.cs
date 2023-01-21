using ShopShowcase.Data.Entities.BaseEntities;

namespace ShopShowcase.Data.Entities.ProductEntities
{
    public class SubCategoryDataEntity : BaseDataEntity<string>
    {
        public string CategoryName { get; set; } = default!;

        public string CategoryDescription { get; set; } = default!;
    }
}
