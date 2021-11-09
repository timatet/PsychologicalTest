using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для SaveResults.xaml
    /// </summary>
    public partial class SaveResults : Window
    {
        public SaveResults()
        {
            InitializeComponent();
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
            string name = NameOfUser.Text, gender = GenderOfUser.SelectedItem.ToString(),
                dopInfo = AdditionalInformationOfUser.Text;
            int age = int.Parse(AgeOfUser.SelectedItem.ToString());
            // закроет окно регистрации
            //откроет уведомление messagewindow , что все отправил
            string message = "Результаты сохранены";
            MessageWindow mw = new MessageWindow();
            mw.MessageTextBlock.Text = message;
            this.Close();
            mw.ShowDialog();

        }
    }
}
