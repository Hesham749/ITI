namespace lab5.demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsCar c1 = new clsCar();
            c1.Print();
            c1.Accelerate(); // +20
            c1.Print();
            c1.Decelerate(); // -20 = 0
            c1.Decelerate(); // -20
            c1.Print();
            clsCar ezzatCar = new clsCar("mercedes", "WHite");
            ezzatCar.Print();
            ezzatCar.Accelerate();  // +20
            ezzatCar.Accelerate();  // +20
            ezzatCar.Accelerate();  // +20
            ezzatCar.Accelerate();  // +20
            ezzatCar.Accelerate();  // +20
            ezzatCar.Print();

        }
    }
}
