using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Demo1
{
    internal class ClsTest
    {
        public int X { get; set; }
        public int Y { get; set; }
        ClsTest(int x, int y)
        {
            X = x;
            Y = y;
        }

        static ClsTest ob;

        public static ClsTest CreateObject(int x, int y)
        {
            if (ob == null)
                ob = new ClsTest(x, y);
            return ob;
        }

    }
}
