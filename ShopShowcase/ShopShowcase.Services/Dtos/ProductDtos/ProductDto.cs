using ShopShowcase.Services.Dtos.Base;
using System.Collections.Generic;

namespace ShopShowcase.Services.Dtos.ProductDtos
{
    public class ProductDto : BaseDto<string>
    {
        private string _sizeAsString = default!;

        public ProductDto()
        {
            Images = new List<ImageDto>();
            Categories = new List<CategoriesDto>();
            Sale = new List<SaleDto>();
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

        public List<ImageDto> Images { get; set; }

        public List<CategoriesDto> Categories { get; set; }

        public List<SaleDto> Sale { get; set; }
    }
}
