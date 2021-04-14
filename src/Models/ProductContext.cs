using Microsoft.EntityFrameworkCore;

namespace ContosoCrafts.WebSite.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options) 
        { }
        public DbSet<Product> Products { get; set; }
    }
}
