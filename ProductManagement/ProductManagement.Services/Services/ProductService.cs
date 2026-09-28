using ProductManagement.Models.DTOs;
using ProductManagement.Models.Entities;
using ProductManagement.Repository.Interfaces;
using ProductManagement.Services.Interfaces;

namespace ProductManagement.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductDto>> GetAllProducts()
        {
            var products = await _repository.GetAllProducts();

            return products.Select(p => new ProductDto
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                Category = p.Category,
                Price = p.Price,
                StockQuantity = p.StockQuantity
            }).ToList();
        }

        public async Task<ProductDto?> GetProductById(int id)
        {
            var product = await _repository.GetProductById(id);

            if (product == null)
                return null;

            return new ProductDto
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Category = product.Category,
                Price = product.Price,
                StockQuantity = product.StockQuantity
            };
        }

        public async Task<ProductDto> AddProduct(CreateProductDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.ProductName))
                throw new ArgumentException("Product name cannot be empty.");

            var product = new Product
            {
                ProductName = dto.ProductName.Trim(),
                Category = dto.Category,
                Price = dto.Price,
                StockQuantity = dto.StockQuantity
            };

            var createdProduct = await _repository.AddProduct(product);

            return new ProductDto
            {
                ProductId = createdProduct.ProductId,
                ProductName = createdProduct.ProductName,
                Category = createdProduct.Category,
                Price = createdProduct.Price,
                StockQuantity = createdProduct.StockQuantity
            };
        }

        public async Task<bool> UpdateProduct(
            int id, UpdateProductDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.ProductName))
                throw new ArgumentException("Product name cannot be empty.");

            var product = await _repository.GetProductById(id);

            if (product == null)
                return false;

            product.ProductName = dto.ProductName.Trim();
            product.Category = dto.Category;
            product.Price = dto.Price;
            product.StockQuantity = dto.StockQuantity;

            await _repository.UpdateProduct(product);

            return true;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = await _repository.GetProductById(id);

            if (product == null)
                return false;

            await _repository.DeleteProduct(product);

            return true;
        }
    }
}