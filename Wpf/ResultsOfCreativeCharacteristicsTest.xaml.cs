﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Media;
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

            var Results = psychologicaltest.Processing();
            var AverageResults = psychologicaltest.GetAverageResults(Results);
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
                PBRisk_Positive.Value = AverageResults[Scales[0]];
                PBRisk.Text = (Math.Round(AverageResults[Scales[0]], 1)).ToString();

                //!!!!//Надо переделать

                //if (Results[Scales[0]] <= 12) PBRisk_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[0]] <= 21) PBRisk_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[0]] <= 26) PBRisk_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[0]] < 0)
            {
                PBRisk_Negative.Value = PBRisk_Negative.Maximum - (-1) * AverageResults[Scales[0]];
                PBRisk.Text = (Math.Round(AverageResults[Scales[0]], 1)).ToString();
                //PBRisk_Negative.Background = Brushes.DarkRed;
            }

            //PBCurious_Negative;
            //PBCurious_Positive;
            if (Results[Scales[2]] > 0)
            {
                PBCurious_Positive.Value = AverageResults[Scales[2]];
                PBCurious.Text = (Math.Round(AverageResults[Scales[2]], 1)).ToString();
                //if (Results[Scales[2]] <= 11) PBCurious_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[2]] <= 20) PBCurious_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[2]] <= 24) PBCurious_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[2]] < 0)
            {
                PBCurious_Negative.Value = PBCurious_Negative.Maximum - (-1) * AverageResults[Scales[2]];
                PBCurious.Text = (Math.Round(AverageResults[Scales[2]], 1)).ToString();
                //PBCurious_Negative.Background = Brushes.DarkRed;
            }

            //PBHard_Negative;
            //PBHard_Positive;
            if (Results[Scales[1]] > 0)
            {
                PBHard_Positive.Value = AverageResults[Scales[1]];
                PBHard.Text = (Math.Round(AverageResults[Scales[1]], 1)).ToString();
                //if (Results[Scales[1]] <= 12) PBHard_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[1]] <= 21) PBHard_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[1]] <= 26) PBHard_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[1]] < 0)
            {
                PBHard_Negative.Value = PBHard_Negative.Maximum - (-1) * AverageResults[Scales[1]];
                PBHard.Text = (Math.Round(AverageResults[Scales[1]], 1)).ToString();
                //PBHard_Negative.Background = Brushes.DarkRed;
            }

            //PBImagination_Negative;
            //PBImagination_Positive;
            if (Results[Scales[3]] > 0)
            {
                PBImagination_Positive.Value = AverageResults[Scales[3]];
                PBImagination.Text = (Math.Round(AverageResults[Scales[3]], 1)).ToString();
                //if (Results[Scales[3]] <= 11) PBImagination_Positive.Foreground = Brushes.DarkRed;
                //else if (Results[Scales[3]] <= 20) PBImagination_Positive.Foreground = Brushes.Green;
                //else if (Results[Scales[3]] <= 24) PBImagination_Positive.Foreground = Brushes.LimeGreen;
            }
            else if (Results[Scales[3]] < 0)
            {
                PBImagination_Negative.Value = PBImagination_Negative.Maximum - (-1) * AverageResults[Scales[3]];
                PBImagination.Text = (Math.Round(AverageResults[Scales[3]], 1)).ToString();
                //PBImagination_Negative.Background = Brushes.DarkRed;
            }
        }

        private void ButtonRepeat_Click(object sender, RoutedEventArgs e)
        {
            CreativeCharacteristicsTest cct = new CreativeCharacteristicsTest(psychologicaltest);
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
