using System.Collections;

namespace Day2.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            object x = 3;
            //Console.WriteLine(x.GetType());
            //x = "Hesham";
            int z = (int)x;

            //Console.WriteLine((int)x + z);
            ArrayList y = new ArrayList();
            y.Add(x);
            y.Add(2);
            int t = (int)y[0];
            //Console.WriteLine((int)y[0] + (int)x);
            //int z = x;
            string v = "Hesham";
            switch (v)
            {
                case "Hesham":
                    break;
            }
            int xx = 20;
            ref readonly int s = ref t;
            s = ref xx;
            Console.WriteLine(s);
        }
    }
}
