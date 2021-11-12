using System;
using System.Collections.Generic;

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
        #endregion Properties

        #region Methods
        /// <summary>
        /// Регистрирует результат для пользователя о прохождении теста.
        /// </summary> 
        /// <param name="variousTestTemplate"></param>
        //public void AddResultsAboutTest(PsychologicalTest ptTestTemplate) => _ptTestTemplate = ptTestTemplate;
        public void RegisterResult(Dictionary<string, int> resultsDict)
        {
            _ResultsDict = new Dictionary<string, int>(resultsDict);
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
