using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsSubject : IComparer<ClsSubject>, IComparable<ClsSubject>
    {
        private static int _subCounter;
        public Dictionary<int, ClsStudent> StdList { get; private set; } = [];
        public int Id { get; init; }
        public string Name { get; init; }

        public ClsSubject(string name, Dictionary<int, ClsStudent> stdList = null)
        {
            Id = ++_subCounter;
            Name = name.ToUpper();
            StdList = stdList ?? [];
        }

        public void AddStd(ClsStudent student)
        {
            StdList.Add(student.Id, student);
        }
        public bool RemoveStd(ClsStudent student)
        {
            return StdList.Remove(student.Id);
        }

        public int Compare(ClsSubject? x, ClsSubject? y)
        {
            return x.Id.CompareTo(y?.Id);
        }

        public int CompareTo(ClsSubject? o)
        {
            return Id.CompareTo(o?.Id);
        }
    }
}
