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
        public Dictionary<string, int> ResultsScales;

        public ResultsOfCreativeCharacteristicsTest()
        {
            InitializeComponent();
            // отобразить результаты
            //PBGeneralScore_Negative;
            //PBGeneralScore_Positive;
            //PBRisk_Negative;
            //PBRisk_Positive;
            //PBCurious_Negative;
            //PBCurious_Positive;
            //PBHard_Negative;
            //PBHard_Positive;
            //PBImagination_Negative;
            //PBImagination_Positive;
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
