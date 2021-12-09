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
            var Results = psychologicaltest.GetResults();

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
            double RatioLifeSupport = ArithmeticMeanResult / 22;
            double AverageValueLifeSupport = Results["LifeSupport"] * RatioLifeSupport;
            PBLifeSupport.Value = AverageValueLifeSupport;
            TBLifeSupport.Text = AverageValueLifeSupport.ToString("N1");

            PBComfort.Maximum = ArithmeticMeanResult;
            double RatioComfort = ArithmeticMeanResult / 22;
            double AverageValueComfort = Results["Comfort"] * RatioComfort;
            PBComfort.Value = AverageValueComfort;
            TBComfort.Text = AverageValueComfort.ToString("N1");

            PBSocialStatus.Maximum = ArithmeticMeanResult;
            double RatioSocialStatus = ArithmeticMeanResult / 26;
            double AverageValueSocialStatus = Results["SocialStatus"] * RatioSocialStatus;
            PBSocialStatus.Value = AverageValueSocialStatus;
            TBSocialStatus.Text = AverageValueSocialStatus.ToString("N1");

            PBCommunication.Maximum = ArithmeticMeanResult;
            double RatioCommunication = ArithmeticMeanResult / 28;
            double AverageValueCommunication = Results["Communication"] * RatioCommunication;
            PBCommunication.Value = AverageValueCommunication;
            TBCommunication.Text = AverageValueCommunication.ToString("N1");

            PBGeneralActivity.Maximum = ArithmeticMeanResult;
            double RatioGeneralActivity = ArithmeticMeanResult / 24;
            double AverageValueGeneralActivity = Results["GeneralActivity"] * RatioGeneralActivity;
            PBGeneralActivity.Value = AverageValueGeneralActivity;
            TBGeneralActivity.Text = AverageValueGeneralActivity.ToString("N1");

            PBCreativeActivity.Maximum = ArithmeticMeanResult;
            double RatioCreativeActivity = ArithmeticMeanResult / 32;
            double AverageValueCreativeActivity = Results["CreativeActivity"] * RatioCreativeActivity;
            PBCreativeActivity.Value = AverageValueCreativeActivity;
            TBCreativeActivity.Text = AverageValueCreativeActivity.ToString("N1");

            PBSocialUtility.Maximum = ArithmeticMeanResult;
            double RatioSocialUtility = ArithmeticMeanResult / 32;
            double AverageValueSocialUtility = Results["SocialUtility"] * RatioSocialUtility;
            PBSocialUtility.Value = AverageValueSocialUtility;
            TBSocialUtility.Text = AverageValueSocialUtility.ToString("N1");

            // Новые шкалы "Эмоциональный профиль"
            // "StenType", "AstenType", "StenFrust", "AstenFrust"
        }

        private void ButtonRepeat_Click(object sender, RoutedEventArgs e)
        {
            MotivationTest mt = new MotivationTest();
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
