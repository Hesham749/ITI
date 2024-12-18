namespace day3.stringMirror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "Ahmed Mohamed Aly";
            MirrorString(ref st);
            Console.WriteLine(st);


            //int x = 5;
            //int z = 4;
            //test1(ref x);
            //int[] arr = { 2, 3, 4, 5 };
            //ref readonly int y = ref x;
            //y = 8;


        }

        private static string MirrorString(ref string st)
        {
            string[] stMirror = st.Split(" ");
            st = "";
            for (int i = stMirror.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    st += stMirror[i];
                else
                    st += stMirror[i] + ' ';
            }
            return st;
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
