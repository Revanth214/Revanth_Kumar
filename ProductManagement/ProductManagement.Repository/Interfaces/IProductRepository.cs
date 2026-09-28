using ProductManagement.Models.Entities;

namespace ProductManagement.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();

        Task<Product?> GetProductById(int id);

        Task<Product> AddProduct(Product product);

        Task UpdateProduct(Product product);

        Task DeleteProduct(Product product);
    }
}