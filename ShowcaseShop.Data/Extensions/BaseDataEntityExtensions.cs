﻿using ASP.NET_Skeleton.Common;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ShowcaseShop.Data.Extensions
{
    public static class BaseDataEntityExtensions
    {
        public static void Configure<TKey>(this BaseDataEntity<TKey> baseDataEntity)
        {
            if (typeof(TKey) == typeof(string))
            {
                baseDataEntity.Id = new Guid().InitialiseId<TKey>();
            }

            if (baseDataEntity.IsDeletable)
            {
                baseDataEntity.IsDeleted ??= false;
                if (baseDataEntity.IsDeleted.Value)
                {
                    baseDataEntity.DeletedOn = DateTime.UtcNow;
                }
            }

            if (baseDataEntity.IsModified)
            {
                baseDataEntity.ModifiedOn = DateTime.UtcNow;
            }
        }
    }
}
