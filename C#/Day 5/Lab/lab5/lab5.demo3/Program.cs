namespace lab5.demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmp e1 = new(1, "Hesham");
            clsEmp e2 = new(2, "ezzat", 24);
            clsEmp e3 = new(3, "lotfy", 23, 10000);
            e1.Print();
            e2.Print();
            e3.Print();
        }
    }
}
