using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    public class ClsFinalExam : ClsExam<ClsSubject>
    {

        public ClsFinalExam()
        {
            Name = "Final";
            Time = TimeSpan.FromHours(2);
        }
        
    }


}
