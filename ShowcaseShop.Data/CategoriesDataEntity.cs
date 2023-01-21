using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseShop.Data
{
    public class CategoriesDataEntity : BaseDataEntity<string>
    {
        public CategoriesDataEntity()
        {
            SubCategories = new List<ShowcaseProjectShop.Data.Entities.ProductDataEntities.SubCategoryDataEntity>();
        }

        public string CategoryName { get; set; } = default!;

        public string CategoryDescription { get; set; } = default!;

        public List<ShowcaseProjectShop.Data.Entities.ProductDataEntities.SubCategoryDataEntity> SubCategories { get; set; }
    }
}
