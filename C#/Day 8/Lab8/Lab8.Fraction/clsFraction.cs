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

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

    }
}
