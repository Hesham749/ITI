namespace lab5.demo6
{
    internal class clsComplex
    {
        public double Real
        {
            private get; set;
        }
        public double Img
        {
            private get; set;
        }

        public clsComplex(double real, double img)
        {
            Real = real;
            Img = img;
        }

        public void Print()
        {
            Console.WriteLine($"{Real}{(Img < 0 ? "" : "+")}{Img}j");
        }
    }
}
