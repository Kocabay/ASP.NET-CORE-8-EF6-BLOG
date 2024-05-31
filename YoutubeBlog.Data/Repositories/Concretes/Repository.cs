using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using YoutubeBlog.Core.Entities;
using YoutubeBlog.Data.Context;
using YoutubeBlog.Data.Repositories.Abstractions;


namespace YoutubeBlog.Data.Repositories.Concretes
{
    public class Repository<T> :IRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext dbContext;
        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private DbSet<T> Table { get => dbContext.Set<T>(); }

        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null, params Expression<Func<T, object>>[] inculedPropeties)
        {
            IQueryable<T> query = Table;
            if (predicate !=null)
                query=query.Where(predicate);
            if (inculedPropeties.Any())
                foreach (var item in inculedPropeties)
                    query = query.Include(item);

            return await query.ToListAsync();

        }
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] inculedPropeties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);
            if (inculedPropeties.Any())
                foreach (var item in inculedPropeties)
                    query = query.Include(item);

            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(()=>Table.Update(entity));
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
            return entity;
        }

        public async Task<bool> AnAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate);
        }
    }
}
