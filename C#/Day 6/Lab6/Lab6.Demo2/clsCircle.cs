namespace Lab6.Demo2
{
    internal class clsCircle : clsSquare
    {
        const float _by = 3.14f;

        public clsCircle(int R):base(R ) 
        {
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
