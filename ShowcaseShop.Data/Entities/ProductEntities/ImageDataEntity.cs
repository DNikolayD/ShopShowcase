using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseShop.Data.Entities.ProductEntities
{
    public class ImageDataEntity : BaseDataEntity<string>
    {
        public string Name { get; set; } = default!; 

        public string Extenstion { get; set; } = default!;
    }
}
