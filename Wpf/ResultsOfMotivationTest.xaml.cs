using System.Windows;
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
            var Results = psychologicaltest.Processing();
            var AverageResults = psychologicaltest.GetAverageResults(Results);

            //обработка результатов
            //PBLifeSupport
            //PBComfort
            //PBSocialStatus
            //PBCommunication
            //PBGeneralActivity
            //PBCreativeActivity
            //PBSocialUtility

            double ArithmeticMeanResult = (double)(22 + 22 + 26 + 28 + 24 + 32 + 32) / 7;

            PBLifeSupport.Maximum = ArithmeticMeanResult;
            PBLifeSupport.Value = AverageResults["LifeSupport"];
            TBLifeSupport.Text = AverageResults["LifeSupport"].ToString("N1");

            PBComfort.Maximum = ArithmeticMeanResult;
            PBComfort.Value = AverageResults["Comfort"];
            TBComfort.Text = AverageResults["Comfort"].ToString("N1");

            PBSocialStatus.Maximum = ArithmeticMeanResult;
            PBSocialStatus.Value = AverageResults["SocialStatus"];
            TBSocialStatus.Text = AverageResults["SocialStatus"].ToString("N1");

            PBCommunication.Maximum = ArithmeticMeanResult;
            PBCommunication.Value = AverageResults["Communication"];
            TBCommunication.Text = AverageResults["Communication"].ToString("N1");

            PBGeneralActivity.Maximum = ArithmeticMeanResult;
            PBGeneralActivity.Value = AverageResults["GeneralActivity"];
            TBGeneralActivity.Text = AverageResults["GeneralActivity"].ToString("N1");

            PBCreativeActivity.Maximum = ArithmeticMeanResult;
            PBCreativeActivity.Value = AverageResults["GeneralActivity"];
            TBCreativeActivity.Text = AverageResults["GeneralActivity"].ToString("N1");

            PBSocialUtility.Maximum = ArithmeticMeanResult;
            PBSocialUtility.Value = AverageResults["SocialUtility"];
            TBSocialUtility.Text = AverageResults["SocialUtility"].ToString("N1");

            // Новые шкалы "Эмоциональный профиль"
            // "StenType", "AstenType", "StenFrust", "AstenFrust"
        }

        private void ButtonRepeat_Click(object sender, RoutedEventArgs e)
        {
            MotivationTest mt = new MotivationTest(psychologicaltest);
            mt.Show();
            this.Close();
        }

        private void ButtonSaveResults_Click(object sender, RoutedEventArgs e)
        {
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
