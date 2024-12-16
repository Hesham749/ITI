namespace day3.stringMirror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "Ahmed Mohamed Aly";
            MirrorString(st);


            //int x = 5;
            //int z = 4;
            //test1(ref x);
            //int[] arr = { 2, 3, 4, 5 };
            //ref readonly int y = ref x;
            //y = 8;


        }

        private static void MirrorString(string st)
        {
            string[] stMirror = st.Split(" ");
            for (int i = stMirror.Length - 1; i >= 0; i--)
            {
                Console.Write(stMirror[i] + " ");
            }
        }
        //static void test1(ref readonly int x)
        //{
        //    x = 70;
        //}
        //static void test2(ref readonly int[] arr1)
        //{
        //    arr1[0] = 80;
        //    arr1 = null;
        //}

    }
}
