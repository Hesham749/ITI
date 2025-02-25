using RepositoryPattern.Core.Interfaces;
using RepositoryPattern.Core.Models;

namespace RepositoryPattern.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;
        public IBookRepository Books { get; init; }
        public IBaseRepository<Author> Author { get; init; }

        public UnitOfWork(ApplicationDbContext context,
            IBookRepository Books, IBaseRepository<Author> Author)
        {
            this.context = context;
            this.Books = Books;
            this.Author = Author;
        }


        public int Complete()
            => context.SaveChanges();

        public void Dispose()
             => context.Dispose();

    }
}
