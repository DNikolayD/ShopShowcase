using ShowcaseProjectShop.Data.Entities.BaseDataEntities;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseProjectShop.Data.Entities.ProductDataEntities
{
    public class CategoriesDataEntity : BaseDataEntity<string>
    {
        public CategoriesDataEntity()
        {
            SubCategories = new List<SubCategoryDataEntity>();
        }

        public string CategoryName { get; set; } = default!;

        public string CategoryDescription { get; set; } = default!;

        public List<SubCategoryDataEntity> SubCategories { get; set; }
    }
}
