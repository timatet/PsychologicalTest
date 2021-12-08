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
            var Results = psychologicaltest.GetResults();

            //обработка результатов
            //PBLifeSupport
            //PBComfort
            //PBSocialStatus
            //PBCommunication
            //PBGeneralActivity
            //PBCreativeActivity
            //PBSocialUtility


            PBLifeSupport.Value = Results["LifeSupport"];
            TBLifeSupport.Text = Results["LifeSupport"].ToString();

            PBComfort.Value = Results["Comfort"];
            TBComfort.Text = Results["Comfort"].ToString();

            PBSocialStatus.Value = Results["SocialStatus"];
            TBSocialStatus.Text = Results["SocialStatus"].ToString();

            PBCommunication.Value = Results["Communication"];
            TBCommunication.Text = Results["Communication"].ToString();

            PBGeneralActivity.Value = Results["GeneralActivity"];
            TBGeneralActivity.Text = Results["GeneralActivity"].ToString();

            PBCreativeActivity.Value = Results["CreativeActivity"];
            TBCreativeActivity.Text = Results["CreativeActivity"].ToString();

            PBSocialUtility.Value = Results["SocialUtility"];
            TBSocialUtility.Text = Results["SocialUtility"].ToString();

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
