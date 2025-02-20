namespace WebApplication1.Services
{
    public interface IService<T> where T : class
    {

        List<T> GetAll(Func<T, bool> Predicate);
        T GetById(int id);
        bool RemoveById(int id);
        bool Update(T model);
        bool Add(T model);
        bool Save();
    }
}
