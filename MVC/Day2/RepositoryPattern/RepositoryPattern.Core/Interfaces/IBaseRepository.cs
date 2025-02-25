using System.Linq.Expressions;
using RepositoryPattern.Core.Consts;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        #region Get
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        #endregion
        #region Find
        T Find(Expression<Func<T, bool>> criteria, string[] includes = null);
        Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);
        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria = null, string[] includes = null,
            int? skip = null, int? take = null, Expression<Func<T, object>> orderBy = null,
            string orderDirection = OrderBy.Ascending
            );
        #endregion

        #region Add
        T Add(T entity);
        Task<T> AddAsync(T entity);
        IEnumerable<T> AddRange(IEnumerable<T> entities);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        #endregion
        #region Update
        T Update(T entity);
        #endregion
        #region Delete
        void Delete(object entity);
        void DeleteRange(IEnumerable<T> entities);

        #endregion
    }
}
