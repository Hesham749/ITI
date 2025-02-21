using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentService : IStudentService
    {
        readonly ITIZagContext _context;

        public StudentService(ITIZagContext context)
        {
            _context = context;
        }
        public bool Add(Student model)
        {
            _context.Students.Add(model);
            return Save();
        }

        public List<Student> GetAll(Func<Student, bool> Predicate = null)
        {
            Predicate ??= s => true;
            return [.. _context.Students.Include(s => s.Department).AsSplitQuery().Where(Predicate)];
        }

        public Student GetById(int id)
            => _context.Students.Include(s => s.Department).FirstOrDefault(s => s.Id == id);

        public bool IsUniqueMail(string mail, int id)
        {
            var Isunique = _context.Students.Any(s => s.Mail == mail && s.Id != id);
            return !Isunique;
        }

        public bool RemoveById(int id)
        {
            Student std = _context.Students.FirstOrDefault(s => s.Id == id);
            _context.Remove(std);
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

        public bool Update(Student model)
        {
            Student stdFromDB = _context.Students.Include(s => s.Department).AsNoTracking().FirstOrDefault(s => s.Id == model.Id);
            model.Password = stdFromDB.Password;
            _context.Update(model);
            return Save();
        }
    }
}
