using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppContext db = new();
            db.Add(new Department { Dnum = 400 });
            db.SaveChanges();
        }
    }
}
