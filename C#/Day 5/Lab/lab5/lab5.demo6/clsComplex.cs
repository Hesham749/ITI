namespace lab5.demo6
{
    internal class clsComplex
    {
        static public int Counter { get; private set; }

        public double Real
        {
            get; set;
        }
        public double Img
        {
            get; set;
        }

        public clsComplex(double real = 0, double img = 0)
        {
            Counter++;
            Real = real;
            Img = img;
        }

        public void SetComplex(double real, double img = 0)
        {
            Real = real;
            Img = img != 0 ? img : Img;
        }

        public void Print()
        {
            Console.WriteLine($"{Real}{(Img <= 0 ? "" : "+")}{(Img == 0 ? "" : $"{Img}j")}");
        }
    }
}
