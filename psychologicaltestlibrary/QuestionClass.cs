namespace psychologicaltestlib
{
    public class Question
    {
        #region Fields
        private string _QuestionName;
        private string _QuestionBlock;
        public static int Default = -1;
        private int _QuestionAnswer;
        #endregion Fields

        #region Properties
        public string QuestionName
        {
            get => _QuestionName;
            private set => _QuestionName = value;
        }
        public string QuestionBlock
        {
            get => _QuestionBlock;
            private set => _QuestionBlock = value;
        }
        public int QuestionAnswer
        {
            get => _QuestionAnswer;
            private set => _QuestionAnswer = value;
        }
        #endregion Properties

        #region Methods
        public void SetAnswer(int AnswerOnQuestion)
        {
            QuestionAnswer = AnswerOnQuestion;
        }
        #endregion Methods

        #region Constructors
        public Question(string _QuestionName)
        {
            QuestionBlock = string.Empty;
            QuestionName = _QuestionName;
        }
        public Question(string _QuestionBlock, string _QuestionName)
        {
            QuestionBlock = _QuestionBlock;
            QuestionName = _QuestionName;
            QuestionAnswer = -1;
        }
        #endregion Constructors
    }
}
