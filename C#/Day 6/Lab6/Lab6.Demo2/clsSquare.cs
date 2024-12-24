namespace Lab6.Demo2
{
    internal class clsSquare : clsRectangle
    {
        public clsSquare(int dim) : base(dim >= 1 ? dim : 1, dim >= 1 ? dim : 1)
        {

        }

        public override bool SetDiminsion1(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion1 = Diminsion2 = dim;
            return true;
        }

        public override bool SetDiminsion2(int dim)
        {
            if (dim < 1)
                return false;
            Diminsion1 = Diminsion2 = dim;
            return true;
        }

        public override void ShapeStatus()
        {
            Console.WriteLine($"Square Status : {Diminsion1}-{Diminsion2}");
        }

    }
}
