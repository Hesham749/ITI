using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DepartmentService : IDepartmentService
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
        public List<Department> GetAll(Func<Department, bool> Predicate = null)
        {
            Predicate ??= d => d.Status == true;
            return [.. _context.Departments.Where(Predicate)];
        }

        public Department GetById(int id)
            => _context.Departments.FirstOrDefault(d => d.Id == id);

        public bool IsUniqueID(int id)
            => !_context.Departments.Any(d => d.Id == id);

        public bool IsUniqueName(string Name, int id)
         => !_context.Departments.Any(d => d.Id != id && d.Name == Name);

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


        public bool Update(Department model)
        {
            throw new NotImplementedException();
        }
    }
}
