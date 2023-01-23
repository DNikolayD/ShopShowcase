using System.Collections.Generic;

namespace ShopShowcase.Services.Dtos.ProductDtos
{
    public class CategoriesDto
    {
        public CategoriesDto()
        {
            SubCategories = new List<SubCategoryDto>();
        }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<SubCategoryDto> SubCategories { get; set; }
    }
}
