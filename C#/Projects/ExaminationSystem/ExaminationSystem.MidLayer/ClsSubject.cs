using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsSubject : IComparer<ClsSubject>
    {
        private static int _subCounter;
        public Dictionary<int, ClsStudent> StdList { get; private set; } = new Dictionary<int, ClsStudent>();
        public int Id { get; init; }
        public string Name { get; init; }

        public ClsSubject(string name, Dictionary<int, ClsStudent> stdlist = null)
        {
            Id = ++_subCounter;
            Name = name;
            StdList = stdlist ?? new();
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
            return x.Id.CompareTo(y.Id);
        }

    }
}
