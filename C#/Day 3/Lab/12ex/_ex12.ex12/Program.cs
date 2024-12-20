namespace _ex12.ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fFraction, sFraction;
            float num1, num2, result;
            char op, newCalc;

            do
            {
                Console.Clear();
                Console.Write("please enter first fraction : ");
                fFraction = Console.ReadLine();
                Console.Write("please enter operation : ");
                op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("please enter second fraction : ");
                sFraction = Console.ReadLine();
                result = Calc(fFraction, sFraction, op);
                Console.WriteLine($"answer = {result}");
                Console.Write("Do you want to continue (y/n) ? ");
                newCalc = Console.ReadKey().KeyChar;
            } while (newCalc == 'y' || newCalc == 'Y');
        }

        private static float Calc(string f1, string f2, char op)
        {
            float result;
            switch (op)
            {
                case '+':
                    result = AdditionFraction(f1, f2);
                    break;
                case '-':
                    result = SubtractionFraction(f1, f2);
                    break;
                case '*':
                    result = MultiplicationFraction(f1, f2);
                    break;
                case '/':
                    result = DivisionFraction(f1, f2);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

        private static void GetFractionsResult(string f1, string f2, out float f1Result, out float f2Result)
        {
            float num1 = float.Parse(f1.Substring(0, f1.IndexOf('/')));
            float num2 = float.Parse(f1.Substring(f1.IndexOf('/') + 1));
            f1Result = num1 / num2;
            num1 = float.Parse(f2.Substring(0, f2.IndexOf('/')));
            num2 = float.Parse(f2.Substring(f2.IndexOf('/') + 1));
            f2Result = num1 / num2;
        }

        static float AdditionFraction(string f1, string f2)
        {
            float f1Result, f2Result;
            GetFractionsResult(f1, f2, out f1Result, out f2Result);
            return f1Result + f2Result;
        }



        static float SubtractionFraction(string f1, string f2)
        {
            float f1Result, f2Result;
            GetFractionsResult(f1, f2, out f1Result, out f2Result);
            return f1Result - f2Result;
        }

        static float MultiplicationFraction(string f1, string f2)
        {
            float f1Result, f2Result;
            GetFractionsResult(f1, f2, out f1Result, out f2Result);
            return f1Result * f2Result;
        }

        static float DivisionFraction(string f1, string f2)
        {
            float f1Result, f2Result;
            GetFractionsResult(f1, f2, out f1Result, out f2Result);
            return f1Result / f2Result;
        }
    }
}
