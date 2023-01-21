﻿namespace ShowcaseProjectShop.Data.Entities.BaseDataEntities
{
    public interface IBaseDataEntity<TKey>
    {
        public TKey Id { get; set; }

        public bool IsDeletable { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsModified { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}
