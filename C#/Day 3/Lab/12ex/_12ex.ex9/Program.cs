namespace _12ex.ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char calcAgain;
            int numOfChairs, numOfGuests, numOfArrangement, factorialOfChairs, factorialOfGuests;

            do
            {
                Console.Clear();
                Console.Write("Enter the number of guests : ");
                numOfGuests = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of Chairs : ");
                numOfChairs = int.Parse(Console.ReadLine());

                factorialOfGuests = GetFactorial(numOfGuests);
                factorialOfChairs = GetFactorial(numOfGuests - numOfChairs);
                numOfArrangement = factorialOfGuests / factorialOfChairs;
                Console.WriteLine($"Num of arrangement = {numOfArrangement}");
                Console.Write("Do you want to continue (y/n) : ");
                calcAgain = Console.ReadKey().KeyChar;
            } while (calcAgain == 'y' || calcAgain == 'Y');
        }
        static int GetFactorial(int num)
        {
            int factorial = num;
            for (int i = 2; i < num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
