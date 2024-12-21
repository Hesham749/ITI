namespace lab5.demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new(1, "Hesham");
            Emp e2 = new(2, "ezzat", 24);
            Emp e3 = new(3, "lotfy", 23, 10000);
            e1.print();
            e2.print();
            e3.print();
        }
    }
}
