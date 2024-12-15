namespace day3.sum
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
            int sum = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}
