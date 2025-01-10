using Newtonsoft.Json;

namespace ExaminationSystem.MidLayer.Question
{
    public abstract class ClsQuestion
    {
        //public static int QuestionCounter { get; protected set; }
        private int _id;
        public string Header { get; protected set; }
        public int Mark { get; protected set; }
        public string Body { get; set; }
        public int Id { get => _id; set { if (value > 0) _id = value; } }
        public Dictionary<int, string> CorrectAnswer { get; protected set; }
        public Dictionary<int, string> Options { get; protected set; }

        public ClsQuestion(string body, Dictionary<int, string> answer)
        {
            //QuestionCounter++;
            Body = body;
            //Id = QuestionCounter;
            CorrectAnswer = answer;
        }


        public string GetAnswer()
        {
            string answer = "";
            foreach (var i in CorrectAnswer)
                answer += i.Value + " ,";
            answer = answer != "" ? answer.Remove(answer.Length - 2, 2).Trim() : answer;
            return answer;
        }

        public override string ToString() => $"{Id}- {Header}\n\n{Body}:\nanswer : {GetAnswer()}\nMark({Mark})";

    }
}
