using Microsoft.EntityFrameworkCore;
using CafeBackend.Models;

namespace CafeBackend.Data
{
    public class CafeDbContext : DbContext
    {
        public CafeDbContext(DbContextOptions<CafeDbContext> options) : base(options)
        {
        }

        public DbSet<Table> Tables { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RawMaterial> RawMaterials { get; set; }
        public DbSet<ProductRecipe> ProductRecipes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProductRecipe tablosundaki kompozit anahtarı ayarlıyoruz
            modelBuilder.Entity<ProductRecipe>()
                .HasKey(pr => new { pr.ProductId, pr.RawMaterialId });

            base.OnModelCreating(modelBuilder);
        }
    }
}