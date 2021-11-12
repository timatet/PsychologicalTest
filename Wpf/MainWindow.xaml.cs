using System.Windows;
using psychologicaltestlib;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private string[] TestNames = {
        //        "Дианостика мотивационной структуры личности",
        //        "Личностные творческие характеристики" };
        InformaitionAboutTests InfAT = new InformaitionAboutTests();
        public MainWindow()
        {
            InitializeComponent();
            ListOfTestNames.ItemsSource = InfAT.TestNames;
        }
        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
            if (ListOfTestNames.SelectedItem != null)
            {
                // запустить нужный тест
                string NameOfTest = ListOfTestNames.SelectedItem.ToString();
                DescriptionAndInstruction DesAndIns = new DescriptionAndInstruction();
                this.Close();
                DesAndIns.Show();
                switch (NameOfTest)
                {
                    case "Диагностика мотивационной структуры личности":
                        DesAndIns._lableNameOfTest.Content = InfAT.TestNames[0];
                        DesAndIns.DescriptionOfTest.Text = InfAT.TestDescription[0];
                        DesAndIns.InstructionOfTest.Text = InfAT.TestInstruction[0];
                        break;
                    case "Личностные творческие характеристики":
                        DesAndIns._lableNameOfTest.Content = InfAT.TestNames[1];
                        DesAndIns.DescriptionOfTest.Text = InfAT.TestDescription[1];
                        DesAndIns.InstructionOfTest.Text = InfAT.TestInstruction[1];
                        break;
                }
            }

        }
    }
}
