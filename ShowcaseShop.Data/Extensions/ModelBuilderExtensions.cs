﻿using System;
using Microsoft.EntityFrameworkCore;
using ShowcaseShop.Data.Entities.BaseEntities;

namespace ASP.NET_Skeleton.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SetKeys(this ModelBuilder modelBuilder, Type type)
        {
            if (type.IsEquivalentTo(typeof(BaseDataEntity<string>)))
            {
                var entity = modelBuilder.Entity<BaseDataEntity<string>>();

                entity.HasKey(e => e.Id);
            }
            else
            {
                var entity = modelBuilder.Entity<BaseDataEntity<int>>();

                entity.HasKey(e => e.Id);
            }
        }
    }
}
