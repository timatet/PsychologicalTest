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
using System.Windows.Navigation;
using System.Windows.Shapes;
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
                    case "Дианостика мотивационной структуры личности":
                        DesAndIns._lableNameOfTest.Content = "Дианостика мотивационной структуры личности";
                        DesAndIns.DescriptionOfTest.Text = InfAT.TestDescription[0];                            
                        DesAndIns.InstructionOfTest.Text = InfAT.TestInstruction[0];
                        break;
                    case "Личностные творческие характеристики":
                        DesAndIns._lableNameOfTest.Content = "Личностные творческие характеристики";
                        DesAndIns.DescriptionOfTest.Text = InfAT.TestDescription[1];                            
                        DesAndIns.InstructionOfTest.Text = InfAT.TestInstruction[1];
                        break;
                }
            }

        }
    }
}
