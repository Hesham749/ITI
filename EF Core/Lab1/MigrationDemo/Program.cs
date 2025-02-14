using Microsoft.EntityFrameworkCore;
using MigrationDemo.Data;
using MigrationDemo.Models;

namespace MigrationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ClsAppContext db = new())
            {
                ClsDepartment d1 = new() { DeptName = "SD" };
                db.ClsDepartments.Add(d1);
                db.ClsStudents.Add(new() { Id = 2, Name = "Ali", DeptId = 1 });
                db.SaveChanges();
                foreach (var item in db.ClsStudents.ToList())
                {
                    Console.WriteLine(item.Name);
                }
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException e) { }
            };



        }
    }
}
