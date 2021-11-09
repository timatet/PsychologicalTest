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
    /// Логика взаимодействия для ResultsOfCreativeCharacteristicsTest.xaml
    /// </summary>
    public partial class ResultsOfCreativeCharacteristicsTest : Window
    {
        public ResultsOfCreativeCharacteristicsTest()
        {
            InitializeComponent();
        }

        private void ButtonRepeat_Click(object sender, RoutedEventArgs e)
        {
            CreativeCharacteristicsTest cct = new CreativeCharacteristicsTest();
            cct.Show();
            this.Close();
        }

        private void ButtonSaveResults_Click(object sender, RoutedEventArgs e)
        {
            //передать как-то результаты теста
            SaveResults sr = new SaveResults();
            sr.ShowDialog();
        }

        private void ButtonReturnToTheMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.ShowDialog();
        }
    }
}
