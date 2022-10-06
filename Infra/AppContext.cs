using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StockControl.Entities;

namespace StockControl.Infra
{
    public class AppContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }  
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<StockModel> Stock { get; set; }

        public AppContext(DbContextOptions<AppContext> opt): base(opt) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductModel>()
                .Property(p => p.Name)
                .IsRequired();
            
            builder.Entity<ProductModel>()
                .Property(p => p.Price)
                .IsRequired();

            builder.Entity<CategoryModel>()
                .Property(c => c.CategoryName)
                .IsRequired();

            builder.Entity<StockModel>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Stocks)
                .IsRequired();
        }
    }
}
