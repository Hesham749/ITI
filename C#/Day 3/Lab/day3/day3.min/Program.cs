namespace day3.min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //get data
            int[,] stdGrade = new int[2, 4] { { 10, 20, 30, 90 }, { 50, 60, 70, 80 } };
            //for (int i = 0; i < stdGrade.GetLength(0); i++)
            //{
            //    Console.WriteLine($"student num {1} grades");
            //    for (int j = 0; j < stdGrade.GetLength(1); j++)
            //    {
            //        Console.Write($"grade num {i} :");
            //        stdGrade[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //print
            PrintMatrix(stdGrade);

            //avg grade
            int gradeCount = stdGrade.GetLength(1);
            int stdCount = stdGrade.GetLength(0);
            int[] gradeAvg = GetGradeAvg(stdGrade);
            for (int i = 0; i < gradeCount; i++)
            {
                Console.WriteLine($"grade {i} avg = {gradeAvg[i]}");
            }

            //sum

            int[] gradeSum = GetRowSum(stdGrade);
            for (int i = 0; i < stdCount; i++)
            {
                Console.WriteLine($"student {i + 1} grade sum = {gradeSum[i]}");
            }

            // max 
            int[] stdMax = { };
            GetStdMax(stdGrade, ref stdMax);
            for (int i = 0; i < stdCount; i++)
            {
                Console.WriteLine($"student {i + 1} max grade = {stdMax[i]}");
            }

            //index of std
            int[] topStdIndex = GetIndexForTopGradeStd(stdGrade);

            for (int i = 0; i < gradeCount; i++)
            {
                Console.WriteLine($" grade{i} top student index = {topStdIndex[i]}");
            }

        }

        private static int[] GetIndexForTopGradeStd(int[,] stdGrade)
        {
            int rowMax = 0;
            int stdIndex = 0;
            int colMax;
            int gradeCount = stdGrade.GetLength(1);
            int[] topStdIndex = new int[gradeCount];
            for (int i = 0; i < stdGrade.GetLength(1); i++)
            {
                colMax = stdGrade[0, i];
                stdIndex = 0;

                for (int j = 0; j < stdGrade.GetLength(0); j++)
                {
                    if (stdGrade[j, i] > colMax)
                    {
                        rowMax = stdGrade[j, i];
                        stdIndex = j;
                    }
                }
                topStdIndex[i] = stdIndex;
            }

            return topStdIndex;
        }

        private static void GetStdMax(int[,] stdGrade, ref int[] stdMax)
        {
            int rowMax = 0;
            int stdCount = stdGrade.GetLength(0);

            stdMax = new int[stdCount];
            for (int i = 0; i < stdGrade.GetLength(0); i++)
            {
                rowMax = stdGrade[i, 0];
                for (int j = 0; j < stdGrade.GetLength(1); j++)
                {
                    if (stdGrade[i, j] > rowMax)
                        rowMax = stdGrade[i, j];
                }
                stdMax[i] = rowMax;
            }
        }

        private static int[] GetRowSum(int[,] stdGrade)
        {
            int stdCount = stdGrade.GetLength(0);
            int rowSum = 0;
            int[] gradeSum = new int[stdCount];
            for (int i = 0; i < stdGrade.GetLength(0); i++)
            {
                rowSum = 0;
                for (int j = 0; j < stdGrade.GetLength(1); j++)
                {
                    rowSum += stdGrade[i, j];
                }
                gradeSum[i] = rowSum;
            }

            return gradeSum;
        }

        private static int[] GetGradeAvg(int[,] stdGrade)
        {
            int gradeCount = stdGrade.GetLength(1);
            int stdCount = stdGrade.GetLength(0);
            int[] gradeAvg = new int[gradeCount];
            int sum1 = 0;
            for (int i = 0; i < gradeCount; i++)
            {
                sum1 = 0;
                for (int j = 0; j < stdCount; j++)
                {
                    sum1 += stdGrade[j, i];
                }
                gradeAvg[i] = (sum1 / gradeCount);
            }

            return gradeAvg;
        }

        private static void PrintMatrix(int[,] stdGrade)
        {
            for (int i = 0; i < stdGrade.GetLength(0); i++)
            {
                for (int j = 0; j < stdGrade.GetLength(1); j++)
                {
                    Console.Write($"{stdGrade[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
