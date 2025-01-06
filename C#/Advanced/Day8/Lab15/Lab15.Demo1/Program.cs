using Lab15.Demo2;

namespace Lab15.Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsEmp emp2 = new ClsEmp(1, "sayed");
            ClsEmp emp1 = new ClsEmp(2, "hesham");
            List<ClsEmp> empList = new List<ClsEmp>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Sort(emp1);
            foreach (var item in empList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============================================================================");
            //sort by id
            empList.Sort((x, y) => x.Id.CompareTo(y.Id));
            foreach (var item in empList)
            {
                Console.WriteLine(item);
            }

            try
            {
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(2 / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            ClsTest t1 = ClsTest.CreateObject(2, 5);
            ClsTest t2 = ClsTest.CreateObject(4, 10);
            Console.WriteLine(t2.X);

        }
    }
}
