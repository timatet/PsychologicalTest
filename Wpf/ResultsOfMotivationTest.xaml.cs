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
    /// Логика взаимодействия для ResultsOfMotivationTest.xaml
    /// </summary>
    public partial class ResultsOfMotivationTest : Window
    {
        public PsychologicalTest psychologicaltest;

        public ResultsOfMotivationTest(PsychologicalTest psychologicaltest)
        {
            InitializeComponent();
            this.psychologicaltest = psychologicaltest;
        }

        private void ButtonRepeat_Click(object sender, RoutedEventArgs e)
        {
            MotivationTest mt = new MotivationTest();
            mt.Show();
            this.Close();
        }

        private void ButtonSaveResults_Click(object sender, RoutedEventArgs e)
        {
            //передать как-то результаты теста
            SaveResults sr = new SaveResults();
            sr.psychologicaltest = (PsychologicalTest)psychologicaltest.Clone();
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
