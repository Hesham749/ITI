using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DepartmentService : IService<Department>
    {
        ITIZagContext _context;
        public DepartmentService(ITIZagContext context)
        {
            _context = context;
        }

        public bool Add(Department model)
        {
            _context.Departments.Add(model);
            return Save();
        }

        public List<Department> GetAll(Func<Department, bool> Predicate)
        {
            return [.. _context.Departments.Where(Predicate)];
        }

        public Department GetById(int id)
            => _context.Departments.FirstOrDefault(d => d.Id == id);

        public bool RemoveById(int id)
        {
            _context.Departments.FirstOrDefault(d => d.Id == id).Status = false;
            return Save();
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
