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
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для ResultsOfCreativeCharacteristicsTest.xaml
    /// </summary>
    public partial class ResultsOfCreativeCharacteristicsTest : Window
    {
        public PsychologicalTest psychologicaltest;

        public ResultsOfCreativeCharacteristicsTest(PsychologicalTest psychologicalTest)
        {
            InitializeComponent();
            this.psychologicaltest = psychologicalTest;

            var Results = psychologicaltest.GetResults();
            // отобразить результаты
            var Scales = psychologicaltest.GetScales();
            //порядок расположения в словаре шкал-ключей
            //"Risk appetite", "Complexity", "Curiosity", "Imagination"


            //PBGeneralScore_Negative;
            //PBGeneralScore_Positive;
            int GeneralResult = Results.Sum(x => x.Value);
            if (GeneralResult > 0)
            {
                PBGeneralScore_Positive.Value = GeneralResult;
            }
            else
            {
                PBGeneralScore_Negative.Value = 50 - (-1) * GeneralResult;
            }

            //PBRisk_Negative;
            //PBRisk_Positive;
            if (Results[Scales[0]] > 0)
            {
                PBRisk_Positive.Value = Results[Scales[0]];
            }
            else if (Results[Scales[0]] < 0)
            {
                PBRisk_Negative.Value = 13 - (-1) * Results[Scales[0]];
            }

            //PBCurious_Negative;
            //PBCurious_Positive;
            if (Results[Scales[2]] > 0)
            {
                PBCurious_Positive.Value = Results[Scales[2]];
            }
            else if (Results[Scales[2]] < 0)
            {
                PBCurious_Negative.Value = 12 - (-1) * Results[Scales[2]];
            }

            //PBHard_Negative;
            //PBHard_Positive;
            if (Results[Scales[1]] > 0)
            {
                PBHard_Positive.Value = Results[Scales[1]];
            }
            else if (Results[Scales[1]] < 0)
            {
                PBHard_Negative.Value = 13 - (-1) * Results[Scales[1]];
            }

            //PBImagination_Negative;
            //PBImagination_Positive;
            if (Results[Scales[3]] > 0)
            {
                PBImagination_Positive.Value = Results[Scales[3]];
            }
            else if (Results[Scales[3]] < 0)
            {
                PBImagination_Negative.Value = 12 - (-1) * Results[Scales[3]];
            }
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
            SaveResults sr = new SaveResults(psychologicaltest);
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
