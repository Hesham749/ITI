namespace _ex12.ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fFraction, sFraction;
            string result;
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
                if (Calc(fFraction, sFraction, op, out result))
                    Console.WriteLine($"Answer = {result}");
                else
                    Console.WriteLine("You have inserted wrong input");
                Console.Write("Do you want to continue (y/n) ? ");
                newCalc = Console.ReadKey().KeyChar;
            } while (newCalc == 'y' || newCalc == 'Y');
        }

        private static bool Calc(string f1, string f2, char op, out string result)
        {
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
                    result = "";
                    return false;
            }

            return true;
        }

        private static void GetFractionsValues(string f1, string f2, out float f1Num1, out float f1Num2, out float f2Num1, out float f2Num2)
        {
            f1Num1 = float.Parse(f1.Substring(0, f1.IndexOf('/')));
            f1Num2 = float.Parse(f1.Substring(f1.IndexOf('/') + 1));
            f2Num1 = float.Parse(f2.Substring(0, f2.IndexOf('/')));
            f2Num2 = float.Parse(f2.Substring(f2.IndexOf('/') + 1));
        }

        static string AdditionFraction(in string f1, in string f2)
        {

            GetFractionsValues(f1, f2, out float f1Num1, out float f1Num2, out float f2Num1, out float f2Num2);
            return $"({f1Num1}*{f2Num2} + {f1Num2}*{f2Num1}) / ({f1Num2}*{f2Num2})";
        }



        static string SubtractionFraction(in string f1, in string f2)
        {

            GetFractionsValues(f1, f2, out float f1Num1, out float f1Num2, out float f2Num1, out float f2Num2);
            return $"({f1Num1}*{f2Num2} - {f1Num2}*{f2Num1}) / ({f1Num2}*{f2Num2})";
        }

        static string MultiplicationFraction(in string f1, in string f2)
        {

            GetFractionsValues(f1, f2, out float f1Num1, out float f1Num2, out float f2Num1, out float f2Num2);
            return $"({f1Num1}*{f2Num1}) / ({f1Num2}*{f2Num2})";
        }

        static string DivisionFraction(in string f1, in string f2)
        {

            GetFractionsValues(f1, f2, out float f1Num1, out float f1Num2, out float f2Num1, out float f2Num2);
            return $"({f1Num1}*{f2Num2}) / ({f1Num2}*{f2Num1})";
        }
    }
}
