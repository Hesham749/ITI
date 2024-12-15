namespace day3.stringMirror
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string st = "Ahmed Mohamed Aly";
            string[] stMirror = st.Split(" ");
            for (int i = stMirror.Length - 1; i >= 0; i--)
            {
                Console.Write(stMirror[i] + " ");
            }
        }
    }
}
