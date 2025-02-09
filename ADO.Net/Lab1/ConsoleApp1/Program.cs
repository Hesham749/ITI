using BusinessLayer;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsDepartmentList list = ClsDepartmentManger.GetAll();
            foreach (var department in list)
            {
                Console.WriteLine(department);
            }

            //Console.WriteLine(ClsDepartmentManger.GetById(10));
            //Console.WriteLine(ClsDepartmentManger.UpdateDept(50, desc: "updated", MngrHireDate: DateOnly.FromDateTime(DateTime.Now)));
            //Console.WriteLine(ClsDepartmentManger.UpdateDept(50, desc: "updated", MngrHireDate: DateOnly.FromDateTime(DateTime.Now)));

            // Console.WriteLine(ClsDepartmentManger.InsertDept(80, "HH", "inserted", "zag"));
            Console.ReadKey();
        }
    }
}
