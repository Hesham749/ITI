namespace Lab8.Fraction
{
    internal class clsFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; protected set; }

        public clsFraction(int numerator, int denominator)
        {
            Denominator = 1;
            Denominator = denominator;
        }

        public bool SetDenominator(int denominator)
        {
            if (denominator == 0)
                return false;
            Denominator = denominator;
            return true;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (GetType() == obj.GetType())
            {
                clsFraction f = (clsFraction)obj;
                return f.Denominator == Denominator && f.Numerator == Numerator;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }



    }
}
