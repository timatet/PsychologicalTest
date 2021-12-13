using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
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

            if (fio.Length == 0 || string.IsNullOrWhiteSpace(fio[0]))
            {
                MessageWindow err = new MessageWindow();
                err.MessageTextBlock.Text = "Поле ФИО не заполнено.";
                if (err.ShowDialog() == true)
                {
                    return;
                }
            }

            string firstname = fio[0];
            string lastname = fio.Length >= 2 ? fio[1] : "-";
            string middlename = fio.Length >= 3 ? fio[2] : "-";

            UserClass uc = new UserClass(firstname, lastname, middlename, gender, age, dopInfo);
            uc.RegisterTest(psychologicaltest);
            uc.SaveResults(new ConvertTestToXL());

            //откроет уведомление messagewindow , что все отправил
            string message = "Результаты сохранены";
            MessageWindow mw = new MessageWindow();
            mw.MessageTextBlock.Text = message;
            this.Close();
            mw.ShowDialog();
        }

        private void CheckCorrectInput(object sender, KeyEventArgs e)
        {
            
        }

        private void NameOfUser_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NameOfUser.Text))
            {
                NameOfUser.Visibility = System.Windows.Visibility.Collapsed;
                Watermarket.Visibility = System.Windows.Visibility.Visible;
            }
        }
        private void Watermarket_GotFocus(object sender, RoutedEventArgs e)
        {
            Watermarket.Visibility = System.Windows.Visibility.Collapsed;
            NameOfUser.Visibility = System.Windows.Visibility.Visible;
            NameOfUser.Focus();
        }
    }
}
