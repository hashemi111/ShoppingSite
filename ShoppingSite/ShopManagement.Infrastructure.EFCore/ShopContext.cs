using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Infrastructure.EFCore.Mapping;
using System;

namespace ShopManagement.Infrastructure.EFCore
{
    public class ShopContext :DbContext
    {


        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ShopContext(DbContextOptions options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder); 
        }

    }
}
