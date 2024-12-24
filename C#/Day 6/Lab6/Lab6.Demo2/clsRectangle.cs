namespace Lab6.Demo2
{
    internal class clsRectangle : clsShape
    {
        public clsRectangle(int dim1, int dim2)
        {
            Diminsion1 = 1;
            Diminsion2 = 2;
            SetDiminsion1(dim1);
            SetDiminsion2(dim2);

        }

        public override bool SetDiminsion1(int dim)
        {
            if (dim < 1 || dim == Diminsion2)
                return false;
            Diminsion1 = dim;
            return true;
        }

        public override  bool SetDiminsion2(int dim)
        {
            if (dim < 1 || dim == Diminsion1)
                return false;
            Diminsion2 = dim;
            return true;
        }

        public override float GetArea()
        {
            return Diminsion1 * Diminsion2;
        }

        public override void ShapeStatus()
        {
            Console.WriteLine($"Rectangle Status : {Diminsion1}-{Diminsion2}");
        }
    }
}
