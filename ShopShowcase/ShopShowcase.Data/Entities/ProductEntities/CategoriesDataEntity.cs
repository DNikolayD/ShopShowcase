using ShopShowcase.Data.Entities.BaseEntities;
using System.Collections.Generic;

namespace ShopShowcase.Data.Entities.ProductEntities
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
