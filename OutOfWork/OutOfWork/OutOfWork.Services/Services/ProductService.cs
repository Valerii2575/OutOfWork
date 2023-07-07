using OutOfWork.Core.Interfaces;
using OutOfWork.Core.Models;
using OutOfWork.Services.Interfaces;

namespace OutOfWork.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<bool> CreateProductAsync(ProductDetails product)
        {
            if(product == null)
                return false;

            await _unitOfWork.Products.AddAsync(product);
            return await _unitOfWork.SaveAsync() > 0;
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(productId);
            if(product == null)
            {
                return false;
            }

             _unitOfWork.Products.Delete(product);

             return await _unitOfWork.SaveAsync() > 0;
        }

        public async Task<IEnumerable<ProductDetails>> GetAllProductsAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products;
        }

        public async Task<ProductDetails> GetProductByIdAsync(int productId)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(productId);
            return product;
        }

        public async Task<bool> UpdateProductAsync(ProductDetails productDetail)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(productDetail.Id);

            if(product == null)
            {
                return false;
            }

             _unitOfWork.Products.Update(productDetail);
             return await _unitOfWork.SaveAsync() > 0;
        }
    }
}