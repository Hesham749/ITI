using System.Diagnostics;
using System.Text;

namespace day3.million
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            // 1
            int num = 1000000;
            int counter = 0;
            StringBuilder temp = new StringBuilder();
            sw.Start();
            for (int i = 0; i <= num; i++)
            {
                temp.Append(i.ToString());
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j].ToString() == "1")
                        counter++;
                }
                temp.Clear();
            }
            Console.WriteLine(counter);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Reset();
            //2
            sw.Start();
            int serarchNum = 1, start = 1, end = 1000000;

            counter = CountNumShownInRange(serarchNum, start, end);
            Console.WriteLine(counter);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            //3
            //sw.Start();
            //counter = 0;
            //for (int i = 1; i <= num; i *= 10)
            //{
            //    int divider = i * 10;
            //    counter += (num / divider) * i + Math.Min(Math.Max(num % divider - i + 1, 0), i);
            //}
            //Console.WriteLine(counter);
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
        }

        private static int CountNumShownInRange(int num, int start, int end)
        {
            int counter = 0;
            int remainder, mod;
            for (int i = start; i <= end; i++)
            {
                remainder = i;
                while (remainder > 0)
                {
                    mod = remainder % 10;
                    if (mod == 1)
                    {
                        counter++;
                    }
                    remainder = remainder / 10;
                }

            }

            return counter;
        }
    }
}

