using Backend_Mini_App.Controllers;
using Backend_Mini_App.Interface;
using Backend_Mini_App.Models;
using Backend_Mini_App.Repository;

namespace Backend_Mini_App.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public async Task<bool> CreateProductAsync(Product product)
        {
            if(!ValidateProduct(product))
            {                 
                throw new ArgumentException("Invalid product data");
            }

            var result = await _categoryRepository.CreateProductAsync(product);

            return result;

        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0");
            }
             
            var result = await _categoryRepository.DeleteProductAsync(id);

            return result;

        }

        public Task<List<Product>> GetCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            if ( id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0");
            }

            var result = await _categoryRepository.GetProductByIdAsync(id);

            return result;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var result = await _categoryRepository.GetProductsAsync();
            return result.ToList();
        }

        public async Task<Product> SearchProductAsync(string name)
        {
            if ( string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Empty Search");
            }

            var result = await _categoryRepository.SearchProductAsync(name);
            return result;
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            if (!ValidateProduct(product))
            {
                throw new ArgumentException("Invalid product data");
            }
            
            var result = await _categoryRepository.UpdateProductAsync(product);

            return result;
        }

        private bool ValidateProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                return false;
            }
            if (product.Price <= 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(product.ImageUrl))
            {
                return false;
            }
            return true;
        }
    }
}
