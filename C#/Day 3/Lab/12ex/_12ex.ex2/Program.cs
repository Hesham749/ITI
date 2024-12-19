namespace _12ex.ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type 1 to convert Fahrenheit to Celsius\n    2 to convert Celsius to Fahrenheit :");
            byte choise = byte.Parse(Console.ReadLine());
            if (choise == 1 || choise == 2)
            {
                float temp;
                string from = (choise == 1) ? "Fahrenheit" : "Celsius";
                string to = (choise == 1) ? "Celsius" : "Fahrenheit";

                Console.Write($"Enter temperature in {from} :");
                temp = float.Parse(Console.ReadLine());
                temp = (choise == 1) ? (temp - 32) * 5 / 9 : (temp * 9 / 5) + 32;

                Console.WriteLine($"in {to} that's {temp}");
            }
            else
                Console.WriteLine("Wrong choice");
        }
    }
}
