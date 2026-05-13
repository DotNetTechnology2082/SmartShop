using Microsoft.EntityFrameworkCore;
using SmartShop.Models;

namespace SmartShop.Datas
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options)
        {
        }
        // Define your DbSet properties here
        // Example:
        public DbSet<Product> Products { get; set; }
    }   
}
