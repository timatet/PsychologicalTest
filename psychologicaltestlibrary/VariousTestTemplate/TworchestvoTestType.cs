using System.Collections.Generic;

namespace psychologicaltestlib
{
    public class TworchestvoTestType : IVariousTestTemplate
    {
        #region Fields
        private Dictionary<string, Question> _Asks;
        private string[] _Scales;
        private InformaitionAboutTests InfAT;
        #endregion Fields

        #region Properties
        public Dictionary<string, Question> Asks
        {
            get => _Asks;
            set => _Asks = value;
        }
        #endregion Properties

        #region Interface Methods
        public string GetNameOfTest() => InfAT.TestNames[1];
        public string GetDescriptionOfTest() => InfAT.TestNames[1];
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
            _Asks = new Dictionary<string, Question>();
            _Scales = new string[] { "DefaultScale" };
            InfAT = new InformaitionAboutTests();
        }
        #endregion Constructor
    }
}
