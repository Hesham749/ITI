using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Subject
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
            if (!StdList.ContainsKey(student.Id))
                StdList.Add(student.Id, student);
        }
        public bool RemoveStd(ClsStudent student)
        {
            if (student == null) return false;
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
