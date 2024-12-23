namespace Lab6.Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmp e1 = new clsEmp("Hesham", 90);

            e1.Print();
            if (!e1.SetName(""))
                Console.WriteLine("name not changed");
            Console.WriteLine(e1.Name);
            e1.Print();
            clsStudent s1 = new clsStudent("lotfy", 14);
            s1.Print();
            Console.WriteLine(clsStudent.StudentCounter);
        }
    }
}
