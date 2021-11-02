using System.Collections.Generic;

namespace psychologicaltestlib
{
    public class TworchestvoTestType : IVariousTestTemplate
    {
        #region Fields
        private Dictionary<string, Question> _Asks;
        private string[] _Scales;
        #endregion Fields

        #region Properties
        public Dictionary<string, Question> Asks
        {
            get => _Asks;
            set => _Asks = value;
        }
        #endregion Properties

        #region Interface Methods
        public string GetNameOfTest() => "Личностные творческие характеристики";
        public string GetDescriptionOfTest() => "";
        public string[] GetScales() => _Scales;
        public void InitQuestions()
        {
            #region Init Questions
            
            #endregion Init Questions
        }
        public Dictionary<string, int> Processing()
        {

            return new Dictionary<string, int>();
        }
        #endregion Interface Methods

        #region Constructor
        public TworchestvoTestType()
        {
            
        }
        #endregion Constructor
    }
}
