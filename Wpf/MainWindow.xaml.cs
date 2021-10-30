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
        private string[] TestNames = {
                "Дианостика мотивационной структуры личности",
                "Личностные творческие характеристики" };
        public MainWindow()
        {
            InitializeComponent();
            ListOfTestNames.ItemsSource = TestNames;
        }
        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
            string NameOfTest = ListOfTestNames.SelectedItem.ToString();
            // запустить нужный тест
            if (NameOfTest == TestNames[0])
            {
                DescriptionAndInstruction DesAndIns = new DescriptionAndInstruction();
                this.Close();
                DesAndIns.Show();
            }
                
        }
    }
}
