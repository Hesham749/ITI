using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Demo2
{
    internal class ClsEmpList : List<ClsEmp>
    {
        public new void Add(ClsEmp e)
        {
            base.Add(e);

        }
    }
}
