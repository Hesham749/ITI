using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDepartmentService : INameCheck, IIDCheck, IService<Department>
    {
    }
}
