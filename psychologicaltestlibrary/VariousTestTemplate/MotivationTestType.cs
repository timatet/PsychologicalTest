using System;
using System.Collections.Generic;
using System.Linq;

namespace psychologicaltestlib
{
    public class MotivationTestType : IVariousTestTemplate
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
        public string GetNameOfTest() => InfAT.TestNames[0];
        public string GetDescriptionOfTest() => InfAT.TestDescription[0];
        public string[] GetScales() => _Scales;
        public void InitQuestions()
        {
            #region Init Questions
            string QuestionBlock1 = "В своем поведении в жизни нужно придерживаться следующего принципа:";
            Asks.Add("1A", new Question(QuestionBlock1, "«время - деньги». Нужно стремиться зарабатывать их больше."));
            Asks.Add("1B", new Question(QuestionBlock1, "«главное – здоровье». Нужно беречь себя и свои нервы."));
            Asks.Add("1C", new Question(QuestionBlock1, "свободное время нужно проводить с друзьями."));
            Asks.Add("1D", new Question(QuestionBlock1, "свободное время нужно отдавать семье."));
            Asks.Add("1E", new Question(QuestionBlock1, "нужно делать добро, даже если это дорого обходится."));
            Asks.Add("1F", new Question(QuestionBlock1, "нужно делать все возможное, чтобы завоевать место под солнцем."));
            Asks.Add("1G", new Question(QuestionBlock1, "нужно приобретать больше знаний, чтобы понять причины и сущность того, что происходит вокруг."));
            Asks.Add("1H", new Question(QuestionBlock1, "нужно стремиться открыть что-то новое, создать, изобрести."));

            string QuestionBlock2 = "В своем поведении на работе нужно следовать такому принципу:";
            Asks.Add("2A", new Question(QuestionBlock2, "работа – это вынужденная жизненная необходимость."));
            Asks.Add("2B", new Question(QuestionBlock2, "главное – не допускать конфликтов."));
            Asks.Add("2C", new Question(QuestionBlock2, "нужно стремиться обеспечить себя спокойными, удобными условиями."));
            Asks.Add("2D", new Question(QuestionBlock2, "нужно активно стремиться к служебному продвижению."));
            Asks.Add("2E", new Question(QuestionBlock2, "главное – завоевать авторитет и признание."));
            Asks.Add("2F", new Question(QuestionBlock2, "нужно постоянно совершенствоваться в своем деле."));
            Asks.Add("2G", new Question(QuestionBlock2, "в своей работе всегда можно найти интересное, то, что может увлечь."));
            Asks.Add("2H", new Question(QuestionBlock2, "нужно не только увлечься самому, но и увлечь работой других."));

            string QuestionBlock3 = "Среди моих дел в свободное от работы (учебы) время большое место занимают следующие дела:";
            Asks.Add("3A", new Question(QuestionBlock3, "текущие, домашние."));
            Asks.Add("3B", new Question(QuestionBlock3, "отдых и развлечения."));
            Asks.Add("3C", new Question(QuestionBlock3, "встречи с друзьями."));
            Asks.Add("3D", new Question(QuestionBlock3, "общественные дела."));
            Asks.Add("3E", new Question(QuestionBlock3, "занятия с детьми."));
            Asks.Add("3F", new Question(QuestionBlock3, "чтение дополнительной, необходимой для учебы (работы) литературы."));
            Asks.Add("3G", new Question(QuestionBlock3, "«хобби»."));
            Asks.Add("3H", new Question(QuestionBlock3, "подрабатывание денег."));

            string QuestionBlock4 = "Среди моих рабочих дел много места занимают:";
            Asks.Add("4A", new Question(QuestionBlock4, "деловое общение (переговоры, выступления, обсуждения и т.д.)."));
            Asks.Add("4B", new Question(QuestionBlock4, "личное общение (на темы, не связанные с работой)."));
            Asks.Add("4C", new Question(QuestionBlock4, "общественная работа."));
            Asks.Add("4D", new Question(QuestionBlock4, "учеба, получение новой информации, повышение квалификации."));
            Asks.Add("4E", new Question(QuestionBlock4, "работа творческого характера."));
            Asks.Add("4F", new Question(QuestionBlock4, "работа, непосредственно влияющая на заработок."));
            Asks.Add("4G", new Question(QuestionBlock4, "работа, непосредственно влияющая на заработок."));
            Asks.Add("4H", new Question(QuestionBlock4, "свободное время, перекуры, отдых."));

            string QuestionBlock5 = "Если бы мне добавили дополнительный выходной день, я бы скорее всего потратил его на то чтобы:";
            Asks.Add("5A", new Question(QuestionBlock5, "заниматься текущими домашними делами."));
            Asks.Add("5B", new Question(QuestionBlock5, "отдыхать."));
            Asks.Add("5C", new Question(QuestionBlock5, "развлекаться."));
            Asks.Add("5D", new Question(QuestionBlock5, "заниматься общественной работой."));
            Asks.Add("5E", new Question(QuestionBlock5, "заниматься учебой, получать новые знания."));
            Asks.Add("5F", new Question(QuestionBlock5, "заниматься творческой работой."));
            Asks.Add("5G", new Question(QuestionBlock5, "делать дело, в котором чувствуешь ответственность перед другими."));
            Asks.Add("5H", new Question(QuestionBlock5, "делать дело, дающее возможность зарабатывать."));

            string QuestionBlock6 = "Если бы у меня была возможность полностью по-своему планировать рабочий день, я бы стал скорее всего заниматься:";
            Asks.Add("6A", new Question(QuestionBlock6, "тем, что составляет мои основные обязанности."));
            Asks.Add("6B", new Question(QuestionBlock6, "общением с людьми по делам (переговоры, обсуждения)."));
            Asks.Add("6C", new Question(QuestionBlock6, "личным общением (разговорами, не связанными с работой)."));
            Asks.Add("6D", new Question(QuestionBlock6, "общественной работой."));
            Asks.Add("6E", new Question(QuestionBlock6, "учебой, получением новых знаний, повышением квалификации."));
            Asks.Add("6F", new Question(QuestionBlock6, "творческой работой."));
            Asks.Add("6G", new Question(QuestionBlock6, "работой, в которой чувствуешь пользу и ответственность."));
            Asks.Add("6H", new Question(QuestionBlock6, "работой, за которую можно получить больше денег."));

            string QuestionBlock7 = "Я часто разговариваю с друзьями и знакомыми на такие темы:";
            Asks.Add("7A", new Question(QuestionBlock7, "где что можно купить, как хорошо провести время."));
            Asks.Add("7B", new Question(QuestionBlock7, "об общих знакомых."));
            Asks.Add("7C", new Question(QuestionBlock7, "о том, что вижу и слышу вокруг."));
            Asks.Add("7D", new Question(QuestionBlock7, "как добиться успеха в жизни."));
            Asks.Add("7E", new Question(QuestionBlock7, "об работе (учебе)."));
            Asks.Add("7F", new Question(QuestionBlock7, "о своих увлечениях («хобби»)."));
            Asks.Add("7G", new Question(QuestionBlock7, "о своих успехах и планах."));
            Asks.Add("7H", new Question(QuestionBlock7, "о жизни, книгах, кинофильмах, политике."));

            string QuestionBlock8 = "Моя работа дает мне прежде всего:";
            Asks.Add("8A", new Question(QuestionBlock8, "достаточные материальные средства для жизни."));
            Asks.Add("8B", new Question(QuestionBlock8, "общение с людьми, дружеские отношения."));
            Asks.Add("8C", new Question(QuestionBlock8, "авторитет и уважение окружающих."));
            Asks.Add("8D", new Question(QuestionBlock8, "интересные встречи и беседы."));
            Asks.Add("8E", new Question(QuestionBlock8, "удовлетворение непосредственно от самой работы."));
            Asks.Add("8F", new Question(QuestionBlock8, "чувство своей полезности."));
            Asks.Add("8G", new Question(QuestionBlock8, "возможность повышать свой профессиональный уровень."));
            Asks.Add("8H", new Question(QuestionBlock8, "возможность служебного продвижения."));

            string QuestionBlock9 = "Больше всего мне хочется бывать в таком обществе, где:";
            Asks.Add("9A", new Question(QuestionBlock9, "уютно, хорошие развлечения."));
            Asks.Add("9B", new Question(QuestionBlock9, "можно обсудить волнующие тебя вопросы учебы или будущей работы."));
            Asks.Add("9C", new Question(QuestionBlock9, "тебя уважают, считают авторитетом."));
            Asks.Add("9D", new Question(QuestionBlock9, "можно встретиться с нужными людьми, завязать полезные связи."));
            Asks.Add("9E", new Question(QuestionBlock9, "можно приобрести новых друзей."));
            Asks.Add("9F", new Question(QuestionBlock9, "бывают известные заслуженные люди."));
            Asks.Add("9G", new Question(QuestionBlock9, "все связаны общим делом."));
            Asks.Add("9H", new Question(QuestionBlock9, "можно проявить и развить способности."));

            string QuestionBlock10 = "Я хотел бы на работе быть с такими людьми:";
            Asks.Add("10A", new Question(QuestionBlock10, "с которыми можно поговорить на разные темы."));
            Asks.Add("10B", new Question(QuestionBlock10, "которым мог бы передавать свой опыт и знания."));
            Asks.Add("10C", new Question(QuestionBlock10, "с которыми можно больше заработать."));
            Asks.Add("10D", new Question(QuestionBlock10, "которые имеют авторитет и вес на работе."));
            Asks.Add("10E", new Question(QuestionBlock10, "которые могут научить чему-нибудь полезному."));
            Asks.Add("10F", new Question(QuestionBlock10, "которые заставляют тебя становиться активнее на работе."));
            Asks.Add("10G", new Question(QuestionBlock10, "которые имеют много знаний и интересных идей."));
            Asks.Add("10H", new Question(QuestionBlock10, "которые готовы поддержать тебя в разных ситуациях."));

            string QuestionBlock11 = "К настоящему времени я имею в достаточной степени:";
            Asks.Add("11A", new Question(QuestionBlock11, "материальное благополучие."));
            Asks.Add("11B", new Question(QuestionBlock11, "возможность интересно развлекаться."));
            Asks.Add("11C", new Question(QuestionBlock11, "хорошие условия жизни."));
            Asks.Add("11D", new Question(QuestionBlock11, "хорошую семью."));
            Asks.Add("11E", new Question(QuestionBlock11, "возможности интересно проводить время в обществе."));
            Asks.Add("11F", new Question(QuestionBlock11, "уважение, признание и благодарность других."));
            Asks.Add("11G", new Question(QuestionBlock11, "чувство полезности для других."));
            Asks.Add("11H", new Question(QuestionBlock11, "созданного чего-то ценного, полезного."));

            string QuestionBlock12 = "Я думаю, что, занимаясь своей работой, имею в достаточной степени:";
            Asks.Add("12A", new Question(QuestionBlock12, "хорошую зарплату, другие материальные блага."));
            Asks.Add("12B", new Question(QuestionBlock12, "хорошие условия для работы."));
            Asks.Add("12C", new Question(QuestionBlock12, "хороший коллектив, дружеские взаимоотношения."));
            Asks.Add("12D", new Question(QuestionBlock12, "определенные творческие достижения."));
            Asks.Add("12E", new Question(QuestionBlock12, "хорошую должность."));
            Asks.Add("12F", new Question(QuestionBlock12, "самостоятельность и независимость."));
            Asks.Add("12G", new Question(QuestionBlock12, "авторитет и уважение коллег."));
            Asks.Add("12H", new Question(QuestionBlock12, "высокий профессиональный уровень."));

            string QuestionBlock13 = "Больше всего мне нравится, когда:";
            Asks.Add("13A", new Question(QuestionBlock13, "нет насущных забот."));
            Asks.Add("13B", new Question(QuestionBlock13, "кругом – комфортное, приятное окружение."));
            Asks.Add("13C", new Question(QuestionBlock13, "кругом – оживление, веселая суета."));
            Asks.Add("13D", new Question(QuestionBlock13, "предстоит провести время в веселом обществе."));
            Asks.Add("13E", new Question(QuestionBlock13, "испытываю чувство соревнования, риска."));
            Asks.Add("13F", new Question(QuestionBlock13, "испытываю чувство активного напряжения и ответственности."));
            Asks.Add("13G", new Question(QuestionBlock13, "погружен в учебу (свою работу)."));
            Asks.Add("13H", new Question(QuestionBlock13, "включен в совместную работу с другими."));

            string QuestionBlock14 = "Когда меня постигает неудача, не получается того, что я очень хочу:";
            Asks.Add("14A", new Question(QuestionBlock14, "я расстраиваюсь и долго переживаю."));
            Asks.Add("14B", new Question(QuestionBlock14, "стараюсь переключиться на что-нибудь другое, приятное."));
            Asks.Add("14C", new Question(QuestionBlock14, "теряюсь, злюсь на себя."));
            Asks.Add("14D", new Question(QuestionBlock14, "злюсь на то, что мне помешало."));
            Asks.Add("14E", new Question(QuestionBlock14, "стараюсь оставаться спокойным."));
            Asks.Add("14F", new Question(QuestionBlock14, "пережидаю, когда пройдет первая реакция, и спокойно анализирую, что произошло."));
            Asks.Add("14G", new Question(QuestionBlock14, "стараюсь понять, в чем я сам был виноват."));
            Asks.Add("14H", new Question(QuestionBlock14, "стараюсь понять причины неудачи и исправить положение."));
            #endregion Init Questions
        }
        public Dictionary<string, int> Processing()
        {           
            Dictionary<string, int> TestResults = new Dictionary<string, int>();

            if (!Asks.Select(a => a.Value.QuestionAnswer).Contains(Question.Default))
            {
                #region Init Results
                TestResults.Add(_Scales[0], (int)Asks["1A"].QuestionAnswer + (int)Asks["1B"].QuestionAnswer + (int)Asks["2A"].QuestionAnswer +
                    (int)Asks["3A"].QuestionAnswer + (int)Asks["4F"].QuestionAnswer + (int)Asks["5A"].QuestionAnswer +
                    (int)Asks["6H"].QuestionAnswer + (int)Asks["8A"].QuestionAnswer + (int)Asks["10E"].QuestionAnswer +
                    (int)Asks["11A"].QuestionAnswer + (int)Asks["12A"].QuestionAnswer);
                TestResults.Add(_Scales[1], (int)Asks["2B"].QuestionAnswer + (int)Asks["2C"].QuestionAnswer + (int)Asks["3B"].QuestionAnswer +
                    (int)Asks["4H"].QuestionAnswer + (int)Asks["5B"].QuestionAnswer + (int)Asks["5C"].QuestionAnswer +
                    (int)Asks["7A"].QuestionAnswer + (int)Asks["9A"].QuestionAnswer + (int)Asks["11B"].QuestionAnswer +
                    (int)Asks["11C"].QuestionAnswer + (int)Asks["12B"].QuestionAnswer);
                TestResults.Add(_Scales[2], (int)Asks["1F"].QuestionAnswer + (int)Asks["2D"].QuestionAnswer + (int)Asks["7C"].QuestionAnswer +
                    (int)Asks["7D"].QuestionAnswer + (int)Asks["8C"].QuestionAnswer + (int)Asks["8H"].QuestionAnswer +
                    (int)Asks["9C"].QuestionAnswer + (int)Asks["9D"].QuestionAnswer + (int)Asks["9F"].QuestionAnswer +
                    (int)Asks["10D"].QuestionAnswer + (int)Asks["11E"].QuestionAnswer + (int)Asks["12E"].QuestionAnswer +
                    (int)Asks["12F"].QuestionAnswer);
                TestResults.Add(_Scales[3], (int)Asks["1C"].QuestionAnswer + (int)Asks["2E"].QuestionAnswer + (int)Asks["3C"].QuestionAnswer +
                    (int)Asks["4B"].QuestionAnswer + (int)Asks["6C"].QuestionAnswer + (int)Asks["7B"].QuestionAnswer +
                    (int)Asks["7H"].QuestionAnswer + (int)Asks["8B"].QuestionAnswer + (int)Asks["8C"].QuestionAnswer +
                    (int)Asks["9E"].QuestionAnswer + (int)Asks["9H"].QuestionAnswer + (int)Asks["10A"].QuestionAnswer +
                    (int)Asks["11D"].QuestionAnswer + (int)Asks["12C"].QuestionAnswer);
                TestResults.Add(_Scales[4], (int)Asks["1D"].QuestionAnswer + (int)Asks["1H"].QuestionAnswer + (int)Asks["4A"].QuestionAnswer +
                    (int)Asks["4D"].QuestionAnswer + (int)Asks["5H"].QuestionAnswer + (int)Asks["6A"].QuestionAnswer +
                    (int)Asks["6B"].QuestionAnswer + (int)Asks["6D"].QuestionAnswer + (int)Asks["7E"].QuestionAnswer +
                    (int)Asks["9B"].QuestionAnswer + (int)Asks["10C"].QuestionAnswer + (int)Asks["12H"].QuestionAnswer);
                TestResults.Add(_Scales[5], (int)Asks["1G"].QuestionAnswer + (int)Asks["1H"].QuestionAnswer + (int)Asks["2F"].QuestionAnswer +
                    (int)Asks["2G"].QuestionAnswer + (int)Asks["3G"].QuestionAnswer + (int)Asks["4E"].QuestionAnswer +
                    (int)Asks["5E"].QuestionAnswer + (int)Asks["5F"].QuestionAnswer + (int)Asks["6F"].QuestionAnswer +
                    (int)Asks["7F"].QuestionAnswer + (int)Asks["7G"].QuestionAnswer + (int)Asks["8E"].QuestionAnswer +
                    (int)Asks["8G"].QuestionAnswer + (int)Asks["10G"].QuestionAnswer + (int)Asks["11H"].QuestionAnswer
                    + (int)Asks["12D"].QuestionAnswer);
                TestResults.Add(_Scales[6], (int)Asks["1E"].QuestionAnswer + (int)Asks["2H"].QuestionAnswer + (int)Asks["3D"].QuestionAnswer +
                    (int)Asks["3E"].QuestionAnswer + (int)Asks["4C"].QuestionAnswer + (int)Asks["4G"].QuestionAnswer +
                    (int)Asks["5D"].QuestionAnswer + (int)Asks["5G"].QuestionAnswer + (int)Asks["6G"].QuestionAnswer +
                    (int)Asks["8F"].QuestionAnswer + (int)Asks["9G"].QuestionAnswer + (int)Asks["10B"].QuestionAnswer +
                    (int)Asks["10F"].QuestionAnswer + (int)Asks["11F"].QuestionAnswer + (int)Asks["11G"].QuestionAnswer
                    + (int)Asks["12G"].QuestionAnswer);
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
        public MotivationTestType()
        {
            _Asks = new Dictionary<string, Question>();
            _Scales = new string[] { "LifeSupport", "Comfort", "SocialStatus", "Communication", "GeneralActivity", "CreativeActivity", "SocialUtility" };
            InfAT = new InformaitionAboutTests();
        }
        #endregion Constructor
    }
}
