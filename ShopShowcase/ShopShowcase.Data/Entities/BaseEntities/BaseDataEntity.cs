using System;
using System.ComponentModel.DataAnnotations;
using ShopShowcase.Data.Extensions;

namespace ShopShowcase.Data.Entities.BaseEntities
{
    public class BaseDataEntity<TKey> : IBaseDataEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; } = default!;

        public bool IsDeletable { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsModified { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public BaseDataEntity()
        {
            this.Configure();
        }
    }
}
