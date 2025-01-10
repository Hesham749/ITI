using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Answer
{
    public class ClsAnswer
    {
        public int QId { get; init; }
        public Dictionary<int, string> Answer { get; protected set; }

        public ClsAnswer(int qId, Dictionary<int, string> answer)
        {
            QId = qId;
            Answer = answer ?? [];
        }

        public override string ToString()
        {
            return $"Question[{QId}] answer :\n{GetAnswer()}";
        }

        string GetAnswer()
        {
            string s = "";
            if (Answer != null) return s;
            foreach (var item in Answer)
            {
                s += $"[{item.Key}] {item.Value} ";
            }
            return s.Trim();
        }
    }
}
