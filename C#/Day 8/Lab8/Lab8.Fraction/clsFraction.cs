namespace Lab8.Fraction
{
    internal class clsFraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; protected set; }

        public clsFraction(int numerator, int denominator = 1)
        {
            Denominator = 1;
            SetDenominator(denominator);
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
            if (f == null)
                return null;
            GetCommonFactor(f, out int commonFactor);
            return new clsFraction(f.Numerator / commonFactor, f.Denominator / commonFactor);
        }

        private static int GetCommonFactor(clsFraction f, out int commonFactor)
        {
            commonFactor = 1;
            int small = ((f.Numerator < f.Denominator) ? f.Numerator : f.Denominator);
            int increment = (f.Numerator % 2 == 0 && f.Denominator % 2 == 0) || (f.Numerator % 2 != 0 && f.Denominator % 2 != 0) ? 2 : 1;
            int start = (f.Numerator % 2 != 0 && f.Denominator % 2 != 0) ? 3 : 2;

            for (int i = start; i <= small / 2; i += increment)
            {
                if (f.Denominator % i == 0 && f.Numerator % i == 0)
                {
                    commonFactor = i;
                }
                if (f.Denominator % (small - i) == 0 && f.Numerator % (small - i) == 0)
                {
                    commonFactor = small - i;
                    break;
                }
            }

            return commonFactor;
        }

        #region +

        public static clsFraction operator +(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return Simplify(new clsFraction((f1.Numerator * f2.Denominator) + (f1.Denominator * f2.Numerator), f1.Denominator * f2.Denominator));
            return null;
        }

        public static clsFraction operator ++(clsFraction f)
        {
            return Simplify(f + new clsFraction(1, 1));
        }

        public static clsFraction operator +(clsFraction f, int x)
        {
            return Simplify(f + new clsFraction(x));
        }

        public static clsFraction operator +(int x, clsFraction f)
        {
            return Simplify(f + new clsFraction(x));
        }

        #endregion

        #region -

        public static clsFraction operator -(clsFraction f1, clsFraction f2)
        {
            return Simplify(new clsFraction((f1.Numerator * f2.Denominator) + (-f1.Denominator * f2.Numerator), f1.Denominator * f2.Denominator));
        }

        public static clsFraction operator --(clsFraction f)
        {
            return Simplify(f - new clsFraction(1, 1));
        }

        public static clsFraction operator -(clsFraction f, int x)
        {
            return Simplify(f - new clsFraction(x));
        }

        public static clsFraction operator -(int x, clsFraction f)
        {
            return Simplify(f - new clsFraction(x));
        }

        #endregion

        #region *
        public static clsFraction operator *(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return Simplify(new clsFraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator));
            return null;
        }

        public static clsFraction operator *(clsFraction f, int x)
        {

            return Simplify(f * new clsFraction(x));

        }

        public static clsFraction operator *(int x, clsFraction f)
        {

            return Simplify(f * new clsFraction(x));

        }

        #endregion

        #region /

        public static clsFraction operator /(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return f1 * new clsFraction(f2.Denominator, f2.Numerator);
            return null;
        }

        public static clsFraction operator /(clsFraction f, int x)
        {

            return Simplify(f / new clsFraction(x));

        }

        public static clsFraction operator /(int x, clsFraction f)
        {

            return Simplify(f / new clsFraction(x));

        }

        #endregion

        #region ><
        public static bool operator <(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return (f1.Numerator / f1.Denominator) < (f2.Numerator / f2.Denominator);
            return false;
        }

        public static bool operator >(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return (f1.Numerator / f1.Denominator) > (f2.Numerator / f2.Denominator);
            return false;
        }
        #endregion

        #region >=<=
        public static bool operator <=(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return (f1.Numerator / f1.Denominator) <= (f2.Numerator / f2.Denominator);
            return false;
        }

        public static bool operator >=(clsFraction f1, clsFraction f2)
        {
            if (f1 != null && f2 != null)
                return (f1.Numerator / f1.Denominator) >= (f2.Numerator / f2.Denominator);
            return false;
        }
        #endregion

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
            return $"{Numerator}{((Denominator != 1) ? $"/{Denominator}" : "")}";
        }

    }
}
