using Backend_Mini_App.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Backend_Mini_App.Repository
{
    public class CategoryRepository
    {
        private readonly BackendMiniAppDbContext _context;

        public CategoryRepository(BackendMiniAppDbContext context)
        {
            _context = context;
        }


        public async Task<bool> CreateProductAsync(Product product)
        {
            _context.Products.Add(product);


            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                return true;
            }

            return false;

        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Product> SearchProductAsync(string name)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Name == name);
        }
    }
}
