using WebApplication1.Models;

namespace WebApplication1.Models.Services
{
    public interface IDepartmentService : INameCheck, IIDCheck, IService<Department>
    {
    }
}
