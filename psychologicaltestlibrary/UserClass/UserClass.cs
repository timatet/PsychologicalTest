using psychologicaltestlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psychologicaltestlib
{
    public class UserClass
    {
        #region Fields
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _EducationInstitution;
        IVariousTestTemplate _VariousTestTemplate;
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
        public string EducationInstitution
        {
            get { return _EducationInstitution; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    _EducationInstitution = value;
                else
                    throw new NotAllFieldsNameInputException();
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Регистрирует результат для пользователя о прохождении теста.
        /// </summary> 
        /// <param name="variousTestTemplate"></param>
        public void AddResultsAboutTest(IVariousTestTemplate variousTestTemplate) => _VariousTestTemplate = variousTestTemplate;
        #endregion Methods

        #region Constructors
        public UserClass(string firstName, string middleName, string lastName, string educationInstitution)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            EducationInstitution = educationInstitution;
        }
        #endregion Constructors
    }
}
