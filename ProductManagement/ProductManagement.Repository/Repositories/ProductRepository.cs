using Microsoft.EntityFrameworkCore;
using ProductManagement.Models.Entities;
using ProductManagement.Repository.Context;
using ProductManagement.Repository.Interfaces;

namespace ProductManagement.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductManagementDbContext _context;

        public ProductRepository(ProductManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductById(int id)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}