using OutOfWork.Core.Interfaces;

namespace OutOfWork.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _context;

        public IProductRepository Products { get; }

        public UnitOfWork(DbContextClass context, IProductRepository productRepository)
        {
            _context = context;
            Products = productRepository;
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing)
        {
            if(isDisposing)
            {
                _context.Dispose();
            }
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}