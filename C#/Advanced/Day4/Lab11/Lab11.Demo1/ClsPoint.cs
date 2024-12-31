using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab11.Demo1
{
    internal class ClsPoint : ClsComplex, IAdd<int>
    {
        public ClsPoint()
        {
            Real = 0;
            // Img = 0; // inaccessible
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }


}
