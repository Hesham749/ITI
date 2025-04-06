using ConsoleApp1.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var _context = new ApplicationDbContext();

            var stock = _context.Posts.OrderByDescending(p => p.PostId);
            Test(3);
        }











        ///<summary> this is my test method </summary>
        ///<param name="x"   >fasfasdf</param>
        ///<returns>it will take int and it will print it.</returns>
        ///<exception cref="ArgumentNullException"></exception>
        static void Test(int x) => Console.WriteLine(x);
    }
}
