using OutOfWork.Core.Interfaces;
using OutOfWork.Core.Models;

namespace OutOfWork.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
    {
        public ProductRepository(DbContextClass context): base(context)
        {}
    }
}