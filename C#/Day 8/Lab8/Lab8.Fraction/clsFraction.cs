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
            Numerator = numerator;
        }

        public bool SetDenominator(int denominator)
        {
            if (denominator == 0)
                return false;
            Denominator = denominator;
            return true;
        }

        public static clsFraction Simplify(clsFraction f)
        {
            int small = ((f.Numerator < f.Denominator) ? f.Numerator : f.Denominator);
            int commonFactor = 0;
            for (int i = 2; i <= small / 2; i++)
            {
                if (f.Denominator % i == 0 && f.Numerator % i == 0)
                {
                    commonFactor = i;
                }
                if (f.Denominator % (small - i) == 0 && f.Numerator % (small - 100) == 0)
                {
                    commonFactor = i;
                    break;
                }
            }
            return new clsFraction(f.Numerator / commonFactor, f.Denominator / commonFactor);
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
