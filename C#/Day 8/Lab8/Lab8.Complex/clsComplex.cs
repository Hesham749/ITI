// Ignore Spelling: Img

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Complex
{
    internal class clsComplex
    {
        public double Real
        {
            get; set;
        }

        public double Img
        {
            get; set;
        }

        public clsComplex(double real = 0, double img = 0)
        {

            Real = real;
            Img = img;
        }

        public void SetComplex(double real, double img = 0)
        {
            Real = real;
            Img = img != 0 ? img : Img;
        }

        public static clsComplex operator +(clsComplex c1, clsComplex c2)
        {
            if (!(c1 is null) && !(c2 is null)) return new clsComplex(c1.Real + c2.Real, c1.Img + c2.Img);
            else
                return null;
        }

        public static clsComplex operator ++(clsComplex c)
        {
            return c + new clsComplex(1, 1);
        }

        public static clsComplex operator +(clsComplex c, double x)
        {
            return c + new clsComplex(x);
        }

        public static clsComplex operator +(double x, clsComplex c)
        {
            return new clsComplex(x) + c;
        }

        public static clsComplex operator -(clsComplex c1, clsComplex c2)
        {
            return (c1 != null ? c1 : null) + (c2 != null ? new clsComplex(-c2.Real, -c2.Img) : null);
        }

        public static clsComplex operator --(clsComplex c)
        {
            return c + new clsComplex(-1, -1);
        }

        public static clsComplex operator -(clsComplex c, double x)
        {
            return c - new clsComplex(x);
        }

        public static clsComplex operator -(double x, clsComplex c)
        {
            return new clsComplex(x) - c;
        }

        public static clsComplex operator *(clsComplex c1, clsComplex c2)
        {
            return (c1 != null ? c1 : null) / (c2 != null ? new clsComplex(1 / c2.Real, 1 / c2.Img) : null);
        }

        public static clsComplex operator *(clsComplex c, double x)
        {
            return c * new clsComplex(x);
        }

        public static clsComplex operator *(double x, clsComplex c)
        {
            return new clsComplex(x) * c;
        }

        public static clsComplex operator /(clsComplex c1, clsComplex c2)
        {
            if (!(c1 is null) && !(c2 is null) && !(c2.Real == 0 || c2.Img == 0)) return new clsComplex(c1.Real / c2.Real, c1.Img / c2.Img);
            else
                return null;
        }

        public static clsComplex operator /(clsComplex c, double x)
        {
            return c / new clsComplex(x);
        }

        public static clsComplex operator /(double x, clsComplex c)
        {
            return new clsComplex(x) / c;
        }

        public static implicit operator clsComplex(double x)
        {
            return new clsComplex(x);
        }

        public static explicit operator double(clsComplex c)
        {
            return c.Real;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (typeof(clsComplex) != obj.GetType()) return false;
            clsComplex c = (clsComplex)obj;
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
