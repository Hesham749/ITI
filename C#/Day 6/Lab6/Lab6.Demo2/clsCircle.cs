namespace Lab6.Demo2
{
    internal class clsCircle : clsShape
    {
        const float _by = 3.14f;

        public clsCircle(int r)
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

        public override float GetArea()
        {
            return (float)(_by * Math.Pow(Diminsion1, 2));
        }

        public override void ShapeStatus()
        {
            Console.WriteLine($"circle Status : {Diminsion1}-{Diminsion2}");
        }
    }
}
