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
        public override string ToString() => $"Header : {Header}\n{Id}- {Body}\nMark({Mark}) \nanswer : {GetAnswer()}";
        public int[] Answer { get; protected set; }

        public ClsQuestion(EnQuestionType questionType, string body, params int[] answer) // i have error if i make the class abstract
        {
            QuestionCounter++;
            QuestionType = questionType;
            SetHeaderAndMark();
            Body = body;
            Id = QuestionCounter; // 0 0 0 0 0  1      2 3 > 3
            Answer = answer;

        }

        void SetHeaderAndMark()
        {
            switch (QuestionType)
            {
                case EnQuestionType.TrueFalse:
                    Header = "Read each statement carefully and decide whether it is True or False :";
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
            foreach (var i in answer)
            {
                if (i > 0)
                    answer += (i + " ,");
            }
            answer = answer != "" ? answer.Remove(answer.Length - 2, 1).Trim() : answer;
            return answer;
        }
    }
}
