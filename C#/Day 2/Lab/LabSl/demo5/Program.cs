namespace demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.Write("please enter num1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("please enter num2 : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("please enter op ( + , - , * or / ) :");
            op = char.Parse(Console.ReadLine());
            int result = 0;
            bool vaildOp = true;
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
                    Console.WriteLine("invalid operation");
                    vaildOp = false;
                    break;
            }
            if (vaildOp)
                Console.WriteLine($"{num1} {op} {num2} = {result}");
        }
    }
}
