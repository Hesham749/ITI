namespace day3.getOddEven
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
            string even = "", odd = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    if (i != arr.Length - 1)
                        even += arr[i] + " ";
                    else
                        even += arr[i];
                }
                else
                {
                    if (i != arr.Length - 1)
                        odd += arr[i] + " ";
                    else
                        odd += arr[i];
                }


            }
            Console.WriteLine($"even number are : {even}");
            Console.WriteLine($"odd number are : {odd}");
        }
    }
}
