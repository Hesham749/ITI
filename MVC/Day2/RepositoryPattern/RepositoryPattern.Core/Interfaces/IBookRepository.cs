using RepositoryPattern.Core.Models;

namespace RepositoryPattern.Core.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        void Special();
    }
}
