using Microsoft.EntityFrameworkCore;
using SmartShop.Datas;
using SmartShop.Models;

namespace SmartShop.Services
{
    public class ProductService
    {
        public readonly AppDbContext _db;

        public ProductService(AppDbContext db)
        {
            _db = db;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
        }
    }
}
