using System;
using System.Collections.Generic;
using System.Linq;

namespace psychologicaltestlib
{
    public class UserClass : ICloneable
    {
        #region Fields
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _Gender;
        private int _Age;
        private string _DopInfo;
        private Dictionary<string, int> _ResultsDict;
        private Dictionary<string, double> _AverageResultsDict;

        private PsychologicalTest _PsychologicalTest;

        public string[] GetScales() => _PsychologicalTest.GetScales();
        public int GetMaxForScale(string scale) => _PsychologicalTest.GetMaxForScale(scale);
        #endregion Fields

        #region Properties
        public string FirstName
        {
            get { return _FirstName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    _FirstName = value;
                else
                    throw new NotAllFieldsNameInputException();
            }
        }
        public string MiddleName
        {
            get { return _MiddleName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    _MiddleName = value;
                else
                    throw new NotAllFieldsNameInputException();
            }
        }
        public string LastName
        {
            get { return _LastName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    _LastName = value;
                else
                    throw new NotAllFieldsNameInputException();
            }
        }
        public string Gender
        {
            get { return _Gender; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    _Gender = value;
                else
                    throw new NotAllFieldsNameInputException();
            }
        }
        public int Age
        {
            get { return _Age; }
            private set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                    _Age = value;
                else
                    throw new NotAllFieldsNameInputException();
            }
        }
        public string DopInfo
        {
            get { return _DopInfo; }
            private set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                    _DopInfo = value;
                else _DopInfo = string.Empty;
            }
        }
        public Dictionary<string, int> ResultDict
        {
            get { return _ResultsDict; }
            private set{}
        }
        public Dictionary<string, double> AverageResultDict
        {
            get { return _AverageResultsDict; }
            private set { }
        }
        #endregion Properties

        #region Methods
        public void RegisterTest(PsychologicalTest psychologicalTest) => _PsychologicalTest = psychologicalTest;

        public void SaveResults(IDataSaveInterface dataSaveInterface)
        {
            var TestAsks = _PsychologicalTest.GetTestAsks();
            if (!TestAsks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                _ResultsDict = _PsychologicalTest.Processing();
                _AverageResultsDict = _PsychologicalTest.GetAverageResults(_ResultsDict);
                dataSaveInterface.Print(this, _PsychologicalTest.GetNameOfTest());
            }
            else
            {
                throw new NotAllAnswersReceivedException("Error! Not all answer received!", DateTime.Now);
            }
        }

        public object Clone()
        {
            return new UserClass(this.FirstName, this.MiddleName, this.LastName, this.Gender, this.Age, this.DopInfo);
        }
        #endregion Methods

        #region Constructors
        public UserClass(string firstName, string middleName, string lastName, string gender, int age, string dopinfo)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            DopInfo = dopinfo;
        }
        #endregion Constructors
    }
}
