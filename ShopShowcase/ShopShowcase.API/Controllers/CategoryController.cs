using Microsoft.AspNetCore.Mvc;
using ShopShowcase.Common;
using ShopShowcase.Services.Services.ProductServices.Implementations;

namespace ShopShowcase.API.Controllers
{
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CategoriesService _categoriesService;

        public CategoryController(CategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        public IActionResult GetAllCategories()
        {
            return Ok(_categoriesService.Get(new BaseRequest()));
        }
    }
}
