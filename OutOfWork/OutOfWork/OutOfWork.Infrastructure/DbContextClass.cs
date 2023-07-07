using Microsoft.EntityFrameworkCore;
using OutOfWork.Core.Models;

namespace OutOfWork.Infrastructure
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}