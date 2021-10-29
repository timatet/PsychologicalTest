namespace psychologicaltestlib
{
    /// <summary>
    /// Варианты ответа. Значения каждого варианта - балл, который учитывается при подведении результатов, если этот вариант выбран.
    /// </summary>
    public enum Answer
    {
        YesAgree = 3,
        ThinkAgree = 2,
        WhenHow = 1,
        DontAgree = 0,
        DontKnow = 0,
        Default = -1
    }
    public class Question
    {
        #region Fields
        private string _QuestionName;
        private string _QuestionBlock;
        private Answer _QuestionAnswer;
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
        public Answer QuestionAnswer
        {
            get => _QuestionAnswer;
            private set => _QuestionAnswer = value;
        }
        #endregion Properties

        #region Methods
        public void SetAnswer(Answer AnswerOnQuestion)
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
            QuestionAnswer = Answer.Default;
        }
        #endregion Constructors
    }
}
