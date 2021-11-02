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
    /// Логика взаимодействия для DescriptionAndInstruction.xaml
    /// </summary>
    public partial class DescriptionAndInstruction : Window
    {

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainW = new MainWindow();
            this.Close();
            MainW.Show();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDownload_Click(object sender, RoutedEventArgs e)
        {

        }

        public DescriptionAndInstruction()
        {
            InitializeComponent();
        }
    }
}
