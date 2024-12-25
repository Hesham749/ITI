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

        public static clsComplex operator -(clsComplex c1, clsComplex c2)
        {
            return c1 + new clsComplex(-c2.Real, -c2.Img);
        }

        public static clsComplex operator --(clsComplex c)
        {
            return c + new clsComplex(-1, -1);
        }

        public static clsComplex operator *(clsComplex c1, clsComplex c2)
        {
            if (!(c1 is null) && !(c2 is null)) return new clsComplex(c1.Real * c2.Real, c1.Img * c2.Img);
            else
                return null;
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
