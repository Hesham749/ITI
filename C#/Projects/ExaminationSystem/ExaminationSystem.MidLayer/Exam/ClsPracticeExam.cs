using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    public class ClsPracticeExam : ClsExam<ClsSubject>
    {



        public override string ToString()
        {
            return $"{(string.IsNullOrEmpty(Name) ? "" : Name + " ")}practice exam";
        }


    }

}