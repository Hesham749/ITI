namespace Lab10.Demo1
{
    internal class Program
    {

        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            //1
            int x = 5, y = 3;
            Console.WriteLine($"x = {x} , y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x} , y = {y}");

            //2
            Console.WriteLine("=========================================");
            ClsGList<int> gList = new ClsGList<int>(1);
            gList.Print();
            gList.Add(5);
            gList.Add(3);
            gList.Add(2);
            gList.Print();
            gList.Remove(3);
            gList.Print();
            gList.Clear();
            gList.Print();

            //3 
            Console.WriteLine("=========================================");
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Add(2);
            list.Add(1);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //4
            Console.WriteLine("=========================================");
            ClsGStack<int> gStack = new ClsGStack<int>();
            if (gStack.IsEmpty())
                Console.WriteLine("stack is empty");
            //Console.WriteLine(gStack.Peek());
            //Console.WriteLine(gStack.Pop());
            gStack.Push(5);
            gStack.Push(4);
            gStack.Push(3);
            gStack.Push(2);
            Console.WriteLine(gStack.IsFull() == true);
            gStack.Push(1);
            Console.WriteLine(gStack.IsFull() == true);
            while (!gStack.IsEmpty())
            {
                Console.WriteLine(gStack.Pop());
            }

        }
    }
}
