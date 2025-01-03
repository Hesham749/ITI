using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab13.Demo1
{
    internal class ClsPoint
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ClsPoint() { }

        public ClsPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        static public ClsPoint operator +(ClsPoint a, ClsPoint b) => new ClsPoint(a.X + b.X, a.Y + b.Y);
        static public ClsPoint operator -(ClsPoint a, ClsPoint b) => new ClsPoint(a.X - b.X, a.Y - b.Y);
        public override string ToString() => $"({X,-3},{Y,3})";
    }
}
