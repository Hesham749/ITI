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
        public string LName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public byte Age { get; set; }
        public int Dept_id { get; set; }
        public int? St_super { get; set; }

        public override string ToString()
        {
            return $"ID : {Id} , Name : {FName} {LName} , Address : {Address} , Age : {Age} , Department ID : {Dept_id} {((St_super is null) ? "" : $", Super : {St_super}")}";
        }
    }
}
