namespace day3.max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"please enter arr[{i}] value : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"max is {max}");

        }
    }
}
