using ASP.NET_Skeleton.Data.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShowcaseProjectShop.Data.Entities;
using ShowcaseProjectShop.Data.Entities.ShoppingCartDataEntities;
using ShowcaseProjectShop.Data.Entities.ProductDataEntities;

namespace ShowcaseShop.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDataEntity>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ProductDataEntity> ProductDataEntities { get; set; }

        public DbSet<ImageDataEntity> ImageDataEntities { get; set; }

        public DbSet<SaleDataEntity> SaleDataEntities { get; set; }

        public DbSet<CategoriesDataEntity> CategoriesDataEntities { get; set; }

        public DbSet<SubCategoryDataEntity> SubCategoriesDataEntities { get; set; }

        public DbSet<ShoppingCartDataEntity> ShoppingCartDataEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var type in typeof(ApplicationDbContext).GetProperties().Where(p => p.Name.EndsWith("DataEntities")).Select(x => x.GetType()))
            {
                builder.SetKeys(type);
            }
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chinook");
            }
        }
    }
}