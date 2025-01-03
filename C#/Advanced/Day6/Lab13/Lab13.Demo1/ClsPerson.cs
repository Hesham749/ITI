using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Demo1
{
    internal abstract class ClsPerson
    {
        private int _id;
        public string Name { get; set; }

        public int Id
        {
            get => _id;

            set { if (value > 0) _id = value; }
        }



    }
}
