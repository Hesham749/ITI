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
            AssignArray(arrSize, arr);
            // print
            PrintArray(arrSize, arr);
            //min

            int min = GetMin(arrSize, arr);
            Console.WriteLine($"max is {min}");
            //max
            int max = GetMax(arrSize, arr);
            Console.WriteLine($"max is {max}");
            //sum
            int sum = GetSum(arrSize, arr);
            Console.WriteLine($"sum = {sum}");
            //get index

            Console.WriteLine("please enter the number you want search for");
            int num = int.Parse(Console.ReadLine());

            int index = GetIndex(arrSize, arr, num);

            if (index == -1)
                Console.WriteLine($"{num} not found");
            else
                Console.WriteLine($"the index of {num} is : {index}");

        }

        private static void AssignArray(int arrSize, int[] arr)
        {
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"please enter arr[{i}] value : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        private static int GetIndex(int arrSize, int[] arr, int num)
        {
            bool found = false;
            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] == num)
                {
                    found = true;
                    return i;
                }
            }
            return -1;
        }

        private static int GetSum(int arrSize, int[] arr)
        {
            int sum = arr[0];
            for (int i = 0; i < arrSize; i++)
            {

                sum += arr[i];
            }

            return sum;
        }

        private static int GetMax(int arrSize, int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }

        private static int GetMin(int arrSize, int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arrSize; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        private static void PrintArray(int arrSize, int[] arr)
        {
            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"arr is : {arr[i]} \t");
            }
        }
    }
}
