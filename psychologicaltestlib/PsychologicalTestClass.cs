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
        #endregion Fields

        #region Methods
        public string[] GetScales() => _VariousTestTemplate.GetScales();
        public int Count() => _VariousTestTemplate.Asks.Count();
        /// <summary>
        /// Сохранение результатов тестирования с помощью выбранного метода сохранения.
        /// </summary>
        public void SaveResults(IDataSaveInterface dataSaveInterface) => dataSaveInterface.Print();
        /// <summary>
        /// Возвращает True, если ни один вопрос не остался без ответа. False в противоположном случае.
        /// </summary>
        /// <returns>True or False</returns>
        public bool IsAllQuestionsBeenAnswered()
        {
            return !_VariousTestTemplate.Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default);
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
        /// <summary>
        /// Получить словарь результатов. В качестве ключа - шкала. Значение - количество набранных баллов.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> Processing() => _VariousTestTemplate.Processing();
        public void InitQuestions() => _VariousTestTemplate.InitQuestions();
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
        }
        #endregion Constructors
    }
}
