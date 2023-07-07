using OutOfWork.Core.Models;

namespace OutOfWork.Services.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProductAsync(ProductDetails product);

        Task<IEnumerable<ProductDetails>> GetAllProductsAsync();

        Task<ProductDetails> GetProductByIdAsync(int productId);

        Task<bool> UpdateProductAsync(ProductDetails product);

        Task<bool> DeleteProductAsync(int productId);
    }
}