using System.Windows;
using System.Windows.Input;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для TestingIsOver.xaml
    /// </summary>
    public partial class TestingIsOver : Window
    {
        public PsychologicalTest psychologicaltest;

        public TestingIsOver()
        {
            InitializeComponent();
        }

        private void MouseDown_Click(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonReturnToTheStatements_Click(object sender, RoutedEventArgs e)
        {
            //Закрыть окошко
            this.DialogResult = true;
            this.Close();
        }

        private void ButtonShowResults_Click(object sender, RoutedEventArgs e)
        {
            //перейти на окно с результатами
            this.Close();
            switch (this.Owner.Title)
            {
                case "Диагностика мотивационной структуры личности":
                    ResultsOfMotivationTest rmt = new ResultsOfMotivationTest(psychologicaltest);
                    //rmt.psychologicaltest = psychologicaltest;
                    rmt.Show();
                    break;
                case "Личностные творческие характеристики":
                    ResultsOfCreativeCharacteristicsTest rcct = new ResultsOfCreativeCharacteristicsTest(psychologicaltest);
                    //rcct.psychologicaltest = psychologicaltest;
                    rcct.Show();
                    break;
            }
            this.Owner.Close();
        }
    }
}
