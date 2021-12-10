using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для SaveResults.xaml
    /// </summary>
    public partial class SaveResults : Window
    {
        public PsychologicalTest psychologicaltest;

        public SaveResults(PsychologicalTest psychologicalTest)
        {
            InitializeComponent();
            psychologicaltest = psychologicalTest;
            for (int i = 7; i < 100; ++i)
                AgeOfUser.Items.Add(i);
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            //вернется к результатам
            this.Close();
            return;
        }

        private void ButtonSaveResults_Click(object sender, RoutedEventArgs e)
        {
            // сохранит результат
            string name = NameOfUser.Text, 
                gender = GenderOfUser.Text,
                dopInfo = AdditionalInformationOfUser.Text;
            int age = int.Parse(AgeOfUser.SelectedItem.ToString());
            // закроет окно регистрации

            // процесс сохранения результатов это вызов метода сохранения из объекта теста
            string[] fio = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (!IsNameCorrect() || string.IsNullOrEmpty(gender))
            {
                MessageWindow msgWindow = new MessageWindow();
                msgWindow.MessageTextBlock.Text = "Некорректно введены данные. Пожалуйста, повторите.";
                msgWindow.ShowDialog();
                return;
            }

            UserClass uc = new UserClass(fio[0], fio[1], fio[2], gender, age, dopInfo);
            uc.RegisterTest(psychologicaltest);
            uc.SaveResults(new ConvertTestToXL());

            //откроет уведомление messagewindow , что все отправил
            string message = "Результаты сохранены";
            MessageWindow mw = new MessageWindow();
            mw.MessageTextBlock.Text = message;
            this.Close();
            mw.ShowDialog();
        }

        private void CheckCorrectInput(object sender, System.Windows.Input.KeyEventArgs e)
        {
            IsNameCorrect();
        }

        public bool IsNameCorrect()
        {
            string text = NameOfUser.Text;
            Regex isNameOK = new Regex(@"^\s*([a-zA-Z]|[а-яА-Я])+\s+([a-zA-Z]|[а-яА-Я])+\s+([a-zA-Z]|[а-яА-Я])+\s*$");
            if (!isNameOK.IsMatch(text))
            {
                NameOfUser.Foreground = Brushes.White;
                NameOfUser.Background = new SolidColorBrush(Color.FromRgb(255, 182, 185));
                return false;
            }
            else
            {
                NameOfUser.Foreground = Brushes.Black;
                NameOfUser.Background = new SolidColorBrush(Color.FromRgb(187, 222, 214));
                return true;
            }
        }
    }
}
