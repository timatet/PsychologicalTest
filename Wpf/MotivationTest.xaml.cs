using System.Windows;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MotivationTest.xaml
    /// </summary>
    public partial class MotivationTest : Window
    {
        private PsychologicalTest psychologicalTest;
        private int QuestionCounter;

        public MotivationTest()
        {
            InitializeComponent();

            psychologicalTest = new PsychologicalTest(new MotivationTestType());

            //NumberOfStatement - утвержд номер
            // Statement - утверждение
            //Answer - гипотеза утверждегния

            Statement.Text = psychologicalTest[0].Value.QuestionBlock;
            Answer.Text = psychologicalTest[0].Value.QuestionName;
            QuestionCounter = 1;
            CountQuestions.Text = $"{(QuestionCounter - 1) / 8}/14";
        }

        private void EnterTheAction()
        {
            //увеличить счетчик вопросов
            CountQuestions.Text = $"{QuestionCounter / 8}/14";

            //если вопрос последний, то открыть уведомление
            if (QuestionCounter == 112)
            {
                ProgressInTest.Value = 112;
                TestingIsOver tio = new TestingIsOver { Owner = this };

                try
                {
                    psychologicalTest.GetAllAnswers();
                    tio.ResultsScales = psychologicalTest.GetResults();
                }
                catch { }

                if (tio.ShowDialog() == true)
                {
                    ProgressInTest.Value--;
                    CountQuestions.Text = $"{(int)(ProgressInTest.Value / 8)}/14";
                } 
            }
            else
            {
                //вывести следующий вопрос
                Statement.Text = psychologicalTest[QuestionCounter].Value.QuestionBlock;
                Answer.Text = psychologicalTest[QuestionCounter].Value.QuestionName;
                //поменять номер
                QuestionCounter++;
                //изменить значение progressbar
                ProgressInTest.Value = QuestionCounter - 1;
                //изменить номер утверждения
                NumberOfStatement.Text = $"Утверждение {psychologicalTest[QuestionCounter - 1].Key}";
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionCounter == 1) return;
            QuestionCounter -= 2;
            EnterTheAction();
        }

        private void ButtonBreakOff_Click(object sender, RoutedEventArgs e)
        {
            AbortTheTest att = new AbortTheTest { Owner = this };
            att.ShowDialog();
        }

        private void RadioButton_Agree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(3);
            //очистить радиобуттон
            AgreeButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_MaybeAgree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(2);
            //очистить радиобуттон
            MaybeButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_FiftyFifty(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(1);
            //очистить радиобуттон
            FiftyFiftyButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_Disagree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(0);
            //очистить радиобуттон
            DisagreeButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_DontKnow(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(0);
            //очистить радиобуттон
            DontKnowButton.IsChecked = false;

            EnterTheAction();
        }
    }
}
