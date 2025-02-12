using MigrationDemo.Data;

namespace MigrationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ClsAppContext db = new())
            {

                db.ClsDepartments.Add(new() { DeptName = "SD" });
                db.ClsStudents.Add(new() { Id = 2, Name = "Ali", DeptId = 1 });
                db.SaveChanges();
                foreach (var item in db.ClsStudents.ToList())
                {
                    Console.WriteLine(item.Name);
                }

            };



        }
    }
}
