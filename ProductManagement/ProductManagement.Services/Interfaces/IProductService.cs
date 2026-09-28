using ProductManagement.Models.DTOs;

namespace ProductManagement.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductDto>> GetAllProducts();

        Task<ProductDto?> GetProductById(int id);

        Task<ProductDto> AddProduct(CreateProductDto dto);

        Task<bool> UpdateProduct(int id, UpdateProductDto dto);

        Task<bool> DeleteProduct(int id);
    }
}