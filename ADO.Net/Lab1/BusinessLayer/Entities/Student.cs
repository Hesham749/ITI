using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ClsStudent
    {
        public int Id { get; set; }
        public string FName { get; set; } = string.Empty;
        public string LName { get; set; } = string.Empty ;
        public string Address { get; set; } = string.Empty;
        public byte Age { get; set; }
        public int Dept_id { get; set; }
        public int St_super { get; set; }

    }
}
