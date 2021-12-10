using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace psychologicaltestlib
{
    public class PsychologicalTest : IEnumerable, ICloneable
    {
        #region Fields
        private IVariousTestTemplate _VariousTestTemplate;
        #endregion Fields

        #region Methods
        public string[] GetScales() => _VariousTestTemplate.GetScales();
        public int Count() => _VariousTestTemplate.Asks.Count();
        
        public Dictionary<string, int> Processing() => _VariousTestTemplate.Processing();
        public Dictionary<string, double> GetAverageResults(Dictionary<string, int> TestResults) => _VariousTestTemplate.GetAverageResults(TestResults);

        public Dictionary<string, Question> GetTestAsks() => _VariousTestTemplate.Asks;
        public string GetNameOfTest() => _VariousTestTemplate.GetNameOfTest();
        public string GetDescriptionOfTest() => _VariousTestTemplate.GetDescriptionOfTest();
        public string GetInstructionOfTest() => _VariousTestTemplate.GetInstructionOfTest();

        public int GetMaxForScale(string scale) => _VariousTestTemplate.GetMaxForScale(scale);

        public int[] GetAllAnswers()
        {
            if (_VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                throw new NotAllAnswersReceivedException("Error! Not all answer received!", DateTime.Now);
            } 

            return _VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).ToArray();
        }

        public void InitTest(IVariousTestTemplate VariousTestTemplate)
        {
            _VariousTestTemplate = VariousTestTemplate;
            _VariousTestTemplate.InitQuestions();
        }
        #endregion Methods

        #region Interfaces Methods
        public IEnumerator GetEnumerator()
        {
            foreach (var question in _VariousTestTemplate.Asks)
            {
                yield return question.Value;
            }
        }

        public object Clone()
        {
            return new PsychologicalTest(_VariousTestTemplate);
        }

        public KeyValuePair<string, Question> this[int index]
        {
            get => _VariousTestTemplate.Asks.ElementAt(index);
            private set { }
        }

        public Question this[string index]
        {
            get => _VariousTestTemplate.Asks[index];
            private set { }
        }
        #endregion Interfaces Methods

        #region Constructors
        public PsychologicalTest(IVariousTestTemplate VariousTestTemplate)
        {
            _VariousTestTemplate = VariousTestTemplate;
            _VariousTestTemplate.InitQuestions();
        }
        public PsychologicalTest() { }
        #endregion Constructors
    }
}
