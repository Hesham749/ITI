namespace ExaminationSystem.MidLayer
{
    public enum EnQuestionType
    {
        TrueFalse,
        ChooseOne,
        ChooseMultiple
    }
    public class ClsQuestion
    {
        public static int QuestionCounter { get; protected set; }
        private int _id;
        public EnQuestionType QuestionType { get; protected set; }
        public string Header { get; protected set; } // if i make the property protected it will cause error even tho if one of them protected it works fine 
        public int Mark { get; protected set; }
        public string Body { get; set; }
        public int Id { get => _id; set { if (value > 0) _id = value; } }
        public override string ToString() => $"{Id}- {Header}\n\n{Body}:\nanswer : {GetAnswer()}\nMark({Mark})";
        public Dictionary<int, string> Answer { get; protected set; }

        public ClsQuestion(EnQuestionType questionType, string body, Dictionary<int, string> answer)
        {
            QuestionCounter++;
            QuestionType = questionType;
            SetHeaderAndMark();
            Body = body;
            Id = QuestionCounter;
            Answer = answer;
        }

        void SetHeaderAndMark()
        {
            switch (QuestionType)
            {
                case EnQuestionType.TrueFalse:
                    Header = "Answer the following True or False questions (Enter 1 for True, 2 for False):";
                    Mark = 2;
                    break;
                case EnQuestionType.ChooseMultiple:
                    Header = "Read each question carefully and select all correct answers :";
                    Mark = 4;
                    break;
                case EnQuestionType.ChooseOne:
                    Header = "Read each question carefully and select the best answer from the given options :";
                    Mark = 3;
                    break;
            }
        }

        public string GetAnswer()
        {
            string answer = "";
            foreach (var i in Answer)
                answer += (i.Value + " ,");
            answer = answer != "" ? answer.Remove(answer.Length - 2, 2).Trim() : answer;
            return answer;
        }
    }
}
