using System;
using System.Windows;
using System.Windows.Input;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для CreativeCharacteristicsTest.xaml
    /// </summary>
    public partial class CreativeCharacteristicsTest : Window
    {
        private PsychologicalTest psychologicalTest;
        private int QuestionCounter;

        public CreativeCharacteristicsTest()
        {
            InitializeComponent();

            psychologicalTest = new PsychologicalTest(new TworchestvoTestType());
            //NumberOfStatement - утвержд номер
            // Statement - утверждение
            Statement.Text = psychologicalTest[0].Value.QuestionName;
            QuestionCounter = 1;
            CountQuestions.Text = $"{QuestionCounter - 1}/50";
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            //если это первый вопрос, то ниче не делаем
            // возращает к предыдущему вопросу (изменить вопрос, номер вопроса, прогресс, счетчик) и стирает ответ на вопросa

            if (QuestionCounter == 1) return;
            QuestionCounter -= 2;
            EnterTheAction();

        }

        private void ButtonBreakOff_Click(object sender, RoutedEventArgs e)
        {
            AbortTheTest att = new AbortTheTest { Owner = this };
            att.ShowDialog();
        }

        private void EnterTheAction()
        {
            //увеличить счетчик вопросов
            CountQuestions.Text = $"{QuestionCounter}/50";

            //если вопрос последний, то открыть уведомление
            if (QuestionCounter == 50)
            {
                ProgressInTest.Value = 50;
                TestingIsOver tio = new TestingIsOver { Owner = this };

                try
                {
                    psychologicalTest.GetAllAnswers();
                }
                catch { }

                tio.psychologicaltest = psychologicalTest;

                if (tio.ShowDialog() == true)
                {
                    ProgressInTest.Value--;
                    CountQuestions.Text = $"{ProgressInTest.Value}/50";
                }
            }
            else
            {
                //вывести следующий вопрос
                Statement.Text = psychologicalTest[QuestionCounter].Value.QuestionName;
                //поменять номер
                QuestionCounter++;
                //изменить значение progressbar
                ProgressInTest.Value = QuestionCounter - 1;
                //изменить номер утверждения
                NumberOfStatement.Text = $"Утверждение №{QuestionCounter}";
            }
        }

        private void RadioButton_Agree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(3);
            //очистить радиобуттон
            AgreeButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_AgreeFomThePart(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(2);
            //очистить радиобуттон
            AgreeFomThePartButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_Doubt(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(0);
            //очистить радиобуттон
            DoubtButton.IsChecked = false;

            EnterTheAction();
        }

        private void RadioButton_Disagree(object sender, RoutedEventArgs e)
        {
            //сохранить ответ 
            psychologicalTest[QuestionCounter - 1].Value.SetAnswer(1);
            //очистить радиобуттон
            DisagreeButton.IsChecked = false;

            EnterTheAction();
        }

        private void ShiftQ(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift && e.Key == Key.Q)
            {
                Random rnd = new Random(DateTime.Now.Millisecond);
                foreach (Question q in psychologicalTest)
                {
                    q.SetAnswer(rnd.Next(0, 3));
                }

                QuestionCounter = 50;
                ProgressInTest.Value = 50;
                TestingIsOver tio = new TestingIsOver { Owner = this };

                tio.psychologicaltest = psychologicalTest;

                if (tio.ShowDialog() == true)
                {
                    ProgressInTest.Value--;
                    CountQuestions.Text = $"{ProgressInTest.Value}/50";
                }
            }
        }
    }
}
