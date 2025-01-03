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
        public EnQuestionType QuestionType { get; protected set; }
        public string Header { get; protected set; }
        public int Mark { get; protected set; }
        public string Body { get; set; }
        public override string ToString() => $"{Body}";
    }
}
