using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsAnswer
    {
        public int QId { get; init; }
        public int StdId { get; init; }
        public int QlId { get; init; }
        public int Answer { get; init; }

        public ClsAnswer(int qId, int stdId, int qLtdId, int answer)
        {
            QId = qId;
            StdId = stdId;
            QlId = qLtdId;
            Answer = answer;
        }
    }
}
