namespace _12ex.ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, result;
            char op, newCalc;

            do
            {
                Console.Clear();
                Console.Write("please enter first number : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("please enter operation : ");
                op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("please enter second number : ");
                num2 = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.WriteLine($"answer = {result}");
                Console.Write("Do another (y/n) ? ");
                newCalc = Console.ReadKey().KeyChar;
            } while (newCalc == 'y' || newCalc == 'Y');
        }
    }
}
