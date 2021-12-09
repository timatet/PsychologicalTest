using System;
using System.Collections.Generic;
using System.Linq;

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
            Asks.Add("1", new Question("Если я не знаю правильного ответа, то я попытаюсь догадаться о нем."));
            Asks.Add("2", new Question("Я люблю рассматривать предмет тщательно и подробно, чтобы обнаружить детали, которых не видел раньше."));
            Asks.Add("3", new Question("Обычно я задаю вопросы, если чего-нибудь не знаю."));
            Asks.Add("4", new Question("Мне не нравится планировать дела заранее."));
            Asks.Add("5", new Question("Перед тем как играть в новую игру, я должен убедиться, что смогу выиграть."));
            Asks.Add("6", new Question("Мне нравится представлять себе то, что мне нужно будет узнать или сделать."));
            Asks.Add("7", new Question("Если что-то не удается мне с первого раза; я буду работать до тех пор, пока не сделаю это."));
            Asks.Add("8", new Question("Я никогда не выберу игру, с которой другие не знакомы."));
            Asks.Add("9", new Question("Лучше я буду делать все как обычно, чем искать новые способы."));
            Asks.Add("10", new Question("Я люблю выяснять, так ли все на самом деле."));
            Asks.Add("11", new Question("Мне нравится заниматься чем-то новым."));
            Asks.Add("12", new Question("Я люблю знакомиться с новыми людьми."));
            Asks.Add("13", new Question("Мне нравится думать о том, чего со мной никогда не случалось."));
            Asks.Add("14", new Question("Обычно я не трачу время на мечты о том, что могу стать известным человеком."));
            Asks.Add("15", new Question("Некоторые мои идеи так захватывают меня, что я забываю обо всем на свете."));
            Asks.Add("16", new Question("Мне бы понравилось жить и работать на космической станции, чем здесь, на Земле."));
            Asks.Add("17", new Question("Я нервничаю, если не знаю, что произойдет дальше."));
            Asks.Add("18", new Question("Я люблю то, что необычно."));
            Asks.Add("19", new Question("Я часто пытаюсь представить, о чем думают другие люди."));
            Asks.Add("20", new Question("Мне нравятся рассказы, или телевизионные передачи о событиях далекого прошлого."));
            Asks.Add("21", new Question("Мне нравится обсуждать мои идеи в компании друзей."));
            Asks.Add("22", new Question("Я обычно сохраняю спокойствие, когда делаю что-то не так или ошибаюсь."));
            Asks.Add("23", new Question("Мне хотелось бы сделать или совершить что-то такое, что никому не удавалось до меня."));
            Asks.Add("24", new Question("Я выбираю друзей, которые предпочитают традиционные способы действий."));
            Asks.Add("25", new Question("Многие существующие правила меня обычно не устраивают."));
            Asks.Add("26", new Question("Мне нравится решать даже такую проблему, которая не имеет правильного ответа."));
            Asks.Add("27", new Question("Существует много вещей, с которыми мне бы хотелось поэкспериментировать."));
            Asks.Add("28", new Question("Если я однажды нашел ответ на вопрос, я буду придерживаться его, а не искать другие ответы"));
            Asks.Add("29", new Question("Я не люблю выступать перед большой аудиторией."));
            Asks.Add("30", new Question("Когда я читаю или смотрю телевизор, я нередко представляю себя кем-либо из героев."));
            Asks.Add("31", new Question("Я люблю представлять себе, как жили люди 200 лет назад."));
            Asks.Add("32", new Question("Мне не нравится, когда мои друзья нерешительны."));
            Asks.Add("33", new Question("Я люблю исследовать старые чемоданы и коробки, чтобы просто посмотреть, что в них может быть."));
            Asks.Add("34", new Question("Мне хотелось бы, чтобы мои близкие и друзья делали все как обычно и не менялись."));
            Asks.Add("35", new Question("Я доверяю своим чувствам, предчувствиям."));
            Asks.Add("36", new Question("Интересно предположить что-либо и проверить, прав ли я."));
            Asks.Add("37", new Question("Интересно браться за головоломки или дела, в которых необходимо рассчитывать свои дальнейшие ходы."));
            Asks.Add("38", new Question("Меня интересуют механизмы, любопытно посмотреть, что у них внутри и как они работают."));
            Asks.Add("39", new Question("Моим друзьям не нравятся глупые идеи."));
            Asks.Add("40", new Question("Я люблю выдумывать что-то новое, даже если это невозможно применить на практике."));
            Asks.Add("41", new Question("Мне нравится, когда все вещи лежат на своих местах."));
            Asks.Add("42", new Question("Мне было бы интересно искать ответы на вопросы, которые возникнут в будущем."));
            Asks.Add("43", new Question("Я люблю браться за новое дело, чтобы посмотреть, что из этого выйдет."));
            Asks.Add("44", new Question("Мне интереснее играть в любимые игры просто ради удовольствия, а не ради выигрыша."));
            Asks.Add("45", new Question("Мне нравится размышлять о чем-то интересном, о том, что еще никому не приходило в голову."));
            Asks.Add("46", new Question("Когда я вижу картину, на которой изображен кто-либо незнакомый, мне интересно узнать, кто это."));
            Asks.Add("47", new Question("Я люблю листать книги и журналы для того, чтобы просто посмотреть, что в них."));
            Asks.Add("48", new Question("Я думаю, что на большинство вопросов существует один правильный ответ."));
            Asks.Add("49", new Question("Я люблю задавать вопросы о таких вещах, о которых другие люди не задумываются."));
            Asks.Add("50", new Question("У меня есть много интересных дел."));

            #endregion Init Questions
        }

        public int SchemeParse21(int ans) => ans == 3 ? 2 : ans == 2 ? 1 : ans == 1 ? 1 : -1;
        public int SchemeParse12(int ans) => ans == 3 ? 1 : ans == 2 ? 1 : ans == 1 ? 2 : -1;
        public int AutoSchemeParseGetRes(int que)
        {
            List<int> QuestsForSchemeParse21 = new List<int> { 1, 21, 25, 35, 36, 43, 44, /**/
            7, 10, 15, 18, 26, 42, 50, /**/ 2, 3, 11, 12, 19, 27, 33, 37, 38, 47, 49, /**/ 
            6, 13, 16, 23, 30, 31, 40, 45, 46};

            if (QuestsForSchemeParse21.Contains(que)) return SchemeParse21(Asks[que.ToString()].QuestionAnswer);
            else return SchemeParse12(Asks[que.ToString()].QuestionAnswer);
        }

        public Dictionary<string, double> GetAverageResults(Dictionary<string, int> TestResults)
        {
            Dictionary<string, double> _AverageResult = new Dictionary<string, double>();

            double AverageMaximum = 12.5;

            double AverageValue = TestResults[_Scales[0]] * AverageMaximum / 13;
            _AverageResult.Add(_Scales[0], AverageValue);

            AverageValue = TestResults[_Scales[1]] * AverageMaximum / 13;
            _AverageResult.Add(_Scales[1], AverageValue);

            AverageValue = TestResults[_Scales[2]] * AverageMaximum / 12;
            _AverageResult.Add(_Scales[2], AverageValue);

            AverageValue = TestResults[_Scales[3]] * AverageMaximum / 12;
            _AverageResult.Add(_Scales[3], AverageValue);

            return _AverageResult;
        }
        public Dictionary<string, int> Processing()
        {
            Dictionary<string, int> TestResults = new Dictionary<string, int>();

            if (!Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                #region Init Results
                TestResults.Add(_Scales[0], AutoSchemeParseGetRes(1) + AutoSchemeParseGetRes(5) + AutoSchemeParseGetRes(8) +
                     + AutoSchemeParseGetRes(21) + AutoSchemeParseGetRes(22) + AutoSchemeParseGetRes(25) + AutoSchemeParseGetRes(29) +
                     + AutoSchemeParseGetRes(32) + AutoSchemeParseGetRes(34) + AutoSchemeParseGetRes(35) + AutoSchemeParseGetRes(36) +
                     + AutoSchemeParseGetRes(43) + AutoSchemeParseGetRes(44));

                TestResults.Add(_Scales[1], AutoSchemeParseGetRes(4) + AutoSchemeParseGetRes(7) + AutoSchemeParseGetRes(9) +
                     +AutoSchemeParseGetRes(10) + AutoSchemeParseGetRes(15) + AutoSchemeParseGetRes(17) + AutoSchemeParseGetRes(18) +
                     +AutoSchemeParseGetRes(24) + AutoSchemeParseGetRes(26) + AutoSchemeParseGetRes(41) + AutoSchemeParseGetRes(42) +
                     +AutoSchemeParseGetRes(48) + AutoSchemeParseGetRes(50));

                TestResults.Add(_Scales[2], AutoSchemeParseGetRes(2) + AutoSchemeParseGetRes(3) + AutoSchemeParseGetRes(11) +
                     +AutoSchemeParseGetRes(12) + AutoSchemeParseGetRes(19) + AutoSchemeParseGetRes(27) + AutoSchemeParseGetRes(28) +
                     +AutoSchemeParseGetRes(33) + AutoSchemeParseGetRes(37) + AutoSchemeParseGetRes(38) + AutoSchemeParseGetRes(47) +
                     +AutoSchemeParseGetRes(49));

                TestResults.Add(_Scales[3], AutoSchemeParseGetRes(6) + AutoSchemeParseGetRes(13) + AutoSchemeParseGetRes(14) +
                     +AutoSchemeParseGetRes(16) + AutoSchemeParseGetRes(20) + AutoSchemeParseGetRes(23) + AutoSchemeParseGetRes(30) +
                     +AutoSchemeParseGetRes(31) + AutoSchemeParseGetRes(39) + AutoSchemeParseGetRes(40) + AutoSchemeParseGetRes(45) +
                     +AutoSchemeParseGetRes(46));
                #endregion Init Results
            }
            else
            {
                throw new NotAllAnswersReceivedException("Error! Not all answer received!", DateTime.Now);
            }

            return TestResults;
        }
        #endregion Interface Methods

        #region Constructor
        public TworchestvoTestType()
        {
            _Asks = new Dictionary<string, Question>();
            _Scales = new string[] { "Risk appetite", "Complexity", "Curiosity", "Imagination" };
            InfAT = new InformaitionAboutTests();
        }
        #endregion Constructor
    }
}
