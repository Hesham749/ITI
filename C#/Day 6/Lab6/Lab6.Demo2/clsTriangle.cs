namespace Lab6.Demo2
{
    internal class clsTriangle : clsShape
    {
        public clsTriangle(int diminsion1, int diminsion2)
        {
            Diminsion1 = 1;
            Diminsion2 = 1;
            if (!SetDiminsion1(diminsion1))
                Console.WriteLine($"diminsion1 is set to {diminsion1}");
            if (!SetDiminsion2(diminsion2))
                Console.WriteLine($"diminsion2 is set to {diminsion2}");
        }

        public bool SetDiminsion1(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion1 = dim;
            return true;
        }

        public bool SetDiminsion2(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion2 = dim;
            return true;
        }

        public double GetArea()
        {
            return 0.5 * Diminsion1 * Diminsion2;
        }
    }
}
