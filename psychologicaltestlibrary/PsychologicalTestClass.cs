using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace psychologicaltestlib
{
    public class PsychologicalTest : IEnumerable
    {
        #region Fields
        private IVariousTestTemplate _VariousTestTemplate;
        List<UserClass> _Users;
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
        /// Сохраняет результат для всех пользователей которые прошли этот документ.
        /// "Завершить прохождение теста и сформировать результаты"
        /// </summary>
        /// <param name="dataSaveInterface"></param>
        public void StopTestAndSaveResults(IDataSaveInterface dataSaveInterface)
        {
            dataSaveInterface.Print(_Users);
        }
        /// <summary>
        /// Сохранение результатов тестирования и переход к другому пользователю.
        /// "Перейти к прохождению теста следующим участником"
        /// </summary>
        public void NextUser(UserClass user)
        {
            if (!_VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                user.AddResultsAboutTest(_VariousTestTemplate);
                _Users.Add(user);
            }

            throw new NotAllAnswersReceivedException("Error! Not all answer received!", DateTime.Now);
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
            _Users = new List<UserClass>();
        }
        #endregion Constructors
    }
}
