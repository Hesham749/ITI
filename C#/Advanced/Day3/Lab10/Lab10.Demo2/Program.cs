﻿namespace Lab10.Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5
            var e1 = new ClsEmp("Hesham");
            var e2 = new ClsEmp("Ali", 35);
            var e3 = new ClsEmp("Sayed", 40);
            List<ClsEmp> list = new List<ClsEmp>();
            list.Add(e1);
            list.Add(e2);
            list.Add(e3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(e2);
            Console.WriteLine("======================================================================================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //6
            Console.WriteLine("======================================================================================");
            ClsEmpList empList1 = new ClsEmpList();
            empList1.Add(e1);
            empList1.Add(e2);
            empList1.Add(e3);
            foreach (var item in empList1)
            {
                Console.WriteLine(item);
            }

        }
    }
}