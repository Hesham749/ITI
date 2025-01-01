namespace Lab12.Demo1
{


    internal class Program
    {

        static List<int> FindTarget(List<int> source, Predicate<int> myDel)
        {
            List<int> target = new List<int>();
            for (int i = 0; i < source.Count; i++)
            {
                if (myDel != null)
                {
                    if (myDel.Invoke(source[i]))
                        target.Add(source[i]);
                }
            }
            return target;
        }

        static bool EvenCondition(int x)
        {
            return (x % 2 == 0);
        }

        static void Main(string[] args)
        {
            List<int> source = [1, 2, 3, 4, 5, 6, 7];

            List<int> li = FindTarget(source, EvenCondition);
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===============================");
            // anonymous function
            li = FindTarget(source, x => { return x % 2 != 0; });
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===============================");
            //lambda expression
            li = FindTarget(source, x => x > 2 && x < 6);
            foreach (var item in li)
            {
                Console.WriteLine(item);
            }

        }
    }
}
