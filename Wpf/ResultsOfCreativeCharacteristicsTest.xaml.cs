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
                if (GeneralResult <= 50) PBGeneralScore_Positive.Foreground = Brushes.DarkRed;
                else if (GeneralResult <= 83) PBGeneralScore_Positive.Foreground = Brushes.Green;
                else if (GeneralResult <= 100) PBGeneralScore_Positive.Foreground = Brushes.LimeGreen;
            }
            else
            {
                PBGeneralScore_Negative.Value = PBGeneralScore_Negative.Maximum - (-1) * GeneralResult;
                PBGeneralScore_Negative.Background = Brushes.DarkRed;
            }

            //PBRisk_Negative;
            //PBRisk_Positive;
            if (Results[Scales[0]] > 0)
            {
                PBRisk_Positive.Value = Results[Scales[0]]*12;

                //!!!!//Надо переделать

                //if (Results[Scales[0]] <= 12) PBRisk_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[0]] <= 21) PBRisk_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[0]] <= 26) PBRisk_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[0]] < 0)
            {
                PBRisk_Negative.Value = PBRisk_Negative.Maximum - (-1) * Results[Scales[0]]*12;
                //PBRisk_Negative.Background = Brushes.DarkRed;
            }

            //PBCurious_Negative;
            //PBCurious_Positive;
            if (Results[Scales[2]] > 0)
            {
                PBCurious_Positive.Value = Results[Scales[2]]*13;
                //if (Results[Scales[2]] <= 11) PBCurious_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[2]] <= 20) PBCurious_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[2]] <= 24) PBCurious_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[2]] < 0)
            {
                PBCurious_Negative.Value = PBCurious_Negative.Maximum - (-1) * Results[Scales[2]]*13;
                //PBCurious_Negative.Background = Brushes.DarkRed;
            }

            //PBHard_Negative;
            //PBHard_Positive;
            if (Results[Scales[1]] > 0)
            {
                PBHard_Positive.Value = Results[Scales[1]]*12;
                //if (Results[Scales[1]] <= 12) PBHard_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[1]] <= 21) PBHard_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[1]] <= 26) PBHard_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[1]] < 0)
            {
                PBHard_Negative.Value = PBHard_Negative.Maximum - (-1) * Results[Scales[1]]*12;
                //PBHard_Negative.Background = Brushes.DarkRed;
            }

            //PBImagination_Negative;
            //PBImagination_Positive;
            if (Results[Scales[3]] > 0)
            {
                PBImagination_Positive.Value = Results[Scales[3]]*13;
                //if (Results[Scales[3]] <= 11) PBImagination_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[3]] <= 20) PBImagination_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[3]] <= 24) PBImagination_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[3]] < 0)
            {
                PBImagination_Negative.Value = PBImagination_Negative.Maximum - (-1) * Results[Scales[3]]*13;
                //PBImagination_Negative.Background = Brushes.DarkRed;
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
