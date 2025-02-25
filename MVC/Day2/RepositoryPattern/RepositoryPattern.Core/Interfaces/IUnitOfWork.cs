using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBaseRepository<Book> Books { get; }
        public IBaseRepository<Author> Author { get; }
        int Complete();
    }
}
