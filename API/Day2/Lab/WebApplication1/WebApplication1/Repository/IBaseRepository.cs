namespace WebApplication1.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
    }
}
