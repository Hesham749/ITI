using MigrationDemo.Models;

namespace MigrationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppContext db = new();
            var l = db.ClsStudents.Where(e => true);
            ClsStudent res = db.ClsStudents.FirstOrDefault();
            db.ClsStudents.Add(new ClsStudent() { Id = 199, Name = "boha", DeptId = 1 });
            foreach (var item in db.ClsStudents)
            {
                Console.WriteLine(item.Id);
            }
            Console.WriteLine(res?.Id);
            ClsStudent res1 = db.ClsStudents.FirstOrDefault();
            Console.WriteLine(res1.Id);

            List<int> x = [10, 20, 30, 50];
            var res = x.SkipWhile(i => i < 20);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(res);
            //x.Add(1);
            //Console.WriteLine(x.FirstOrDefault());




        }
    }
}
