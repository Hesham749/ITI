namespace Lab6.Demo2
{
    internal class clsSquare : clsShape
    {
        public clsSquare(int dim)
        {
            Diminsion1 = 1;
            if (!SetDiminsion(dim))
                Console.WriteLine($"dimension is set to : {Diminsion1}");
            Diminsion2 = Diminsion1;
        }

        public bool SetDiminsion(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion1 = dim;
            return true;
        }

        public double GetArea()
        {
            return Math.Pow(Diminsion1, 2);
        }
    }
}
