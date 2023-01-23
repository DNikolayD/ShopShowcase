using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopShowcase.Data.Entities;
using ShopShowcase.Data.Entities.ProductEntities;
using ShopShowcase.Data.Entities.ShoppingCartEntities;
using ShopShowcase.Data.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace ShopShowcase.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDataEntity>
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }

        HashSet<CategoriesDataEntity> CategoriesDataEntities { get; set; }

        HashSet<ImageDataEntity> ImageDataEntities { get; set; }

        HashSet<ProductDataEntity> ProductDataEntities { get; set; }

        HashSet<SaleDataEntity> SaleDataEntities { get; set; }

        HashSet<SubCategoryDataEntity> SubCategoryDataEntities { get; set; }

        HashSet<ShoppingCartDataEntity> ShoppingCartDataEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var type in typeof(ApplicationDbContext).GetProperties().Where(p => p.Name.EndsWith("DataEntities")).Select(x => x.GetType()))
            {
                builder.SetKeys(type);
            }
            base.OnModelCreating(builder);
        }
    }
}