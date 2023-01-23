using ShopShowcase.Data.Entities.BaseEntities;
using System.Collections.Generic;

namespace ShopShowcase.Data.Entities.ProductEntities
{
    public class ProductDataEntity : BaseDataEntity<string>
    {

        private string _sizeAsString = default!;

        public ProductDataEntity()
        {
            Images = new List<ImageDataEntity>();
            Sales = new List<SaleDataEntity>();
            Categories = new List<CategoriesDataEntity>();
        }

        public string ProductName { get; set; } = default!;

        public string Description { get; set; } = default!;

        public decimal Price { get; set; }

        public bool IsInStock { get; set; }

        public int NumberInStock { get; set; }

        public string SizeAsString
        {
            get => _sizeAsString;
            set
            {
                if (!string.IsNullOrWhiteSpace(_sizeAsString))
                {
                    value = _sizeAsString;
                }
                else
                {
                    if (SizeAsInt.HasValue)
                    {
                        value = SizeAsInt.Value.ToString();
                    }
                    else
                    {
                        value = default!;
                    }
                }
                _sizeAsString = value;
            }
        }

        public int? SizeAsInt { get; set; }

        public string Color { get; set; } = default!;

        public List<ImageDataEntity> Images { get; set; }

        public List<SaleDataEntity> Sales { get; set; }

        public List<CategoriesDataEntity> Categories { get; set; }
    }
}
