namespace Lab6.Demo2
{
    internal class clsRectangle : clsShape
    {
        public clsRectangle(int dim1, int dim2)
        {
            Diminsion1 = 1;
            Diminsion2 = 2;
            if (!SetDiminsion1(dim1))
                Console.WriteLine($"Diminsion1 is set to : {Diminsion1}");
            if (!SetDiminsion2(dim2))
                Console.WriteLine($"Diminsion2 is set to : {Diminsion2}");
        }

        public bool SetDiminsion1(int dim)
        {
            if (dim < 1 || dim == Diminsion2)
                return false;
            Diminsion1 = dim;
            return true;
        }

        public bool SetDiminsion2(int dim)
        {
            if (dim < 1 || dim == Diminsion1)
                return false;
            Diminsion2 = dim;
            return true;
        }

        public double GetArea()
        {
            return Diminsion1 * Diminsion2;
        }
    }
}
