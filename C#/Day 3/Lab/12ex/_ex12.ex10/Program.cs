namespace _ex12.ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intitialAmount, numOfYears = 0;
            float interestRate, finalAmount;
            Console.Write("Enter initial amount : ");
            intitialAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter Final amount : ");
            finalAmount = float.Parse(Console.ReadLine());
            Console.Write("Enter interest Rate (percent per year) : ");
            interestRate = float.Parse(Console.ReadLine());
            while (finalAmount > intitialAmount)
            {
                finalAmount /= (interestRate / 100f) + 1;
                numOfYears++;
            }
            Console.WriteLine($"Number of years is {numOfYears} {(numOfYears > 1 ? "years" : "year")}");
        }
    }
}
