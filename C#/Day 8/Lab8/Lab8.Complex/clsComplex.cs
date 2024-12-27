// Ignore Spelling: Img

namespace Lab8.Complex
{
    internal class ClsComplex
    {
        public double Real
        {
            get; set;
        }

        public double Img
        {
            get; set;
        }

        public ClsComplex(double real = 0, double img = 0)
        {

            Real = real;
            Img = img;
        }

        public void SetComplex(double real, double img = 0)
        {
            Real = real;
            Img = img != 0 ? img : Img;
        }

        #region +
        public static ClsComplex operator +(ClsComplex c1, ClsComplex c2)
        {
            return c1 - (c2 != null ? new ClsComplex(-c2.Real, -c2.Img) : null);

        }

        public static ClsComplex operator ++(ClsComplex c)
        {
            return c + new ClsComplex(1, 1);
        }

        public static ClsComplex operator +(ClsComplex c, double x)
        {
            return c + new ClsComplex(x);
        }

        public static ClsComplex operator +(double x, ClsComplex c)
        {
            return new ClsComplex(x) + c;
        }

        #endregion

        #region -
        public static ClsComplex operator -(ClsComplex c1, ClsComplex c2)
        {
            if (!(c1 is null) && !(c2 is null)) return new ClsComplex(c1.Real - c2.Real, c1.Img - c2.Img);
            else
                return null;
        }

        public static ClsComplex operator --(ClsComplex c)
        {
            return c + new ClsComplex(-1, -1);
        }

        public static ClsComplex operator -(ClsComplex c, double x)
        {
            return c - new ClsComplex(x);
        }

        public static ClsComplex operator -(double x, ClsComplex c)
        {
            return new ClsComplex(x) - c;
        }

        #endregion

        #region *
        public static ClsComplex operator *(ClsComplex c1, ClsComplex c2)
        {
            return c1 / (c2 != null ? new ClsComplex(1 / c2.Real, 1 / c2.Img) : null);
        }

        public static ClsComplex operator *(ClsComplex c, double x)
        {
            return c * new ClsComplex(x);
        }

        public static ClsComplex operator *(double x, ClsComplex c)
        {
            return new ClsComplex(x) * c;
        }

        #endregion

        #region /
        public static ClsComplex operator /(ClsComplex c1, ClsComplex c2)
        {
            if (!(c1 is null) && !(c2 is null) && !(c2.Real == 0 || c2.Img == 0)) return new ClsComplex(c1.Real / c2.Real, c1.Img / c2.Img);
            else
                return null;
        }

        public static ClsComplex operator /(ClsComplex c, double x)
        {
            return c / new ClsComplex(x);
        }

        public static ClsComplex operator /(double x, ClsComplex c)
        {
            return new ClsComplex(x) / c;
        }

        #endregion

        #region casting

        public static implicit operator ClsComplex(double x)
        {
            return new ClsComplex(x);
        }

        public static explicit operator double(ClsComplex c)
        {
            return c.Real;
        }

        #endregion

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (typeof(ClsComplex) != obj.GetType()) return false;
            ClsComplex c = (ClsComplex)obj;
            if (c.Real != Real || Img != c.Img) return false;
            return true;
        }

        public override string ToString()
        {
            return $"{Real}{(Img <= 0 ? "" : "+")}{(Img == 0 ? "" : $"{Img}j")}";
        }

        public void Print()
        {
            Console.WriteLine($"{Real}{(Img <= 0 ? "" : "+")}{(Img == 0 ? "" : $"{Img}j")}");
        }
    }
}
