namespace Lab6.Demo2
{
    internal class clsTriangle : clsShape
    {
        public clsTriangle(int diminsion1, int diminsion2)
        {
            Diminsion1 = 1;
            Diminsion2 = 1;
            SetDiminsion1(diminsion1);
            SetDiminsion2(diminsion2);
        }

        public override float GetArea()
        {
            return 0.5f * Diminsion1 * Diminsion2;
        }

        public override void ShapeStatus()
        {
            Console.WriteLine($"Triangle Status : {Diminsion1}-{Diminsion2}");
        }
    }
}
