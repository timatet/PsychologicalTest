using System.Windows;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListOfTestNames.ItemsSource = new string[] { 
                "Диагностика мотивационной структуры личности", 
                "Личностные творческие характеристики" };
        }
        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
            if (ListOfTestNames.SelectedItem != null)
            {
                // запустить нужный тест
                // Тест создается здесь! И только здесь
                
                PsychologicalTest psychologicalTest = new PsychologicalTest();
                switch (ListOfTestNames.SelectedIndex)
                {
                    case 0:
                        psychologicalTest.InitTest(new MotivationTestType());
                        break;
                    case 1:
                        psychologicalTest.InitTest(new TworchestvoTestType());
                        break;
                }

                DescriptionAndInstruction DesAndIns = new DescriptionAndInstruction(psychologicalTest);
                DesAndIns._lableNameOfTest.Content = psychologicalTest.GetNameOfTest();
                DesAndIns.DescriptionOfTest.Text = psychologicalTest.GetDescriptionOfTest();
                DesAndIns.InstructionOfTest.Text = psychologicalTest.GetInstructionOfTest();
                this.Close();
                DesAndIns.Show();
            }

        }
    }
}
