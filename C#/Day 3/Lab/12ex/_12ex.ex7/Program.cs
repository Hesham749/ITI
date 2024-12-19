namespace _12ex.ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intitialAmount, numOfYears;
            float interestRate, moneyAfter;
            Console.Write("Enter initial amount : ");
            intitialAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter number of years : ");
            numOfYears = int.Parse(Console.ReadLine());
            Console.Write("Enter interest Rate (percent per year) : ");
            interestRate = float.Parse(Console.ReadLine());
            moneyAfter = intitialAmount;
            for (int i = 0; i < numOfYears; i++)
            {
                moneyAfter *= (interestRate / 100f) + 1;
                Console.WriteLine($"At the end of year {i + 1,2} , you will have {Math.Round(moneyAfter, 2)} dollars.");
            }
        }
    }
}
