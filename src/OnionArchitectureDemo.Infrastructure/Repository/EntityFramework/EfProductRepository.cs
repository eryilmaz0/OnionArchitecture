using OnionArchitectureDemo.Application.Abstracts.Repository;
using OnionArchitectureDemo.Domain.Entity;
using OnionArchitectureDemo.Infrastructure.Context;

namespace OnionArchitectureDemo.Infrastructure.Repository.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public EfProductRepository(ApplicationDbContext context):base(context)
        {
            this._context = context;
        }
    }
}