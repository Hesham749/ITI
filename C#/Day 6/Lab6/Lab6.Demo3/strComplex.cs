using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Demo3
{
    internal struct strComplex
    {
        public double Real
        {
            get; set;
        }
        public double Img
        {
            get; set;
        }

        public strComplex()
        {
            Real = 0;
            Img = 0;
        }

        public strComplex(double real = 0, double img = 0)
        {

            Real = real;
            Img = img;
        }

        public void SetComplex(double real, double img = 0)
        {
            Real = real;
            Img = img != 0 ? img : Img;
        }

        public void Print()
        {
            Console.WriteLine($"{Real}{(Img <= 0 ? "" : "+")}{(Img == 0 ? "" : $"{Img}j")}");
        }
    }
}
