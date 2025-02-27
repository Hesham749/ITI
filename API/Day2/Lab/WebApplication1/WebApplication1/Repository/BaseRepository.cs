
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public BaseRepository(ITIContext db)
        {
            Db = db;
        }
        public ITIContext Db { get; }


        public List<T> GetAll()
            => Db.Set<T>().ToList();

        public T GetById(int id)
            => Db.Set<T>().Find(id);
    }
}
