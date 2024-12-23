namespace Lab6.Demo2
{
    internal class clsCircle : clsShape
    {
        const float by = 3.14f;

        public clsCircle(int dim)
        {
            Diminsion1 = 1;
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
            return by * Math.Pow(Diminsion1, 2); ;
        }
    }
}
