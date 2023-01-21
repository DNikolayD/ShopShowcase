using ShopShowcase.Data.Entities.BaseEntities;

namespace ShopShowcase.Data.Entities.ProductEntities
{
    public class ImageDataEntity : BaseDataEntity<string>
    {
        public string Name { get; set; } = default!; 

        public string Extenstion { get; set; } = default!;
    }
}
