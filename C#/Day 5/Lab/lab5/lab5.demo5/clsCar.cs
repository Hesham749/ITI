namespace lab5.demo5
{
    internal class clsCar
    {
        string _model;
        string _color;
        string[] _models = { "BMW", "Mercedes", "Fiat" };
        string[] _colors = { "Red", "White", "Black" };

        private clsCar()
        {
            _model = _models[2];
            _color = _colors[2];
        }

        public clsCar(string model = default, string color = null) : this()
        {

            Model = model;
            Color = color;
            if (Model == "BMW")
                MaxSpeed = 240;
            else if (Model == "Mercedes")
                MaxSpeed = 220;
            else if (Model == "Fiat")
                MaxSpeed = 120;
        }

        public string Model
        {
            get { return _model; }
            set
            {
                foreach (var model in _models)
                {
                    if (value != "" && string.IsNullOrWhiteSpace(value))
                        return;
                    else if (value.Trim().ToLower() == model.ToLower())
                    {
                        _model = model;
                        return;
                    }
                }
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                foreach (var color in _colors)
                {
                    if (value != "" && string.IsNullOrWhiteSpace(value))
                        return;
                    else if (color.ToLower() == value.Trim().ToLower())
                    {
                        _color = color;
                        return;
                    }
                }
            }
        }
        public int Speed
        {
            get; private set;
        }
        public int MaxSpeed
        {
            get; private set;
        }

        public void Accelerate()
        {
            if (Speed + 20 <= MaxSpeed)
                Speed += 20;
        }

        public void Decelerate()
        {
            if (Speed - 20 >= 0)
                Speed -= 20;
        }

        public void Print()
        {
            Console.WriteLine($"Car model : {Model,-8} , color : {Color,-5} , speed : {Speed,-3} , max speed : {MaxSpeed} ");
        }
    }
}
