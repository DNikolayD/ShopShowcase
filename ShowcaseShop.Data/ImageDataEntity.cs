using ShowcaseProjectShop.Data.Entities.BaseDataEntities;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseProjectShop.Data.Entities.ProductDataEntities
{
    public class ImageDataEntity : BaseDataEntity<string>
    {
        public string Name { get; set; } = default!; 

        public string Extenstion { get; set; } = default!;
    }
}
