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
        public abstract string Header { get; protected set; }
    }
}
