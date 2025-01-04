namespace ExaminationSystem.MidLayer
{
    public enum EnQuestionType
    {
        TrueFalse,
        ChooseOne,
        ChooseMultiple
    }
    public abstract class ClsQuestion
    {
        //public static int QuestionQounter { get; protected set; }
        private int _id;
        public EnQuestionType QuestionType { get; protected set; }
        protected string Header { get; set; }
        public int Mark { get; protected set; }
        public string Body { get; set; }
        public int Id { get => _id; init { if (value > 0) _id = value; } }
        public override string ToString() => $"{Body}";
        protected ClsQuestion(int id)
        {
            Id = id;
        }
    }
}
