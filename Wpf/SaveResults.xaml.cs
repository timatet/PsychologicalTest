using System;
using System.Windows;
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
            if (string.IsNullOrEmpty(fio[0]) || string.IsNullOrEmpty(fio[1]) || string.IsNullOrEmpty(fio[2]))
                throw new NotAllFieldsNameInputException();

            UserClass uc = new UserClass(fio[0], fio[1], fio[2], gender, age, dopInfo);
            psychologicaltest.RegisterUser(uc);
            psychologicaltest.SaveResults(new ConvertTestToXL());

            //откроет уведомление messagewindow , что все отправил
            string message = "Результаты сохранены";
            MessageWindow mw = new MessageWindow();
            mw.MessageTextBlock.Text = message;
            this.Close();
            mw.ShowDialog();
        }
    }
}
