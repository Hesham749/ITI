using MyLib;
namespace Lab11.Demo1
{

    delegate T MyDel<T>(T x, T y);
    delegate void MyDel1();
    enum EnGender : byte
    {
        Male, Female
    }

    internal class Program
    {

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Print()
        {
            Console.WriteLine("print");
        }
        static void Print1()
        {
            Console.WriteLine("print1");
        }

        static void Main(string[] args)
        {
            //1

            MyDel<int> d1 = Add;
            Console.WriteLine(d1(3, 4));
            Console.WriteLine(d1.Invoke(2, 3));
            Console.WriteLine("================================================================");
            MyDel1 d2 = Print;
            d2 += Print1;
            d2 -= Print;
            d2();

            //2
            Console.WriteLine("================================================================");
            ClsComplex x1 = new ClsComplex();
            //  x1.Real  //inaccessible
            //  x1.Img  //inaccessible

            //3 
            EnGender g1 = EnGender.Male;
            Console.WriteLine(g1);
            g1 = EnGender.Female;
            Console.WriteLine(g1);
            g1 = (EnGender)Enum.Parse(typeof(EnGender), "Male");
            Console.WriteLine(g1);
            Console.WriteLine((int)g1);


        }
    }
}
