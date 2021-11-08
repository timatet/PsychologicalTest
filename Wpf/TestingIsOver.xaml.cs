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

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для TestingIsOver.xaml
    /// </summary>
    public partial class TestingIsOver : Window
    {
        public TestingIsOver()
        {
            InitializeComponent();
        }

        private void ButtonReturnToTheStatements_Click(object sender, RoutedEventArgs e)
        {
            //Закрыть окошко
            this.Close();
        }

        private void ButtonShowResults_Click(object sender, RoutedEventArgs e)
        {
            //перейти на окно с результатами
        }
    }
}
