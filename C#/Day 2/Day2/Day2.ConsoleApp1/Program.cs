using System.Collections;

namespace Day2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object x = 3;
            Console.WriteLine(x.GetType());
            //x = "Hesham";
            //Console.WriteLine(x);
            ArrayList y = new ArrayList();
            y.Add(x);
            y.Add(2);
            //Console.WriteLine(y[0] + x);
            //int z = x;
        }
    }
}
