using ShowcaseProjectShop.Data.Entities.BaseDataEntities;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseProjectShop.Data.Entities.ProductDataEntities
{
    public class SubCategoryDataEntity : BaseDataEntity<string>
    {
        public string CategoryName { get; set; } = default!;

        public string CategoryDescription { get; set; } = default!;
    }
}
