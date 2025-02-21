using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IStudentService : IService<Student>, IEmailCheck
    {
    }
}
