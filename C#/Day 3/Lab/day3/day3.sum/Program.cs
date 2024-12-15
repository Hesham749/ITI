namespace day3.task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrSize;

            Console.WriteLine("enter array size");
            arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[5];
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"please enter arr[{i}] value : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // print
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"arr is : {arr[i]} \t");
            }
            //min

            int min = arr[0];
            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"max is {min}");
            //max
            int max = arr[0];
            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"max is {max}");
            //sum
            int sum = arr[0];
            for (int i = 0; i < arrSize; i++)
            {

                sum += arr[i];
            }
            Console.WriteLine($"sum = {sum}");
            //get index

            Console.WriteLine("please enter the number you want search for");
            int num = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] == num)
                {
                    found = true;
                    Console.WriteLine($"the index of {num} is : {i}");
                    break;
                }
            }
            if (!found)
                Console.WriteLine($"{num} not found");
        }


    }
}
