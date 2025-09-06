using AppStoreMobile.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppStoreMobile.DatabaseContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Products> ProductEntity { get; set; }
        public DbSet<Categories> CategoryEntity { get; set; }
        public DbSet<ProductAttributes> ProductAttributeEntity { get; set; }
    }
}