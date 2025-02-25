using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBookRepository Books { get; }
        public IBaseRepository<Author> Author { get; }
        int Complete();
    }
}
