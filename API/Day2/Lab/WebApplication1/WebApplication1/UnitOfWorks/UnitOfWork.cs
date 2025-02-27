using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        BaseRepository<Student> _students;
        BaseRepository<Department> _departments;
        public UnitOfWork(ITIContext Db)
        {
            this.Db = Db;
        }

        ITIContext Db { get; }

        public BaseRepository<Student> Students
        {
            get
            {
                if (_students is null)
                    _students = new(Db);
                return _students;
            }
        }


        public BaseRepository<Department> Departments
        {
            get
            {
                if (_departments is null)
                    _departments = new(Db);
                return _departments;
            }
        }

    }
}
