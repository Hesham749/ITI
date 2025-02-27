using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.UnitOfWorks
{
    public interface IUnitOfWork
    {
        public BaseRepository<Student> Students { get; }
        public BaseRepository<Department> Departments { get; }
    }
}
