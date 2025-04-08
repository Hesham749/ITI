using ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using var _context = new ApplicationDbContext();

            //var Tage = _context.PostTags.Include(pt => pt.Post.Title).First();
            //var x = _context.PostTags;
            //Console.WriteLine(Tage.Post.Title);
            Console.WriteLine( nameof(Post.PostTags));
            Test(3);
        }





        ///<summary> this is my test method </summary>
        ///<param name="x"   >fasfasdf</param>
        ///<returns>it will take int and it will print it.</returns>
        ///<exception cref="ArgumentNullException"></exception>
        static void Test(int x) => Console.WriteLine(x);
    }
}
