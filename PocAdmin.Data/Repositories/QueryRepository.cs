using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Interfaces;

namespace PocAdmin.Data.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public QueryRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<T> GetById(int id)
        {
            return _dbSet.Where(e => EF.Property<int>(e, "Id") == id);
        }
    }

}
