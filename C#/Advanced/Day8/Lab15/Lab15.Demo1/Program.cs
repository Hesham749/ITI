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
        }
    }
}
