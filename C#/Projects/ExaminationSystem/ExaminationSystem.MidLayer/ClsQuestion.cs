using System.Text.Json.Serialization;

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
        public override string ToString() => $"Header : {Header}\n{Id}- {Body}\nMark({Mark})";
        public ClsQuestion(EnQuestionType questionType, string header, int mark, string body, int id) // i have error if i make the class abstract
        {
            QuestionType = questionType;
            Header = header;
            Mark = mark;
            Body = body;
            Id = id;
        }
    }
}
