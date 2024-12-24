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
