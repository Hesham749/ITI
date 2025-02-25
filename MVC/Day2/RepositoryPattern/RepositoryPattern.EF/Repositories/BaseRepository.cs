using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core.Interfaces;

namespace RepositoryPattern.EF.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }
        public T Add(T entity)
        {
            context.Add(entity);
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await context.AddAsync(entity);
            return entity;
        }

        public IEnumerable<T> AddRange(IEnumerable<T> entities)
        {
            context.AddRange(entities);
            return entities;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await context.AddRangeAsync(entities);
            return [.. entities];
        }

        public void Delete(object entity)
            => context.Remove(entity);



        public void DeleteRange(IEnumerable<T> entities)
            => context.RemoveRange(entities);


        public T Find(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria = null, string[] includes = null, int? skip = null, int? take = null, Expression<Func<T, object>> orderBy = null, string orderDirection = "ASC")
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
            => [.. context.Set<T>()];

        public async Task<IEnumerable<T>> GetAllAsync()
            => await context.Set<T>().ToListAsync();

        public T GetById(int id)
            => context.Set<T>().Find(id);


        public async Task<T> GetByIdAsync(int id)
            => await context.Set<T>().FindAsync(id);

        public T Update(T entity)
        {
            context.Update(entity);
            return entity;
        }

    }
}
