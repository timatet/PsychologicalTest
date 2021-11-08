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
        private UserClass _User;
        #endregion Fields

        #region Properties
        private Dictionary<string, Question> Asks
        {
            get => _VariousTestTemplate.Asks;
            set => _VariousTestTemplate.Asks = value;
        }
        #endregion Properties

        #region Methods
        public string[] GetScales() => _VariousTestTemplate.GetScales();
        public int Count() => _VariousTestTemplate.Asks.Count();
        /// <summary>
        /// Сохраняет результат пользователя в таблицу.
        /// Дописывает в таблицу данные о результатах пользователя.
        /// </summary>
        /// <param name="dataSaveInterface"></param>
        public void SaveResults(IDataSaveInterface dataSaveInterface)
        {
            if (!_VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                _User.RegisterResult(_VariousTestTemplate.Processing());
                dataSaveInterface.Print(_User);
            }

            throw new NotAllAnswersReceivedException("Error! Not all answer received!", DateTime.Now);
        }
        public void RegisterUser(UserClass _User)
        {
            this._User = (UserClass)_User.Clone();
        }
        /// <summary>
        /// Получить все ответы, сделанные пользователем на тест.
        /// </summary>
        /// <returns></returns>
        public int[] GetAllAnswers()
        {
            if (_VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                throw new NotAllAnswersReceivedException("Error! Not all answer received!", DateTime.Now);
            } 

            return _VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).ToArray();
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

        /// <summary>
        /// Получение вопроса по числовому индексу.
        /// </summary>
        /// <param name="index">Порядковый номер вопроса.</param>
        /// <returns></returns>
        public Question this[int index]
        {
            get => _VariousTestTemplate.Asks.ElementAt(index).Value;
            private set { }
        }
        /// <summary>
        /// Получение вопроса по собственному индексу.
        /// </summary>
        /// <param name="index">Строка. Номер блока + буква вопроса [A..H]</param>
        /// <returns></returns>
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
        #endregion Constructors
    }
}
