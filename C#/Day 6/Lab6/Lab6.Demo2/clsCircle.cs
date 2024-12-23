namespace Lab6.Demo2
{
    internal class clsCircle : clsShape
    {
        const float by = 3.14f;

        public clsCircle(int R)
        {
            Diminsion1 = 1;
            if (!SetDiminsion(R))
                Console.WriteLine($"R is set to : {Diminsion1}");
            Diminsion2 = Diminsion1;
        }

        public bool SetDiminsion(int R)
        {
            if (R < 1)
                return false;
            Diminsion1 = R;
            return true;
        }

        public double GetArea()
        {
            return by * Math.Pow(Diminsion1, 2);
        }
    }
}
