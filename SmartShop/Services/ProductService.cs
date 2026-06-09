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

        public async Task Updateproduct(Product product)
        {
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
        }
        public async Task<Product?> GetProductById(int Id)
        {
            return await _db.Products.FindAsync(Id);
        }

        public async Task DeleteProduct(int Id)
        {
            var product = await _db.Products.FindAsync(Id);

            if(product != null)
            {
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
            }
        }
    }
}
