using Backend_Mini_App.Controllers;
using Backend_Mini_App.Models;

namespace Backend_Mini_App.Interface
{
    public interface ICategoryService
    {
        Task<List<Product>> GetCategoriesAsync();

        Task<List<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int Id);

        Task<bool> CreateProductAsync(Product product);

        Task<bool> UpdateProductAsync(Product product);

        Task<bool> DeleteProductAsync(int id);
        Task<Product> SearchProductAsync(string name);
    }
}
