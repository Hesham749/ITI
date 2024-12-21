namespace lab5.demo1
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }
        static float Add(float a, int b)
        {
            return a + b;
        }

        static float Add(int a, float b)
        {
            return a + b;
        }

        //static int Add(ref int a, ref int b)
        //{
        //    return a + b;
        //}

        // can not overload access modifier only


        static int Add(out int a, out int b)
        {
            a = 40;
            b = 200;
            return a + b;
        }

        static void Main(string[] args)
        {
            int x = 10, y = 20;
            //Add(ref x, ref y);
            Add(out x, out y);
            Add(x, y);
            Add(x, y, 4);
        }
    }
}
