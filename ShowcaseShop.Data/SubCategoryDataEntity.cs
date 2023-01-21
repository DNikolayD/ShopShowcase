using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseShop.Data
{
    public class SubCategoryDataEntity : BaseDataEntity<string>
    {
        public string CategoryName { get; set; } = default!;

        public string CategoryDescription { get; set; } = default!;
    }
}
